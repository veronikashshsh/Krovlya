using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Krovlya.MainPage;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Krovlya
{
    public partial class MetalTile : Form
    {
        public MetalTile()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            this.Load += new EventHandler(MetalTile_Load);
        }

        public void UpdateLabels()
        {
            labelData.Text = GlobalData.LabelData;
            labelCustomer.Text = GlobalData.LabelCustomer;
            labelManager.Text = GlobalData.LabelManager;
            labelOrder.Text = GlobalData.LabelOrder;
        }

        private void MetalTile_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainPage form1 = new MainPage();
            form1.Show();
            this.Close();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            NoteForPrint formPrint = new NoteForPrint();

            GlobalData.NameOfMetalTile = textBoxGood.Text;
            GlobalData.MaxLengthZavodMetal = textBoxMaxLength.Text;
            GlobalData.DiskretOfMetal = textBoxDiscret.Text;
            DataCalculations.UsefulWidthValue = double.TryParse(textBoxUseWidthList.Text, out double data) ? data : 0; // Парсинг тексту в число
            DataCalculations.FullWidthValue = double.TryParse(textBoxFullWidth.Text, out double customer) ? customer : 0;
            DataCalculations.MaxLengthValue = double.TryParse(textBoxMaxLength.Text, out double manager) ? manager : 0;
            DataCalculations.WidthRoofValue = double.TryParse(textBoxWidthRoof.Text, out double managers) ? managers : 0;
            DataCalculations.ListLength = double.TryParse(textBoxLengthList.Text, out double length) ? length : 0;

            DataCalculations.ResultMetalList = DataCalculations.WidthRoofValue / DataCalculations.UsefulWidthValue;                     
            DataCalculations.AreaOfRoof = DataCalculations.ResultMetalList * DataCalculations.ListLength * DataCalculations.FullWidthValue;

            formPrint.Show();
            this.Hide();
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MetalTile_Load_1(object sender, EventArgs e)
        {

        }
    }
}
