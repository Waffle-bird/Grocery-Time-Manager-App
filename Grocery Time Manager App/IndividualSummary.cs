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
    public partial class frmIndividualSummary : Form
    {
        AppManager am;

        DataTable dtWorker;
        ListView lvWorker;
        DataView dvWorker;

        public frmIndividualSummary(AppManager am)
        {
            InitializeComponent();
            this.Icon = new Icon("Images/logo.ico");
            this.am = am;

            //Listview Properties
            lsvWorker.View = View.Details;
            //Add Columns
            lsvWorker.Columns.Add("ID");
            lsvWorker.Columns.Add("Name");


            //Initialise Datatable and add Columns
            dtWorker = new DataTable();
            dtWorker.Columns.Add("ID");
            dtWorker.Columns.Add("Name");

            RefreshLoaderListViews();

        }

        private void RefreshLoaderListViews()
        {
            dtWorker.Clear();

            foreach (var employee in am.GetEmployees(dtpSummaryDate.Value))   //Code from Microsoft Teams
            {
                dtWorker.Rows.Add(employee.GetId(), employee.GetName());
            }

             dvWorker = new DataView(dtWorker);


            PopulateListView(dvWorker, lsvWorker);
        }

            private void PopulateListView(DataView dv, ListView lv)
        {
            lv.Items.Clear();
            //populates the list view
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lv.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString() }));
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnTeamSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeamSummary window = new frmTeamSummary(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void lsvWorker_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedEmployeeIndex = Convert.ToInt32(lsvWorker.FocusedItem.SubItems[0].Text);

            //rtbSummary.Text = "";
            rtbSummary.Text = am.EmployeeSummary(selectedEmployeeIndex, dtpSummaryDate.Value.ToShortDateString());
        }
    }
}
