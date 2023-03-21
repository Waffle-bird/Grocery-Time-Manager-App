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
    }
}