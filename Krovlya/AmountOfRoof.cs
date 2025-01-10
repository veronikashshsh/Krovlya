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
    public partial class AmountOfRoof : Form
    {
        public AmountOfRoof()
        {
            InitializeComponent();
            pictureBoxExamp.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        private void buttonNextAm_Click(object sender, EventArgs e)
        {
            /*DataCalculations.AmountOfCompon = int.Parse(textBoxAmount.Text);

            ChooseTypeOfRoof formChooseType = new ChooseTypeOfRoof();
            formChooseType.Show();
            this.Hide();*/

            if (int.TryParse(textBoxAmount.Text, out int numComponents) && numComponents > 0)
            {
                selectedElement.TotalComponents = numComponents;
                //selectedElement.CurrentComponent = 1; // Починаємо з першого компонента.

                if (selectedElement.CurrentComponent < selectedElement.TotalComponents)
                {
                    selectedElement.CurrentComponent++;
                    //int amountOfRoof = selectedElement.TotalComponents;
                    ChooseTypeOfRoof chooseTypeOfRoof = new ChooseTypeOfRoof();
                    chooseTypeOfRoof.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Будь ласка, введіть правильну кількість компонентів (> 0).");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
