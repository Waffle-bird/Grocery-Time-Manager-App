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

        private void nudAisle_ValueChanged(object sender, EventArgs e)
        {
            cbxProductType.Items.Clear();
            foreach (var product in am.GetProductTypes()[(int)nudAisle.Value])
            {
                cbxProductType.Items.Add(product);
            }
        }
    }
}
