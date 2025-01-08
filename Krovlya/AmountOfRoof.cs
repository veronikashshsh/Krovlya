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
            
        }

        private void buttonNextAm_Click(object sender, EventArgs e)
        {
            DataCalculations.AmountOfCompon = int.Parse(textBoxAmount.Text);

            ChooseTypeOfRoof formChooseType = new ChooseTypeOfRoof();
            formChooseType.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
