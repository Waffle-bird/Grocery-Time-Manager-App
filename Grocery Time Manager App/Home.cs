namespace Grocery_Time_Manager_App
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void btnCreateAssignLoader_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmCreateAssignLoader window = new frmCreateAssignLoader();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnManageShift_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmManageShift window = new frmManageShift();
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

        private void btnTeamSummary_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmTeamSummary window = new frmTeamSummary();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmAddEmployee window = new frmAddEmployee();
            window.FormClosed += (s, args) => this.Close();
            window.Show();
        }



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

        }

        private void btnIndividualSummary_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnTeamSummary_MouseEnter(object sender, EventArgs e)
        {

        }

        private void btnTeamSummary_MouseLeave(object sender, EventArgs e)
        {

        }






        ////private void btnAddEmployee_MouseLeave(object sender, System.EventArgs e)
        //{
        //    // Update the mouse event label to indicate the MouseLeave event occurred.
        //    btnAddEmployee.Text = ": MouseLeave";
        //}

    }
}