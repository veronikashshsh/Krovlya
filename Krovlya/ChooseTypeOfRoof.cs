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
            this.Load += new EventHandler(ChooseTypeOfRoof_Load);
            //selectedElement.CurrentComponent = 1;

            //selectedElement.TotalComponents = amountOfRoof;
        }

        private void ChooseTypeOfRoof_Load(object sender, EventArgs e)
        {
            UpdateLabelNumOfRoof();
        }

        private void SelectElement(string elementType)
        {
            selectedElement.SelectComp = elementType;
            MessageBox.Show($"Ви обрали: {elementType}");
        }
        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (selectedElement.SelectComp == null)
            {
                MessageBox.Show("Будь ласка, оберіть тип елемента перед переходом далі.");
                return;
            }

            if (selectedElement.CurrentComponent < selectedElement.TotalComponents)
            {
                UpdateLabelNumOfRoof();
                selectedElement.SelectComp = null; // Reset selection for the next component
                MetalRoofData metalRoofData = new MetalRoofData();
                this.Hide();
                metalRoofData.Show();

            }
            else
            {
                
                NoteAboutOneComp noteAboutOneComp = new NoteAboutOneComp();
                noteAboutOneComp.ShowDialog();
                this.Hide();

            }
        }

        private void UpdateLabelNumOfRoof()
        {
            //selectedElement.CurrentComponent++;
            labelNumOfRoof.Text = $"{selectedElement.CurrentComponent}/{selectedElement.TotalComponents}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBoxRectangle_Click(object sender, EventArgs e)
        {

        }
    }
}
