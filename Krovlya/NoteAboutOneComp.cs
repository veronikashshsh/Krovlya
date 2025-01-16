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
using System.Drawing.Text;
using System.Globalization;

namespace Krovlya
{
    public partial class NoteAboutOneComp : Form
    {
        private selectedElement selectedElement;

        private DataCalculationsForTriangle triangleData;
        public NoteAboutOneComp(DataCalculationsForTriangle triangleData)
        {
            InitializeComponent();
            this.Load += new EventHandler(NoteForPrint_Load);
            selectedElement = new selectedElement();
            panel1.Paint += panel1_Paint;
            this.triangleData = triangleData;

            // Розрахунок площі трикутника за формулою Герона
            /*double semiPerimeter = (triangleData.SideAValue + triangleData.SideBValue + triangleData.SideCValue) / 2;
            double area = Math.Sqrt(semiPerimeter * (semiPerimeter - triangleData.SideAValue) *
                                    (semiPerimeter - triangleData.SideBValue) *
                                    (semiPerimeter - triangleData.SideCValue));*/

            //triangleData.AreaValue = area;

            // Створення екземпляра DataCalculationsForTriangle з розрахованою площею
            /*this.traingleData = new DataCalculationsForTriangle
            {
                AreaValue = area,
                SideAValue = sideA,
                SideBValue = sideB,
                SideCValue = sideC
            };*/
        }

