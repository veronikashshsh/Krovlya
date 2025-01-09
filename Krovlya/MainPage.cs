using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Krovlya
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();

            
        }


        private void button1_Click(object sender, EventArgs e)
        {

            MetalTile form3 = new MetalTile();
            AmountOfRoof formAmount = new AmountOfRoof();

            // Зберігаємо дані у статичний клас
            GlobalData.LabelData = textBoxData.Text;
            GlobalData.LabelCustomer = textBoxCustomer.Text;
            GlobalData.LabelManager = textBoxManager.Text;
            GlobalData.LabelOrder = textBoxOrder.Text;

            // Відкриваємо форму AmountOfRoof
            formAmount.Show();

            // Ховаємо поточну форму
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            CalculateArea form2 = new CalculateArea(); //створюємо екземпляр нової форми
            form2.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
