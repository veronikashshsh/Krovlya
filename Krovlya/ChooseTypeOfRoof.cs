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
    public partial class ChooseTypeOfRoof : Form
    {

        public ChooseTypeOfRoof()
        {
            InitializeComponent();
            pictureBoxTriangle.SizeMode = PictureBoxSizeMode.StretchImage;

            pictureBoxTriangle.Click += (s, e) => SelectElement("Triangle");
            pictureBoxRectangle.Click += (s, e) => SelectElement("Rectangle");
        }

        private void SelectElement(string elementType)
        {
            selectedElement.SelectComp = elementType;
            MessageBox.Show($"Ви обрали: {elementType}");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonNext_Click(object sender, EventArgs e)
        {

            if (selectedElement.SelectComp == null)
            {
                MessageBox.Show("Будь ласка, оберіть тип елемента перед переходом далі.");
                return;
            }

            MetalRoofData metalRoofData = new MetalRoofData();
            metalRoofData.Show();
            this.Hide();
        }
    }
}
