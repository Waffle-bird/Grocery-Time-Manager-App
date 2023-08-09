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
    public partial class frmAddEmployee : Form
    {
        private AppManager am;
        private int ID = 0;

        public frmAddEmployee(AppManager am)
        {
            this.am = am;

            InitializeComponent();
            this.Icon = new Icon("Images/logo.ico");
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            //If there are no employees previously created, generate an employee with an ID of 0
            if (am.NumEmployees() == 0)
            {
                am.GenerateEmployee(0, tbxName.Text);
            }

            //If there are already employees generated, generate a new employee with and ID +1 of the last added employee
            else
            {
                am.GenerateEmployee(am.GetPreviousEmployeeId() + 1, tbxName.Text);
            }


            tbxName.Text = "";

            MessageBox.Show($"Employee {am.GetPreviousEmployeeName()} submitted successfully\n" +
                $"(ID:{am.GetPreviousEmployeeId()})\t (number of employees:{am.NumEmployees()}) ");

        }
    }
}
