using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Grocery_Time_Manager_App
{
    public partial class frmCreateAssignLoader : Form
    {
        private DataTable dtUnassignedLoaders;
        private DataView dvUnassignedLoaders;

        private DataTable dtAssignedLoaders;
        private DataView dvAssignedLoaders;

        private AppManager am;
        private List<Loader> unassignedLoaderList;
        private List<Loader> assignedLoaderList;
        private string selectedLoaderTime;

        private string shiftDate;
        private bool shiftTime;


        public frmCreateAssignLoader(AppManager am)
        {
            this.am = am;
            this.shiftDate = DateTime.Now.ToShortDateString();

            this.shiftTime = true;
            if (DateTime.Now.ToString("tt").Equals("pm"))
            {
                shiftTime = false;
            }


            this.unassignedLoaderList = new List<Loader>();
            this.assignedLoaderList = new List<Loader>();
            InitializeComponent();

            //Listview Properties
            lsvUnassignedLoaders.View = View.Details;
            lsvUnassignedLoaders.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //Add Columns
            lsvUnassignedLoaders.Columns.Add("Aisle");
            lsvUnassignedLoaders.Columns.Add("Product Type");
            lsvUnassignedLoaders.Columns.Add("Time Issued");
            lsvUnassignedLoaders.Columns.Add("No.Boxes");


            //Initialise Datatable and add Columns
            dtUnassignedLoaders = new DataTable();
            dtUnassignedLoaders.Columns.Add("Aisle");
            dtUnassignedLoaders.Columns.Add("Product Type");
            dtUnassignedLoaders.Columns.Add("Time Issued");
            dtUnassignedLoaders.Columns.Add("No. Boxes");

            dvUnassignedLoaders = new DataView(dtUnassignedLoaders);


            foreach (string employee in am.AssignableEmployees(DateTime.Now))
            {
                cbxWorker.Items.Add(employee);
            }

            this.Icon = new Icon("Images/logo.ico");

            PopulateListView(dvUnassignedLoaders, lsvUnassignedLoaders);

        }

        //Second constructor which receives the list of unassigned loaders when returning from the Create Loader form
        public frmCreateAssignLoader(List<Loader> unassignedLoaderList, AppManager am)
        {
            this.am = am;

            this.shiftDate = DateTime.Now.ToShortDateString();

            this.shiftTime = true;
            if (DateTime.Now.ToString("tt").Equals("pm"))
            {
                shiftTime = false;
            }



            this.Icon = new Icon("Images/logo.ico");

            this.unassignedLoaderList = unassignedLoaderList;
            this.assignedLoaderList = new List<Loader>();

            InitializeComponent();

            //Listview Properties
            lsvUnassignedLoaders.View = View.Details;
            //Add Columns
            lsvUnassignedLoaders.Columns.Add("Aisle");
            lsvUnassignedLoaders.Columns.Add("Product Type");
            lsvUnassignedLoaders.Columns.Add("Time Issued");
            lsvUnassignedLoaders.Columns.Add("Number of Boxes");


            //Initialise Datatable and add Columns
            dtUnassignedLoaders = new DataTable();
            dtUnassignedLoaders.Columns.Add("Aisle");
            dtUnassignedLoaders.Columns.Add("Product Type");
            dtUnassignedLoaders.Columns.Add("Time Issued");
            dtUnassignedLoaders.Columns.Add("Number of Boxes");


            //Listview Properties
            lsvAssignedLoaders.View = View.Details;
            //Add Columns
            lsvAssignedLoaders.Columns.Add("Aisle");
            lsvAssignedLoaders.Columns.Add("Product Type");
            lsvAssignedLoaders.Columns.Add("Time Issued");
            lsvAssignedLoaders.Columns.Add("Number of Boxes");


            //Initialise Datatable and add Columns
            dtAssignedLoaders = new DataTable();
            dtAssignedLoaders.Columns.Add("Aisle");
            dtAssignedLoaders.Columns.Add("Product Type");
            dtAssignedLoaders.Columns.Add("Time Issued");
            dtAssignedLoaders.Columns.Add("Number of Boxes");


            foreach (string employee in am.AssignableEmployees(DateTime.Now))
            {
                MessageBox.Show(employee);
                cbxWorker.Items.Add(employee);
            }


            RefreshLoaderListViews();

        }

        private void PopulateListView(DataView dv, System.Windows.Forms.ListView lv)
        {
            lv.Items.Clear();

            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lv.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            //populates the list view
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lv.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString(), row[2].ToString(), row[3].ToString() }));
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


        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            assignedLoaderList.Add(unassignedLoaderList[FindSelectedLoaderIndex(unassignedLoaderList)]);
            unassignedLoaderList.RemoveAt(FindSelectedLoaderIndex(unassignedLoaderList));

            bool isAm = true;
            if (DateTime.Now.ToString("tt").Equals("pm"))
            {
                isAm = false;
            }

            string[] employeeIndexes = cbxWorker.Text.Split(' ');
            string Id = employeeIndexes[0];
            MessageBox.Show($"{assignedLoaderList[0].GetProductType()}");
            am.AddLoader(Convert.ToInt32(Id), DateTime.Now, isAm, assignedLoaderList[assignedLoaderList.Count-1]);

            RefreshLoaderListViews();
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {

            bool isAm = true;
            if (assignedLoaderList[FindSelectedLoaderIndex(assignedLoaderList)].GetTimeIssued().ToString("tt").Equals("pm"))
            {
                isAm = false;
            }

            string[] employeeIndexes = cbxWorker.Text.Split(' ');
            string Id = employeeIndexes[0];

            am.RemoveLoader(Convert.ToInt32(Id), DateTime.Now ,assignedLoaderList[FindSelectedLoaderIndex(assignedLoaderList)].GetTimeIssued(), isAm);

            //Check for errors after this point:

            unassignedLoaderList.Add(assignedLoaderList[FindSelectedLoaderIndex(assignedLoaderList)]);
            assignedLoaderList.RemoveAt(FindSelectedLoaderIndex(assignedLoaderList));


            RefreshLoaderListViews();
        }

        private void RefreshLoaderListViews()
        {
            dtUnassignedLoaders.Clear();

            foreach (var loader in unassignedLoaderList)   //Code from Microsoft Teams
            {
                dtUnassignedLoaders.Rows.Add(loader.GetAisle(), loader.GetProductType(), loader.GetTimeIssued(), loader.GetNumBoxes());
            }

            dvUnassignedLoaders = new DataView(dtUnassignedLoaders);


            PopulateListView(dvUnassignedLoaders, lsvUnassignedLoaders);


            dtAssignedLoaders.Clear();

            foreach (var loader in assignedLoaderList)   //Code from Microsoft Teams
            {
                dtAssignedLoaders.Rows.Add(loader.GetAisle(), loader.GetProductType(), loader.GetTimeIssued(), loader.GetNumBoxes());
            }

            dvAssignedLoaders = new DataView(dtAssignedLoaders);


            PopulateListView(dvAssignedLoaders, lsvAssignedLoaders);
        }

        private int FindSelectedLoaderIndex(List<Loader> loaders)
        {
            int loaderIndex = 0;
            foreach (Loader loader in loaders)
            {
                if (selectedLoaderTime.Equals(loader.GetTimeIssued().ToString()))
                {
                    return loaderIndex;
                }

                loaderIndex++;
            }            
            return -1;
        }

        private void lsvUnassignedLoaders_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedLoaderTime = lsvUnassignedLoaders.FocusedItem.SubItems[2].Text;
        }

        private void cbxWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            string[] selectedEmployee = cbxWorker.Text.Split(' ');
            assignedLoaderList = am.GetAssignedLoaders(this.shiftDate, this.shiftTime, Convert.ToInt32(selectedEmployee[0]));

            RefreshLoaderListViews();
        }
    }
}
