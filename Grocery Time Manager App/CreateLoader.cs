using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grocery_Time_Manager_App
{
    public partial class frmCreateLoader : Form
    {
        private AppManager am;
        List<Loader> unassignedLoaderList;

        //Constructor takes in the unassignedLoaderList from the CreateAssignLoader class
        public frmCreateLoader(List<Loader> unassignedLoaderList, AppManager am)
        {
            InitializeComponent();
            this.unassignedLoaderList = unassignedLoaderList;
            this.Icon = new Icon("Images/logo.ico");
            this.am = am;
            nudAisle.Minimum = 1;

            //Controls the maximum aisle value to the number of aisles specified in the productTypes dictionary
            nudAisle.Maximum = am.GetProductTypes().Count;

        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            frmCreateAssignLoader window = new frmCreateAssignLoader(unassignedLoaderList, am);
            this.Hide();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            //Adds the fields from the CreateLoader class and passes through into the CreateAssignLoader class
            this.unassignedLoaderList.Add(new Loader((int)nudAisle.Value, cbxProductType.Text, dtpTimeIssued.Value, (int)nudNumBoxes.Value));


            this.Hide();
            frmCreateAssignLoader window = new frmCreateAssignLoader(unassignedLoaderList, am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnClearFields_Click(object sender, EventArgs e)
        {
            cbxProductType.Text = "";
            nudNumBoxes.Value = 0;
            dtpTimeIssued.Value = DateTime.Today;
            nudAisle.Value = 1;
        }


        //Changes the product types in the cbxProductTypes combo box to reflect the selected aisle number
        private void nudAisle_ValueChanged(object sender, EventArgs e)
        {
            //Ensures that if the aisle number is changed, the wrong product type is not still in the aisle combo box
            cbxProductType.Text = "";
            nudNumBoxes.Value = 0;
            dtpTimeIssued.Value = DateTime.Today;

            cbxProductType.Items.Clear();
            foreach (var product in am.GetProductTypes()[(int)nudAisle.Value])
            {
                cbxProductType.Items.Add(product);
            }
        }


    }
}
