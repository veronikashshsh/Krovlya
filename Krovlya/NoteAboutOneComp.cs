using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using iText.IO.Image;
using System.IO;
using System.Xml.Linq;

namespace Krovlya
{
    public partial class NoteAboutOneComp : Form
    {
        public NoteAboutOneComp()
        {
            InitializeComponent();
            this.Load += new EventHandler(NoteForPrint_Load);
        }

        public void UpdateLabels()
        {
            labelMaxZavodLength.Text = GlobalData.MaxLengthZavodMetal;
            labelDiscretLengthMetal.Text = GlobalData.DiskretOfMetal;
            labelData.Text = GlobalData.LabelData;
            CustomerLabel.Text = GlobalData.LabelCustomer;
            SupplierLabel.Text = GlobalData.LabelManager;
            AmountOfMetal.Text = DataCalculations.ResultMetalList.ToString("F0"); 
            MaterialsLabel.Text = GlobalData.NameOfMetalTile;
            labelAmountOfComp.Text = DataCalculations.AmountOfCompon.ToString(); 
            labelArea.Text = DataCalculations.AreaOfRoof.ToString("F4"); 
            labelOrder.Text = GlobalData.LabelOrder;
        }

        private void NoteForPrint_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }
       
        private void buttonNext_Click(object sender, EventArgs e)
        {

            if (selectedElement.CurrentComponent <= selectedElement.TotalComponents)
            {
                selectedElement.CurrentComponent++;
                //int amountOfRoof = selectedElement.CurrentComponent;
                ChooseTypeOfRoof chooseTypeOfRoof = new ChooseTypeOfRoof();
                chooseTypeOfRoof.Show();
                this.Hide();
            } 
            else if(selectedElement.CurrentComponent >= selectedElement.TotalComponents)
            {
                InfoAllMetal infoAllMetal = new InfoAllMetal();
                infoAllMetal.Show();
                this.Hide();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage form1 = new MainPage();
            form1.Show();
            this.Close();
        }


        public class RoofCalculator
        {
            public float RoofWidth { get; set; } // Ширина ската
            public float RoofHeight { get; set; } // довжина ската
            public float SheetWidth { get; set; } // Ширина листа
            public float SheetHeight { get; set; } // довжина листа

            public List<RectangleF> CalculateSheetPositions()
            {
                List<RectangleF> positions = new List<RectangleF>();

                int rows = (int)Math.Ceiling(RoofHeight / SheetHeight); // Кількість рядів
                int columns = (int)Math.Ceiling(RoofWidth / SheetWidth); // Кількість стовпців

                for (int row = 0; row < rows; row++)
                {
                    for (int col = 0; col < columns; col++)
                    {
                        float x = col * SheetWidth;
                        float y = row * SheetHeight;

                        // Додати прямокутник (лист)
                        positions.Add(new RectangleF(x, y, SheetWidth, SheetHeight));
                    }
                }

                return positions;
            }
        }

        private void SavePDFWithText(string filePath)
        {
            try
            {
                using (PdfWriter writer = new PdfWriter(filePath))
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document document = new Document(pdf);
                    document.Add(new iText.Layout.Element.Paragraph("Це тестовий PDF-документ."));
                    document.Close();
                }

                MessageBox.Show("PDF успішно створено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            // Параметри даху та листів
            var calculator = new RoofCalculator
            {
                RoofWidth = 20.0f,  // Наприклад, ширина даху 10 метрів
                RoofHeight = 5.0f,  // довжина 5 метрів
                SheetWidth = 1.165f,  // Листи шириною 1 метр
                SheetHeight = 2.0f  // Листи довжиною 3 метри
            };

            // Масштабування для візуалізації
            float scaleX = panel1.Width / calculator.RoofWidth;
            float scaleY = panel1.Height / calculator.RoofHeight;

            // Отримання позицій листів
            var sheetPositions = calculator.CalculateSheetPositions();

            // Малювання листів
            Brush brush = new SolidBrush(Color.LightBlue);
            Pen pen = new Pen(Color.Black, 1);

            foreach (var rect in sheetPositions)
            {
                // Масштабування
                RectangleF scaledRect = new RectangleF(
                    rect.X * scaleX,
                    rect.Y * scaleY,
                    rect.Width * scaleX,
                    rect.Height * scaleY);

                // Малюємо лист
                g.FillRectangle(brush, scaledRect);
                g.DrawRectangle(pen, scaledRect.X, scaledRect.Y, scaledRect.Width, scaledRect.Height);
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            /* SaveFileDialog saveFileDialog = new SaveFileDialog
             {
                 Filter = "PDF Files|*.pdf",
                 Title = "Зберегти як PDF"
             };

             if (saveFileDialog.ShowDialog() == DialogResult.OK)
             {
                 string filePath = saveFileDialog.FileName;

                 try
                 {
                     // Створення Bitmap форми
                     using (Bitmap formBitmap = new Bitmap(this.Width, this.Height))
                     {
                         this.DrawToBitmap(formBitmap, new Rectangle(0, 0, this.Width, this.Height));

                         // Перевірка: Зберігаємо тимчасове зображення
                         formBitmap.Save("debug_image.png", System.Drawing.Imaging.ImageFormat.Png);

                         // Завантажуємо зображення у iText
                         using (MemoryStream ms = new MemoryStream())
                         {
                             formBitmap.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                             byte[] imageBytes = ms.ToArray();
                             ImageData imageData = ImageDataFactory.Create(imageBytes);

                             // Створення PDF
                             using (PdfWriter writer = new PdfWriter(filePath))
                             using (PdfDocument pdf = new PdfDocument(writer))
                             {
                                 Document document = new Document(pdf);

                                 // Додавання зображення до PDF
                                 iText.Layout.Element.Image pdfImage = new iText.Layout.Element.Image(imageData);
                                 pdfImage.ScaleToFit(pdf.GetDefaultPageSize().GetWidth() - 40, pdf.GetDefaultPageSize().GetHeight() - 40);
                                 pdfImage.SetHorizontalAlignment(iText.Layout.Properties.HorizontalAlignment.CENTER);
                                 document.Add(pdfImage);

                                 document.Close();
                             }
                         }
                     }

                     MessageBox.Show("Форма успішно збережена як PDF!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 catch (Exception ex)
                 {
                     MessageBox.Show($"Помилка при збереженні PDF: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
             }*/

            string filePath = "output.pdf"; // Можна також реалізувати вибір файлу через діалог
            SavePDFWithText(filePath);
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SupplierLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelAmountOfComp_Click(object sender, EventArgs e)
        {

        }

        private void labelArea_Click(object sender, EventArgs e)
        {

        }

        private void labelMaxZavodLength_Click(object sender, EventArgs e)
        {

        }

        private void labelOrder_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
    }
}
