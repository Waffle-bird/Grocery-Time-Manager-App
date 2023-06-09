using System.Runtime.CompilerServices;

namespace Grocery_Time_Manager_App
{
    partial class frmHome
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            btnCreateAssignLoader = new Button();
            btnManageShift = new Button();
            btnIndividualSummary = new Button();
            btnTeamSummary = new Button();
            btnAddEmployee = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCreateAssignLoader
            // 
            btnCreateAssignLoader.BackColor = Color.White;
            btnCreateAssignLoader.FlatAppearance.BorderColor = Color.FromArgb(226, 25, 44);
            btnCreateAssignLoader.FlatStyle = FlatStyle.Flat;
            btnCreateAssignLoader.ForeColor = Color.FromArgb(226, 25, 44);
            btnCreateAssignLoader.Location = new Point(12, 101);
            btnCreateAssignLoader.Margin = new Padding(0);
            btnCreateAssignLoader.Name = "btnCreateAssignLoader";
            btnCreateAssignLoader.Size = new Size(324, 93);
            btnCreateAssignLoader.TabIndex = 1;
            btnCreateAssignLoader.TabStop = false;
            btnCreateAssignLoader.Text = "Create and Assign Loader";
            btnCreateAssignLoader.UseVisualStyleBackColor = false;
            btnCreateAssignLoader.Click += btnCreateAssignLoader_Click;
            btnCreateAssignLoader.MouseEnter += btnCreateAssignLoader_MouseEnter;
            btnCreateAssignLoader.MouseLeave += btnCreateAssignLoader_MouseLeave;
            // 
            // btnManageShift
            // 
            btnManageShift.FlatAppearance.BorderColor = Color.FromArgb(226, 25, 44);
            btnManageShift.FlatStyle = FlatStyle.Flat;
            btnManageShift.ForeColor = Color.FromArgb(226, 25, 44);
            btnManageShift.Location = new Point(12, 200);
            btnManageShift.Margin = new Padding(0);
            btnManageShift.Name = "btnManageShift";
            btnManageShift.Size = new Size(141, 73);
            btnManageShift.TabIndex = 2;
            btnManageShift.TabStop = false;
            btnManageShift.Text = "Manage Shift";
            btnManageShift.UseVisualStyleBackColor = true;
            btnManageShift.Click += btnManageShift_Click;
            btnManageShift.MouseEnter += btnManageShift_MouseEnter;
            btnManageShift.MouseLeave += btnManageShift_MouseLeave;
            // 
            // btnIndividualSummary
            // 
            btnIndividualSummary.FlatAppearance.BorderColor = Color.FromArgb(226, 25, 44);
            btnIndividualSummary.FlatStyle = FlatStyle.Flat;
            btnIndividualSummary.ForeColor = Color.FromArgb(226, 25, 44);
            btnIndividualSummary.Location = new Point(159, 200);
            btnIndividualSummary.Name = "btnIndividualSummary";
            btnIndividualSummary.Size = new Size(177, 34);
            btnIndividualSummary.TabIndex = 3;
            btnIndividualSummary.TabStop = false;
            btnIndividualSummary.Text = "Individual Summary";
            btnIndividualSummary.UseVisualStyleBackColor = true;
            btnIndividualSummary.Click += btnIndividualSummary_Click;
            btnIndividualSummary.MouseEnter += btnIndividualSummary_MouseEnter;
            btnIndividualSummary.MouseLeave += btnIndividualSummary_MouseLeave;
            // 
            // btnTeamSummary
            // 
            btnTeamSummary.FlatAppearance.BorderColor = Color.FromArgb(226, 25, 44);
            btnTeamSummary.FlatStyle = FlatStyle.Flat;
            btnTeamSummary.ForeColor = Color.FromArgb(226, 25, 44);
            btnTeamSummary.Location = new Point(159, 239);
            btnTeamSummary.Name = "btnTeamSummary";
            btnTeamSummary.Size = new Size(177, 34);
            btnTeamSummary.TabIndex = 4;
            btnTeamSummary.TabStop = false;
            btnTeamSummary.Text = "Team Summary";
            btnTeamSummary.UseVisualStyleBackColor = true;
            btnTeamSummary.Click += btnTeamSummary_Click;
            btnTeamSummary.MouseEnter += btnTeamSummary_MouseEnter;
            btnTeamSummary.MouseLeave += btnTeamSummary_MouseLeave;
            // 
            // btnAddEmployee
            // 
            btnAddEmployee.FlatAppearance.BorderColor = Color.FromArgb(112, 51, 119);
            btnAddEmployee.FlatStyle = FlatStyle.Flat;
            btnAddEmployee.ForeColor = Color.FromArgb(112, 51, 119);
            btnAddEmployee.Location = new Point(91, 279);
            btnAddEmployee.Margin = new Padding(0);
            btnAddEmployee.Name = "btnAddEmployee";
            btnAddEmployee.Size = new Size(120, 25);
            btnAddEmployee.TabIndex = 5;
            btnAddEmployee.TabStop = false;
            btnAddEmployee.Text = "Add Employee";
            btnAddEmployee.UseVisualStyleBackColor = true;
            btnAddEmployee.Click += btnAddEmployee_Click;
            btnAddEmployee.MouseEnter += btnAddEmployee_MouseEnter;
            btnAddEmployee.MouseLeave += btnAddEmployee_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(119, 86);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(345, 313);
            Controls.Add(pictureBox1);
            Controls.Add(btnAddEmployee);
            Controls.Add(btnTeamSummary);
            Controls.Add(btnIndividualSummary);
            Controls.Add(btnManageShift);
            Controls.Add(btnCreateAssignLoader);
            Name = "frmHome";
            Text = "Home";
            Load += frmHome_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button btnCreateAssignLoader;
        private Button btnManageShift;
        private Button btnIndividualSummary;
        private Button btnTeamSummary;
        private Button btnAddEmployee;
        private PictureBox pictureBox1;
    }
}