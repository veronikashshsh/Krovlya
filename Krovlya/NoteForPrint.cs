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
    public partial class NoteForPrint : Form
    {
        public NoteForPrint()
        {
            InitializeComponent();
            this.Load += new EventHandler(NoteForPrint_Load);
        }

        public void UpdateLabels()
        {
            labelMaxZavodLength.Text = GlobalData.MaxLengthZavodMetal;
            labelDiscretLengthMetal.Text = GlobalData.DiskretOfMetal;
            labelData.Text = GlobalData.LabelData;
            CustomerLabel.Text = GlobalData.LabelCustomer;
            SupplierLabel.Text = GlobalData.LabelManager;
            AmountOfMetal.Text = DataCalculations.ResultMetalList.ToString("F0"); 
            MaterialsLabel.Text = GlobalData.NameOfMetalTile;
            labelAmountOfComp.Text = DataCalculations.AmountOfCompon.ToString(); 
            labelArea.Text = DataCalculations.AreaOfRoof.ToString("F4"); 
            labelOrder.Text = GlobalData.LabelOrder;
        }

        private void NoteForPrint_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            MetalTile metalTile = new MetalTile();

            metalTile.Show();  
            this.Hide();  
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MainPage form1 = new MainPage();
            form1.Show();
            this.Close();
        }

        private void SupplierLabel_Click(object sender, EventArgs e)
        {

        }

        private void labelAmountOfComp_Click(object sender, EventArgs e)
        {

        }

        private void labelArea_Click(object sender, EventArgs e)
        {

        }

        private void labelMaxZavodLength_Click(object sender, EventArgs e)
        {

        }

        private void labelOrder_Click(object sender, EventArgs e)
        {

        }
    }
}
