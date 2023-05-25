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

        public frmAddEmployee()
        {
            this.am = new AppManager();


            InitializeComponent();
        }




        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            am.GenerateEmployee((int)nudId.Value, tbxName.Text);

            nudId.Value = 0;
            tbxName.Text = "";

            MessageBox.Show($"Employee {am.GetPreviousEmployeeName()} (ID:{am.GetPreviousEmployeeId()}) submitted successfully");

        }
    }
}
