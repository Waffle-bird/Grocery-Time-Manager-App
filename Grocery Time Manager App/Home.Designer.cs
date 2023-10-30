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
            this.btnCreateAssignLoader = new System.Windows.Forms.Button();
            this.btnManageShift = new System.Windows.Forms.Button();
            this.btnIndividualSummary = new System.Windows.Forms.Button();
            this.btnAddEmployee = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateAssignLoader
            // 
            this.btnCreateAssignLoader.BackColor = System.Drawing.Color.White;
            this.btnCreateAssignLoader.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.btnCreateAssignLoader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateAssignLoader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.btnCreateAssignLoader.Location = new System.Drawing.Point(12, 101);
            this.btnCreateAssignLoader.Margin = new System.Windows.Forms.Padding(0);
            this.btnCreateAssignLoader.Name = "btnCreateAssignLoader";
            this.btnCreateAssignLoader.Size = new System.Drawing.Size(324, 93);
            this.btnCreateAssignLoader.TabIndex = 1;
            this.btnCreateAssignLoader.TabStop = false;
            this.btnCreateAssignLoader.Text = "Create and Assign Loader";
            this.btnCreateAssignLoader.UseVisualStyleBackColor = false;
            // 
            // btnManageShift
            // 
            this.btnManageShift.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.btnManageShift.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnManageShift.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.btnManageShift.Location = new System.Drawing.Point(12, 200);
            this.btnManageShift.Margin = new System.Windows.Forms.Padding(0);
            this.btnManageShift.Name = "btnManageShift";
            this.btnManageShift.Size = new System.Drawing.Size(161, 73);
            this.btnManageShift.TabIndex = 2;
            this.btnManageShift.TabStop = false;
            this.btnManageShift.Text = "Manage Shift";
            this.btnManageShift.UseVisualStyleBackColor = true;
            // 
            // btnIndividualSummary
            // 
            this.btnIndividualSummary.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.btnIndividualSummary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIndividualSummary.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(25)))), ((int)(((byte)(44)))));
            this.btnIndividualSummary.Location = new System.Drawing.Point(179, 200);
            this.btnIndividualSummary.Name = "btnIndividualSummary";
            this.btnIndividualSummary.Size = new System.Drawing.Size(157, 73);
            this.btnIndividualSummary.TabIndex = 3;
            this.btnIndividualSummary.TabStop = false;
            this.btnIndividualSummary.Text = "Employee Summary";
            this.btnIndividualSummary.UseVisualStyleBackColor = true;
            // 
            // btnAddEmployee
            // 
            this.btnAddEmployee.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(51)))), ((int)(((byte)(119)))));
            this.btnAddEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(51)))), ((int)(((byte)(119)))));
            this.btnAddEmployee.Location = new System.Drawing.Point(115, 279);
            this.btnAddEmployee.Margin = new System.Windows.Forms.Padding(0);
            this.btnAddEmployee.Name = "btnAddEmployee";
            this.btnAddEmployee.Size = new System.Drawing.Size(120, 25);
            this.btnAddEmployee.TabIndex = 5;
            this.btnAddEmployee.TabStop = false;
            this.btnAddEmployee.Text = "Add Employee";
            this.btnAddEmployee.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(345, 313);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnAddEmployee);
            this.Controls.Add(this.btnIndividualSummary);
            this.Controls.Add(this.btnManageShift);
            this.Controls.Add(this.btnCreateAssignLoader);
            this.Name = "frmHome";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.frmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Button btnCreateAssignLoader;
        private Button btnManageShift;
        private Button btnIndividualSummary;
        private Button btnAddEmployee;
        private PictureBox pictureBox1;
    }
}