        private void NoteForPrint_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        public void UpdateLabels()
        {

            labelMaxZavodLength.Text = GlobalData.MaxLengthZavodMetal;
            labelDiscretLengthMetal.Text = GlobalData.DiskretOfMetal;
            labelData.Text = GlobalData.LabelData;
            CustomerLabel.Text = GlobalData.LabelCustomer;
            SupplierLabel.Text = GlobalData.LabelManager;
            //AmountOfMetal.Text = GlobalData.Label22.ToString();


            MaterialsLabel.Text = GlobalData.NameOfMetalTile;
            labelAmountOfComp.Text = numOfComponents.TotalComponents.ToString();
            // labelArea.Text = DataCalculations.AreaOfRoof.ToString("F4");


            // this.triangleData = triangleData;

            labelOrder.Text = GlobalData.LabelOrder;

            if (this.triangleData is DataCalculationsForTriangle)
            {
                Console.WriteLine($"SideBValue: {this.triangleData.SideBValue}, ResultMetalList: {DataCalculations.UsefulWidthValue}");

                labelArea.Text = this.triangleData.AreaCalc().ToString("F3");
                //AmountOfMetal.Text = (this.triangleData.SideBValue / DataCalculations.ResultMetalList).ToString();
                double result = this.triangleData.SideBValue / DataCalculations.UsefulWidthValue;
                if (double.IsInfinity(result) || double.IsNaN(result))
                {
                    AmountOfMetal.Text = "Некоректний результат";
                }
                else
                {
                    AmountOfMetal.Text = result.ToString("F3");
                }


            }
            /* else if (triangle is DataCalculationsForRectangle rectangleData)
             {
                 labelArea.Text = rectangleData.AreaValue.ToString("F4");
             }
             else
             {
                 labelArea.Text = "Дані недоступні.";
             }*/
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            SharedData.TriangleData = triangleData;
            if (numOfComponents.CurrentComponent < numOfComponents.TotalComponents)
            {
                numOfComponents.CurrentComponent++;
                //int amountOfRoof = selectedElement.CurrentComponent;
                ChooseTypeOfRoof chooseTypeOfRoof = new ChooseTypeOfRoof();
                chooseTypeOfRoof.Show();
                this.Hide();
            }
            else if (numOfComponents.CurrentComponent >= numOfComponents.TotalComponents || numOfComponents.CurrentComponent == 1)
            {
                InfoAllMetal infoAllMetal = new InfoAllMetal(triangleData);
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

        //Stack<Form> formStack = new Stack<Form>();
        private void buttonBackToM_Click(object sender, EventArgs e)
        {
            MetalRoofData formMetal = (MetalRoofData)MetalRoofData.FormStack.Pop();
            
            this.Hide();
            formMetal.Show();
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (triangleData == null)
            {
                MessageBox.Show("Дані трикутника не завантажені.");
                return;
            }
            Graphics g = e.Graphics;
            string selectedComp = selectedElement?.SelectComp;
            double roofWidth = triangleData.SideBValue; // Initialize roofWidth
            //double roofHeight = triangleData.HeightValue;
            double roofHeight = triangleData.HeightValue;


            // double roofHeight = triangleData.HeightValue; // Initialize roofHeight
            //double roofHeight = double.TryParse(triangleData.HeightValue out double int parsedHeight) ? parsedHeight : 0;
            // double roofHeight = 2;


            Console.WriteLine($"SideBValue: {triangleData.SideBValue}, HeightValue: {triangleData.HeightValue}");


            if (roofWidth <= 0 || roofHeight <= 0)
            {
                MessageBox.Show("Некоректні розміри даху. Перевірте введені дані.");
                return;
            }

            // Висота даху
            double sheetWidth = DataCalculations.UsefulWidthValue;   // Ширина листа
            double sheetHeight = DataCalculations.ListLength; // Висота листа залежно від розмірів даху

            // Масштабування для візуалізації
            double scaleX = panel1.Width / roofWidth;
            double scaleY = panel1.Height / roofHeight;

            // Список позицій листів
            List<RectangleF> sheetPositions = new List<RectangleF>();
            int rows = (int)Math.Ceiling(roofHeight / sheetHeight); // Кількість рядів

            // Генерація позицій листів, починаючи знизу
            int totalSheets = 0;
            for (int row = rows - 1; row >= 0; row--)
            {
                // Висота поточного ряду
                double currentRowHeight = row * sheetHeight;

                // Ширина ряду пропорційна висоті
                double currentRowWidth = ((roofHeight - currentRowHeight) / roofHeight) * roofWidth;

                // Початкова X-координата для центрування ряду
                double startX = (roofWidth - currentRowWidth) / 2.0;

                // Кількість листів у ряді
                int sheetsInRow = (int)Math.Ceiling(currentRowWidth / sheetWidth);
                totalSheets += sheetsInRow;

                for (int sheet = 0; sheet < sheetsInRow; sheet++)
                {
                    // Розрахунок позицій листів
                    double x = startX + sheet * sheetWidth;
                    double y = roofHeight - currentRowHeight - sheetHeight; // Відображаємо ряди внизу

                    // Додавання прямокутника (листа) у список
                    sheetPositions.Add(new RectangleF((float)x, (float)y, (float)sheetWidth, (float)sheetHeight));
                }
                Console.WriteLine($"Row: {row}, Row Width: {currentRowWidth}, Sheets in Row: {sheetsInRow}");
                //Console.WriteLine($"SelectedComp: {selectedComp}");
                Console.WriteLine($"Roof Width: {roofWidth}, Roof Height: {roofHeight}");
            }

            using (Brush brush = new SolidBrush(Color.LightBlue))
            using (Pen pen = new Pen(Color.Black, 1))
            {
                foreach (var rect in sheetPositions)
                {

                    RectangleF scaledRect = new RectangleF(
                        (float)(rect.X * scaleX),
                        (float)(rect.Y * scaleY),
                        (float)(rect.Width * scaleX),
                        (float)(rect.Height * scaleY));
                    g.FillRectangle(brush, scaledRect);
                    g.DrawRectangle(pen, scaledRect.X, scaledRect.Y, scaledRect.Width, scaledRect.Height);
                }
            }

            using (Pen trianglePen = new Pen(Color.Red, 2))
            {
                g.DrawLine(trianglePen, 0, panel1.Height, panel1.Width / 2, 0); // Ліва сторона
                g.DrawLine(trianglePen, panel1.Width, panel1.Height, panel1.Width / 2, 0); // Права сторона
                g.DrawLine(trianglePen, 0, panel1.Height, panel1.Width, panel1.Height); // Нижня сторона
            }

            // Виведення загальної кількості листів у консоль
            Console.WriteLine($"Загальна кількість листів: {totalSheets}");
        }

        /*public class RoofCalculator
        {
            /*public List<RectangleF> CalculateSheetPositions()
            {
                List<RectangleF> sheetPositions = new List<RectangleF>();

                // Кількість рядів
                int rows = (int)Math.Ceiling(DataCalculationsForRectangle.LengthValue / DataCalculations.ListLength);
                // Половина ширини даху
                float halfRoofWidth = DataCalculationsForRectangle.WidthValue / 2.0f;

                for (int row = 0; row < rows; row++)
                {
                    // Висота для поточного ряду
                    float rowHeight = DataCalculationsForRectangle.LengthValue - row * DataCalculations.ListLength;
                    // Ширина ряду пропорційно висоті
                    float rowWidth = (rowHeight / DataCalculationsForRectangle.LengthValue) * DataCalculationsForRectangle.WidthValue;

                    // Кількість листів у ряді
                    int sheetsInRow = (int)Math.Ceiling(rowWidth / DataCalculations.ListWidth);
                    // Початкова X-координата
                    float startX = halfRoofWidth - (rowWidth / 2.0f);

                    for (int sheet = 0; sheet < sheetsInRow; sheet++)
                    {
                        // Розрахунок координат для кожного листа
                        float x = startX + sheet * DataCalculations.ListWidth;
                        float y = row * DataCalculations.ListLength;

                        // Додати прямокутник (лист) у список
                        sheetPositions.Add(new RectangleF(x, y, DataCalculations.ListWidth, DataCalculations.ListLength));
                    }
                }

                return sheetPositions;
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
        /*

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
             }

            string filePath = "output.pdf"; // Можна також реалізувати вибір файлу через діалог
            SavePDFWithText(filePath);
        }
        */

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

        private void labelCompOfRoof_Click(object sender, EventArgs e)
        {

        }

        private void NoteAboutOneComp_Load(object sender, EventArgs e)
        {

        }

        private void AmountOfMetal_Click(object sender, EventArgs e)
        {

        }

        private void labelData_Click(object sender, EventArgs e)
        {

        }
    }
}
