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
    public partial class InfoAllMetal : Form
    {
        private DataCalculationsForTriangle triangleData;
        public InfoAllMetal(DataCalculationsForTriangle triangleData)
        {
            InitializeComponent();
            this.Load += new EventHandler(InfoAllMetal_Load);
            this.triangleData = triangleData;
        }

        public void UpdateLabels()
        {
            labelData.Text = GlobalData.LabelData;
            labelCustomer.Text = GlobalData.LabelCustomer;
            SupplierLabel.Text = GlobalData.LabelManager;
            //AmountOfMetal.Text = DataCalculations.ResultMetalList.ToString("F0");
            MaterialsLabel.Text = GlobalData.NameOfMetalTile;
            //labelAmountOfComp.Text = DataCalculations.AmountOfCompon.ToString();
            //labelArea.Text = DataCalculations.AreaOfRoof.ToString("F4");
            labelOrder.Text = GlobalData.LabelOrder;
            labelFullWidthList.Text = DataCalculations.FullWidthValue.ToString();
            labelUseWidthList.Text = DataCalculations.UsefulWidthValue.ToString();

            //labelArea1.Text = triangleData.AreaValue.ToString("F3");
            if (this.triangleData is DataCalculationsForTriangle)
            {
                labelArea1.Text = this.triangleData.AreaCalc().ToString("F3");
            }
        }

        private void InfoAllMetal_Load(object sender, EventArgs e)
        {
            UpdateLabels();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void labelData_Click(object sender, EventArgs e)
        {

        }
    }
}
