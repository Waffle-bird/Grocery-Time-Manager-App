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
        public frmCreateAssignLoader()
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

        private void btnCreateLoader_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateLoader window = new frmCreateLoader();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
