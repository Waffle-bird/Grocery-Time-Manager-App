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

        private void EventHandleCollection()
        {
            this.btnCreateAssignLoader.Click += new EventHandler(btnCreateAssignLoader_Click);
            this.btnCreateAssignLoader.MouseEnter += new EventHandler(btnCreateAssignLoader_MouseEnter);
            this.btnCreateAssignLoader.MouseLeave += new EventHandler(btnCreateAssignLoader_MouseLeave);

            this.btnManageShift.Click += new EventHandler(btnManageShift_Click);
            this.btnManageShift.MouseEnter += new EventHandler(btnManageShift_MouseEnter);
            this.btnManageShift.MouseLeave += new EventHandler(btnManageShift_MouseLeave);

            this.btnIndividualSummary.Click += new EventHandler(btnIndividualSummary_Click);
            this.btnIndividualSummary.MouseEnter += new EventHandler(btnIndividualSummary_MouseEnter);
            this.btnIndividualSummary.MouseLeave += new EventHandler(btnIndividualSummary_MouseLeave);

            this.btnAddEmployee.Click += new EventHandler(btnAddEmployee_Click);
            this.btnAddEmployee.MouseEnter += new EventHandler(btnAddEmployee_MouseEnter);
            this.btnAddEmployee.MouseLeave += new EventHandler(btnAddEmployee_MouseLeave);

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

        private void frmHome_Load(object sender, EventArgs e)
        {
            EventHandleCollection();
        }









        ////private void btnAddEmployee_MouseLeave(object sender, System.EventArgs e)
        //{
        //    // Update the mouse event label to indicate the MouseLeave event occurred.
        //    btnAddEmployee.Text = ": MouseLeave";
        //}

    }
}