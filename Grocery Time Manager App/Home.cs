namespace Grocery_Time_Manager_App
{
    public partial class frmHome : Form
    {
        AppManager am;

        public frmHome(AppManager am)
        {
            InitializeComponent();
            this.Icon = new Icon("Images/logo.ico");
            this.am = am;
        }



        private void btnCreateAssignLoader_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateAssignLoader window = new frmCreateAssignLoader(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();

        }

        private void btnManageShift_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageShift window = new frmManageShift(am);
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

        private void btnTeamSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeamSummary window = new frmTeamSummary(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddEmployee window = new frmAddEmployee(am);
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }



        //Home form button styling and hover effects
        private void btnAddEmployee_MouseLeave(object sender, EventArgs e)
        {
            btnAddEmployee.BackColor = Color.FromArgb(255, 255, 255);
            btnAddEmployee.ForeColor = Color.FromArgb(112, 51, 119);
        }

        private void btnAddEmployee_MouseEnter(object sender, EventArgs e)
        {
            btnAddEmployee.BackColor = Color.FromArgb(112, 51, 119);
            btnAddEmployee.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnManageShift_MouseEnter(object sender, EventArgs e)
        {
            btnManageShift.BackColor = Color.FromArgb(226, 25, 44);
            btnManageShift.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnManageShift_MouseLeave(object sender, EventArgs e)
        {
            btnManageShift.BackColor = Color.FromArgb(255, 255, 255);
            btnManageShift.ForeColor = Color.FromArgb(226, 25, 44);
        }

        private void btnCreateAssignLoader_MouseEnter(object sender, EventArgs e)
        {
            btnCreateAssignLoader.BackColor = Color.FromArgb(226, 25, 44);
            btnCreateAssignLoader.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnCreateAssignLoader_MouseLeave(object sender, EventArgs e)
        {
            btnCreateAssignLoader.BackColor = Color.FromArgb(255, 255, 255);
            btnCreateAssignLoader.ForeColor = Color.FromArgb(226, 25, 44);

        }

        private void btnIndividualSummary_MouseEnter(object sender, EventArgs e)
        {
            btnIndividualSummary.BackColor = Color.FromArgb(226, 25, 44);
            btnIndividualSummary.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnIndividualSummary_MouseLeave(object sender, EventArgs e)
        {
            btnIndividualSummary.BackColor = Color.FromArgb(255, 255, 255);
            btnIndividualSummary.ForeColor = Color.FromArgb(226, 25, 44);
        }

        private void btnTeamSummary_MouseEnter(object sender, EventArgs e)
        {
            btnTeamSummary.BackColor = Color.FromArgb(226, 25, 44);
            btnTeamSummary.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnTeamSummary_MouseLeave(object sender, EventArgs e)
        {
            btnTeamSummary.BackColor = Color.FromArgb(255, 255, 255);
            btnTeamSummary.ForeColor = Color.FromArgb(226, 25, 44);
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
        }






        ////private void btnAddEmployee_MouseLeave(object sender, System.EventArgs e)
        //{
        //    // Update the mouse event label to indicate the MouseLeave event occurred.
        //    btnAddEmployee.Text = ": MouseLeave";
        //}

    }
}