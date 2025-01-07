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
            // Створюємо екземпляр форми MetalTile
            MetalTile form3 = new MetalTile();

            // Створюємо словник із текстами для оновлення
            var textUpdates = new Dictionary<string, string>
    {
       { "labelData", textBoxData.Text },         // Значення з textBoxData -> labelData
        { "labelCustomer", textBoxCustomer.Text }, // Значення з textBoxCustomer -> labelCustomer
        { "labelManager", textBoxManager.Text },
        { "label22", textBox1.Text }
    };

            // Викликаємо метод для оновлення текстів на формі MetalTile
            form3.UpdateLabels(textUpdates);

            // Відкриваємо форму MetalTile
            form3.Show();

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
    }
}
