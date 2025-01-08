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
    public partial class MetalTile : Form
    {
        public MetalTile()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
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

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage form1 = new MainPage();
            form1.Show();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            MetalCalculat formMetal = new MetalCalculat();

            double UsefulWidthValue = double.TryParse(textBoxUseWidthList.Text, out double data) ? data : 0; // Парсинг тексту в число
            double FullWidthValue = double.TryParse(textBoxFullWidth.Text, out double customer) ? customer : 0;
            double MaxLengthValue = double.TryParse(textBoxMaxLength.Text, out double manager) ? manager : 0;
            double WidthRoofValue = double.TryParse(textBoxWidthRoof.Text, out double managers) ? managers : 0;

            double resultMetalList = WidthRoofValue/UsefulWidthValue;                     // Наприклад, помножити на 2
            double AreaOfRoof = resultMetalList;

            var textUpdates = new Dictionary<string, string>
           {
                { "labelAmountMetal", resultMetalList.ToString("F0") },         // Значення з textBoxData -> labelData
                { "labelGood", textBoxGood.Text }
           };

            formMetal.UpdateLabels(textUpdates);

            formMetal.Show();
            this.Close();
        }


        private void textBoxGood_TextChanged(object sender, EventArgs e)
        {

        }


        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }
    }
}
