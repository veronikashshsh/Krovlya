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
    public partial class CalculateArea : Form
    {
        public CalculateArea()
        {
            InitializeComponent();
            this.button2.Click += new System.EventHandler(this.button2_Click);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double length = Convert.ToDouble(LengthInput.Text);
            double width = Convert.ToDouble(WidthInput.Text);
            double area = length * width;

            resultArea.Text = $"Площа: { area}";
        }

        private void label1_Click(object sender, EventArgs e)
        {
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage form1 = new MainPage();
            form1.Show();
            this.Close();
        }
    }
}
