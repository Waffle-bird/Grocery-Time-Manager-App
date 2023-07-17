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
    public partial class frmCreateAssignLoader : Form
    {
        private DataTable dt;
        private DataView dv;
        private AppManager am;


        List<Loader> unassignedLoaderList;
        public frmCreateAssignLoader(AppManager am)
        {
            this.am = am;

            this.unassignedLoaderList = new List<Loader>();
            InitializeComponent();

            //Listview Properties
            lsvUnassignedLoaders.View = View.Details;
            lsvUnassignedLoaders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //Add Columns
            lsvUnassignedLoaders.Columns.Add("Aisle");
            lsvUnassignedLoaders.Columns.Add("Product Type");
            lsvUnassignedLoaders.Columns.Add("Time Issued");
            lsvUnassignedLoaders.Columns.Add("Number of Boxes");


            //Initialise Datatable and add Columns
            dt = new DataTable();
            dt.Columns.Add("Aisle");
            dt.Columns.Add("Product Type");
            dt.Columns.Add("Time Issued");
            dt.Columns.Add("Number of Boxes");

            dv = new DataView(dt);


            this.Icon = new Icon("Images/logo.ico");
        }

        //Second constructor which receives the list of unassigned loaders when returning from the Create Loader form
        public frmCreateAssignLoader(List<Loader> unassignedLoaderList, AppManager am)
        {
            this.am = am;
            this.Icon = new Icon("Images/logo.ico");

            this.unassignedLoaderList = unassignedLoaderList;
            InitializeComponent();

            //Listview Properties
            lsvUnassignedLoaders.View = View.Details;
            lsvUnassignedLoaders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //Add Columns
            lsvUnassignedLoaders.Columns.Add("Aisle");
            lsvUnassignedLoaders.Columns.Add("Product Type");
            lsvUnassignedLoaders.Columns.Add("Time Issued");
            lsvUnassignedLoaders.Columns.Add("Number of Boxes");


            //Initialise Datatable and add Columns
            dt = new DataTable();
            dt.Columns.Add("Aisle");
            dt.Columns.Add("Product Type");
            dt.Columns.Add("Time Issued");
            dt.Columns.Add("Number of Boxes");

            foreach (var loader in unassignedLoaderList)   //Code from Microsoft Teams
            {

                dt.Rows.Add(loader.getAisle(), loader.getProductType(), loader.getTimeIssued(), loader.getNumBoxes());

            }

            dv = new DataView(dt);



            PopulateListView(dv);

        }

        private void PopulateListView(DataView dv)
        {
            lsvUnassignedLoaders.Items.Clear();

            //populates the list view
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lsvUnassignedLoaders.Items.Add(new ListViewItem(new String[] {row[0].ToString(), row[1].ToString(), row[2].ToString(),
                    row[3].ToString()}));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnCreateLoader_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateLoader window = new frmCreateLoader(unassignedLoaderList, am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
