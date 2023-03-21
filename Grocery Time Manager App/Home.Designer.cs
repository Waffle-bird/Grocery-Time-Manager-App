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
            this.lblGroceryManagementHome = new System.Windows.Forms.Label();
            this.btnCreateAssignLoader = new System.Windows.Forms.Button();
            this.btnManageShift = new System.Windows.Forms.Button();
            this.btnIndividualSummary = new System.Windows.Forms.Button();
            this.btnTeamSummary = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGroceryManagementHome
            // 
            this.lblGroceryManagementHome.AutoSize = true;
            this.lblGroceryManagementHome.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGroceryManagementHome.Location = new System.Drawing.Point(12, 9);
            this.lblGroceryManagementHome.Name = "lblGroceryManagementHome";
            this.lblGroceryManagementHome.Size = new System.Drawing.Size(318, 32);
            this.lblGroceryManagementHome.TabIndex = 0;
            this.lblGroceryManagementHome.Text = "Grocery Management Home";
            // 
            // btnCreateAssignLoader
            // 
            this.btnCreateAssignLoader.Location = new System.Drawing.Point(12, 101);
            this.btnCreateAssignLoader.Name = "btnCreateAssignLoader";
            this.btnCreateAssignLoader.Size = new System.Drawing.Size(324, 93);
            this.btnCreateAssignLoader.TabIndex = 1;
            this.btnCreateAssignLoader.Text = "Create and Assign Loader";
            this.btnCreateAssignLoader.UseVisualStyleBackColor = true;
            this.btnCreateAssignLoader.Click += new System.EventHandler(this.btnCreateAssignLoader_Click);
            // 
            // btnManageShift
            // 
            this.btnManageShift.Location = new System.Drawing.Point(12, 200);
            this.btnManageShift.Name = "btnManageShift";
            this.btnManageShift.Size = new System.Drawing.Size(141, 73);
            this.btnManageShift.TabIndex = 2;
            this.btnManageShift.Text = "Manage Shift";
            this.btnManageShift.UseVisualStyleBackColor = true;
            this.btnManageShift.Click += new System.EventHandler(this.btnManageShift_Click);
            // 
            // btnIndividualSummary
            // 
            this.btnIndividualSummary.Location = new System.Drawing.Point(159, 200);
            this.btnIndividualSummary.Name = "btnIndividualSummary";
            this.btnIndividualSummary.Size = new System.Drawing.Size(177, 34);
            this.btnIndividualSummary.TabIndex = 3;
            this.btnIndividualSummary.Text = "Individual Summary";
            this.btnIndividualSummary.UseVisualStyleBackColor = true;
            this.btnIndividualSummary.Click += new System.EventHandler(this.btnIndividualSummary_Click);
            // 
            // btnTeamSummary
            // 
            this.btnTeamSummary.Location = new System.Drawing.Point(159, 239);
            this.btnTeamSummary.Name = "btnTeamSummary";
            this.btnTeamSummary.Size = new System.Drawing.Size(177, 34);
            this.btnTeamSummary.TabIndex = 4;
            this.btnTeamSummary.Text = "Team Summary";
            this.btnTeamSummary.UseVisualStyleBackColor = true;
            this.btnTeamSummary.Click += new System.EventHandler(this.btnTeamSummary_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 283);
            this.Controls.Add(this.btnTeamSummary);
            this.Controls.Add(this.btnIndividualSummary);
            this.Controls.Add(this.btnManageShift);
            this.Controls.Add(this.btnCreateAssignLoader);
            this.Controls.Add(this.lblGroceryManagementHome);
            this.Name = "frmHome";
            this.Text = "Home";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblGroceryManagementHome;
        private Button btnCreateAssignLoader;
        private Button btnManageShift;
        private Button btnIndividualSummary;
        private Button btnTeamSummary;
    }
}