using iText.Layout.Properties.Grid;
using iText.StyledXmlParser.Jsoup.Nodes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Krovlya
{
    public partial class MetalRoofData : Form
    {
        private selectedElement selectedElement;

        public MetalRoofData(selectedElement selectedElement)
        {
            InitializeComponent();

            pictureBoxComp.Paint += PictureBoxComp_Paint;
            this.selectedElement = selectedElement; // Ініціалізуємо екземпляр
            AddInputFieldsForShape(selectedElement.SelectComp);
        }

        private void MetalRoofData_Load(object sender, EventArgs e)
        {
            pictureBoxComp.Invalidate(); // Оновлення PictureBox під час завантаження форми
            MessageBox.Show($"Ви обрали {selectedElement.SelectComp}");
        }

        public void AddInputFieldsForShape(string shapeType)
        {
            // Очищаємо наявні елементи, якщо вони вже були додані
            panelInputs.Controls.Clear();
            using (Font font = new Font("Arial", 10))
                if (shapeType == "Triangle")
            {
                // Створення Label для кожної сторони трикутника
                AddLabel("a", 0);
                AddTextBox("sideA", 0);

                AddLabel("b", 1);
                AddTextBox("sideB", 1);

                AddLabel("c", 2);
                AddTextBox("sideC", 2);

               /* AddLabel("Висота", 3);
                AddTextBox("HeightValue", 3);*/
                }
            else if (shapeType == "Rectangle")
            {
                // Створення Label для прямокутника
                AddLabel("Довжина", 0);
                AddTextBox("LengthOfRect", 0);

                AddLabel("Ширина", 1);
                AddTextBox("WidthOfRect", 1);
            }
        }

        private void AddLabel(string text, int index)
        {
            Label label = new Label
            {
                Text = text,
                Location = new Point(10, 30 + index * 40), // Місце для Label
                AutoSize = true
            };
            panelInputs.Controls.Add(label);
        }

        private void AddTextBox(string name, int index)
        {
            TextBox textBox = new TextBox
            {
                Name = name,
                Location = new Point(100, 30 + index * 40), // Місце для TextBox
                Width = 100
            };
            panelInputs.Controls.Add(textBox);
        }


        private void PictureBoxComp_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(pictureBoxComp.BackColor); 
            Graphics g = e.Graphics;
            string selectedComp = selectedElement?.SelectComp;

            float scaleFactor = 0.6f;

            if (selectedComp == "Triangle")
            {
                DrawTriangle(g, pictureBoxComp.Width, pictureBoxComp.Height, scaleFactor);
            }
            else if (selectedComp == "Rectangle")
            {
                DrawRectangle(g, pictureBoxComp.Width, pictureBoxComp.Height, scaleFactor);
            }
            
        }

        private void DrawTriangle(Graphics g, int width, int height, float scaleFactor)
        {
            int triangleWidth = (int)(width * scaleFactor);
            int triangleHeight = (int)(height * scaleFactor);

            // Розрахунок висоти рівностороннього трикутника (від верхньої точки до середини низу)
            float actualHeight = (float)(Math.Sqrt(3) / 2 * triangleWidth);

            // Створюємо точки трикутника
            Point[] points =
            {
        new Point(width / 2, (height - triangleHeight) / 2),  // Верхня точка
        new Point((width - triangleWidth) / 2, (height + triangleHeight) / 2), // Ліва нижня точка
        new Point((width + triangleWidth) / 2, (height + triangleHeight) / 2)  // Права нижня точка
    };

            // Малюємо контури трикутника
            g.DrawPolygon(Pens.Red, points);

            // Знаходимо середину основи трикутника
            Point middleBase = new Point((points[1].X + points[2].X) / 2, points[1].Y);

            // Малюємо лінію, яка з'єднує верхню точку з серединою основи (висота)
            g.DrawLine(Pens.Black, points[0], middleBase);
        



            // Малюємо підписи для сторін
    if (triangleWidth > 0 && triangleHeight > 0)
            {
                using (Font font = new Font("Arial", 10))
                using (Brush brush = Brushes.Black)
                {
                    // Підпис для верхньої сторони
                    Point middleTop = new Point((points[0].X + points[1].X) / 2, (points[0].Y + points[1].Y) / 2);
                    g.DrawString("a", font, brush, middleTop.X - 10, middleTop.Y - 20);

                    // Підпис для лівої сторони
                    Point middleLeft = new Point((points[1].X + points[2].X) / 2, (points[1].Y + points[2].Y) / 2);
                    g.DrawString("b", font, brush, middleLeft.X - 10, middleLeft.Y - 0);

                    // Підпис для правої сторони
                    Point middleRight = new Point((points[2].X + points[0].X) / 2, (points[2].Y + points[0].Y) / 2);
                    g.DrawString("c", font, brush, middleRight.X - 10, middleRight.Y - 30);
                }
            }
        }

        private void DrawRectangle(Graphics g, int width, int height, float scaleFactor)
        {
            int rectWidth = (int)(width * scaleFactor);
            int rectHeight = (int)(height * scaleFactor);

            //int padding = 20; // Відступи для підписів
            Rectangle rect = new Rectangle((width - rectWidth) / 2, (height - rectHeight) / 2, rectWidth, rectHeight);

            // Малюємо прямокутник
            using (Pen pen = new Pen(Color.Black, 4)) // Товщина лінії = 4
            {
                g.DrawRectangle(pen, rect);
            }

            if (rect.Width > 0 && rect.Height > 0)
            {
                using (Font font = new Font("Arial", 10))
                using (Brush brush = Brushes.Black)
                {
                    // Підпис для верхньої сторони
                    g.DrawString("a", font, brush, rect.X + rect.Width / 2 - 10, rect.Y - 20);

                    // Підпис для нижньої сторони
                    g.DrawString("b", font, brush, rect.X + rect.Width / 2 - 10, rect.Y + rect.Height + 5);

                    // Підпис для лівої сторони
                    g.DrawString("c", font, brush, rect.X - 20, rect.Y + rect.Height / 2 - 10);

                    // Підпис для правої сторони
                    g.DrawString("d", font, brush, rect.X + rect.Width + 5, rect.Y + rect.Height / 2 - 10);
                }
            }

        }

 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public void buttonNext_Click(object sender, EventArgs e)
        {
            // Отримуємо значення з текстових полів
            TextBox sideA = panelInputs.Controls.Find("sideA", true).FirstOrDefault() as TextBox;
            TextBox sideB = panelInputs.Controls.Find("sideB", true).FirstOrDefault() as TextBox;
            TextBox sideC = panelInputs.Controls.Find("sideC", true).FirstOrDefault() as TextBox;
            //TextBox heightValue = panelInputs.Controls.Find("HeightValue", true).FirstOrDefault() as TextBox;

            // Перевіряємо та зберігаємо значення у відповідних змінних
            double sideAValue = double.TryParse(sideA.Text, out double tempA) ? tempA : 0;
            double sideBValue = double.TryParse(sideB.Text, out double tempB) ? tempB : 0;
            double sideCValue = double.TryParse(sideC.Text, out double tempC) ? tempC : 0;
           // double heightValueValue = double.TryParse(heightValue.Text, out double tempH) ? tempH : 0;

            // Створюємо об'єкт класу DataCalculationsForTriangle з отриманими значеннями
            DataCalculationsForTriangle triangleData = new DataCalculationsForTriangle(sideAValue, sideBValue, sideCValue);

            // Передаємо об'єкт triangleData до конструктора NoteAboutOneComp
            NoteAboutOneComp noteAboutOneComp = new NoteAboutOneComp(triangleData);
            noteAboutOneComp.Show();
            this.Hide();
        }



        private void buttonBack_Click(object sender, EventArgs e)
        {
            // int amountOfRoof = selectedElement.TotalComponents;
            ChooseTypeOfRoof typeOfRoof = new ChooseTypeOfRoof();
            typeOfRoof.Show();
            this.Hide();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MetalRoofData_Load_1(object sender, EventArgs e)
        {

        }
    }
}
