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
    public partial class frmTeamSummary : Form
    {
        public frmTeamSummary()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnIndividualSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIndividualSummary window = new frmIndividualSummary();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
