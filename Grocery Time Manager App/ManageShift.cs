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
    public partial class frmManageShift : Form
    {
        private AppManager am;
        private DataTable dtEmployees;
        private DataView dvEmployees;

        private DataTable dtWorkers;
        private DataView dvWorkers;
        private int selectedEmployeeIndex = -1;

        private List<Employee> employeeList;
        private List<Employee> workingEmployeeList;


        //constructor which receives the list of unassigned loaders when returning from the Create Loader form
        public frmManageShift(AppManager am)
        {
            this.am = am;
            this.Icon = new Icon("Images/logo.ico");

            InitializeComponent();

            //Listview Properties
            lsvEmployees.View = View.Details;
            lsvEmployees.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //Add Columns
            lsvEmployees.Columns.Add("ID");
            lsvEmployees.Columns.Add("Name");


            //Initialise Datatable and add Columns
            dtEmployees = new DataTable();
            dtEmployees.Columns.Add("ID");
            dtEmployees.Columns.Add("Name");


            //Listview Properties
            lsvWorkers.View = View.Details;
            lsvWorkers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            //Add Columns
            lsvWorkers.Columns.Add("ID");
            lsvWorkers.Columns.Add("Name");


            //Initialise Datatable and add Columns
            dtWorkers = new DataTable();
            dtWorkers.Columns.Add("ID");
            dtWorkers.Columns.Add("Name");

            RefreshListViews();

        }

        //Get Methods
        public List<Employee> GetWorkingEmployeeList()
        {
            return employeeList;
        }


        private void PopulateListView(DataView dv, ListView lvType)
        {
            lvType.Items.Clear();
            //populates the list view
            foreach (DataRow row in dv.ToTable().Rows)
            {
                lvType.Items.Add(new ListViewItem(new String[] { row[0].ToString(), row[1].ToString() }));
            }
        }



        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void lsvEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Gets the selected employee's ID from the listview by reading the first column (ID)
            selectedEmployeeIndex = Convert.ToInt32(lsvEmployees.FocusedItem.SubItems[0].Text);
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            //Changes the value of the time of day depending on the status of the time radio button
            string time = "am";
            if (rbtAM.Checked == false)
            {
                time = "pm";
            }

            //Creates a new Shift object with the parameters selected from the form
            Shift newShift = new Shift(rbtAM.Checked, dtpShiftDay.Value);

            //Adds the new Shift object into the list of shifts in the selected employee's object class
            am.AddShift(selectedEmployeeIndex, newShift);

            tbxSearch.Text = "";

            RefreshListViews();

        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            //Removes an employee from the "working" list, and adds them to the "not working" list
            am.RemoveEmployeeShift(selectedEmployeeIndex, dtpShiftDay.Value.ToShortDateString(), rbtAM.Checked);

            //Visually updates the status of the "working" and "not working" list in the form
            RefreshListViews();
        }

        private void tbxSearch_TextChanged(object sender, EventArgs e)
        {
            //Perform the filter of employees
            dvEmployees.RowFilter = string.Format("Name Like '%{0}%'", tbxSearch.Text);
            // Code adapted from https://www.youtube.com/watch?v=cycavkXug5U

            PopulateListView(dvEmployees, lsvEmployees);

        }

        //Clears both listviews of all employees and workers, then repopulates
        private void RefreshListViews()
        {
            workingEmployeeList = am.CurrentlyWorkingEmployees(dtpShiftDay.Value.ToShortDateString(), rbtAM.Checked);
            employeeList = am.NotWorkingEmployees(dtpShiftDay.Value.ToShortDateString(), rbtAM.Checked);

            //Clears all employees out of the listview
            dtEmployees.Rows.Clear();

            //Repopulates the employee listview with the employeeList
            foreach (var employee in employeeList)
            {

                dtEmployees.Rows.Add(employee.GetId(), employee.GetName());

            }

            dvEmployees = new DataView(dtEmployees);

            PopulateListView(dvEmployees, lsvEmployees);



            dtWorkers.Rows.Clear();
            foreach (var employee in workingEmployeeList)
            {
                dtWorkers.Rows.Add(employee.GetId(), employee.GetName());
            }

            dvWorkers = new DataView(dtWorkers);
            PopulateListView(dvWorkers, lsvWorkers);
        }



        private void lsvWorkers_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedEmployeeIndex = Convert.ToInt32(lsvWorkers.FocusedItem.SubItems[0].Text);

        }

        private void dtpShiftDay_ValueChanged(object sender, EventArgs e)
        {
            RefreshListViews();
        }

        private void rbtAM_CheckedChanged(object sender, EventArgs e)
        {
            RefreshListViews();
        }


    }
}
