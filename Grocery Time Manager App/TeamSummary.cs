﻿using System;
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
        AppManager am;
        public frmTeamSummary(AppManager am)
        {
            InitializeComponent();
            this.Icon = new Icon("Images/logo.ico");
            this.am = am;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHome window = new frmHome(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnIndividualSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmIndividualSummary window = new frmIndividualSummary(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }
    }
}
