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
        public MetalRoofData()
        {
            InitializeComponent();

            pictureBoxComp.Paint += PictureBoxComp_Paint;
        }

        private void PictureBoxComp_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.Clear(pictureBoxComp.BackColor);
            // Визначаємо, який елемент обрано
            string selectedComp = selectedElement.SelectComp;

            if (string.IsNullOrEmpty(selectedComp))
            {
                return; // Якщо форма не вибрана, не малюємо нічого
            }

            // Отримуємо Graphics для PictureBox
            Graphics g = e.Graphics;

            if (selectedComp == "Triangle")
            {
                DrawTriangle(g, pictureBoxComp.Width, pictureBoxComp.Height);
            }
            else if (selectedComp == "Rectangle")
            {
                DrawRectangle(g, pictureBoxComp.Width, pictureBoxComp.Height);
            }
        }

        private void DrawTriangle(Graphics g, int width, int height)
        {

            // Визначаємо точки трикутника
            Point[] points =
            {
                new Point(width / 2, 0),          // Верхня точка
                new Point(0, height),            // Ліва нижня точка
                new Point(width, height)         // Права нижня точка
            };

            // Малюємо трикутник
            g.FillPolygon(Brushes.Blue, points);
        }

        private void DrawRectangle(Graphics g, int width, int height)
        {

            int padding = 20; // Відступи для підписів
            int rectWidth = pictureBoxComp.Width - 2 * padding;
            int rectHeight = pictureBoxComp.Height - 2 * padding;

            Rectangle rect = new Rectangle(padding, padding, rectWidth, rectHeight);

            
            using (Pen pen = new Pen(Color.Black, 4)) // Товщина лінії = 2
            {
                g.DrawRectangle(pen, rect);
            }

            /*if (rect.Width > 0 && rect.Height > 0)
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
            }*/
        }

 
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            NoteAboutOneComp noteAboutOneComp = new NoteAboutOneComp();
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
    }
}
