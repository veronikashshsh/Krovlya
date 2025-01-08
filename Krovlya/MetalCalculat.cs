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
    public partial class MetalCalculat : Form
    {
        public MetalCalculat()
        {
            InitializeComponent();
        }


        public void UpdateLabels(Dictionary<string, string> textUpdates)
        {
            foreach (var item in textUpdates)
            {
                // Шукаємо елемент на формі за його назвою
                var control = this.Controls[item.Key];
                if (control != null && control is Label) // Перевірка, що це Label
                {
                    control.Text = item.Value; // Оновлюємо текст
                }
            }
        }
        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MetalTile formTile = new MetalTile(); //створюємо екземпляр нової форми
            formTile.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


    }
}
