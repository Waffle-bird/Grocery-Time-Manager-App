namespace Grocery_Time_Manager_App
{
    partial class frmCreateAssignLoader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBack = new System.Windows.Forms.Button();
            this.btnCreateLoader = new System.Windows.Forms.Button();
            this.lsvUnassignedLoaders = new System.Windows.Forms.ListView();
            this.lsvAssignedLoaders = new System.Windows.Forms.ListView();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.cbxWorker = new System.Windows.Forms.ComboBox();
            this.lblWorker = new System.Windows.Forms.Label();
            this.lblAssignLoaders = new System.Windows.Forms.Label();
            this.lblAssignedLoaders = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 23);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += btnBack_Click;

            // 
            // btnCreateLoader
            // 
            this.btnCreateLoader.Location = new System.Drawing.Point(12, 41);
            this.btnCreateLoader.Name = "btnCreateLoader";
            this.btnCreateLoader.Size = new System.Drawing.Size(182, 49);
            this.btnCreateLoader.TabIndex = 1;
            this.btnCreateLoader.Text = "Create Loader";
            this.btnCreateLoader.UseVisualStyleBackColor = true;
            this.btnCreateLoader.Click += btnCreateLoader_Click;
            // 
            // lsvUnassignedLoaders
            // 
            this.lsvUnassignedLoaders.FullRowSelect = true;
            this.lsvUnassignedLoaders.Location = new System.Drawing.Point(12, 127);
            this.lsvUnassignedLoaders.Name = "lsvUnassignedLoaders";
            this.lsvUnassignedLoaders.Size = new System.Drawing.Size(360, 311);
            this.lsvUnassignedLoaders.TabIndex = 2;
            this.lsvUnassignedLoaders.UseCompatibleStateImageBehavior = false;
            this.lsvUnassignedLoaders.Click += lsvUnassignedLoaders_SelectedIndexChanged;
            // 
            // lsvAssignedLoaders
            // 
            this.lsvAssignedLoaders.FullRowSelect = true;
            this.lsvAssignedLoaders.Location = new System.Drawing.Point(483, 127);
            this.lsvAssignedLoaders.Name = "lsvAssignedLoaders";
            this.lsvAssignedLoaders.Size = new System.Drawing.Size(327, 311);
            this.lsvAssignedLoaders.TabIndex = 3;
            this.lsvAssignedLoaders.UseCompatibleStateImageBehavior = false;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(388, 227);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 4;
            this.btnMoveRight.Text = "===>";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            this.btnMoveRight.Click += btnMoveRight_Click;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(388, 256);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 5;
            this.btnMoveLeft.Text = "<===";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            this.btnMoveLeft.Click += btnMoveLeft_Click;
            // 
            // cbxWorker
            // 
            this.cbxWorker.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxWorker.FormattingEnabled = true;
            this.cbxWorker.Location = new System.Drawing.Point(537, 72);
            this.cbxWorker.Name = "cbxWorker";
            this.cbxWorker.Size = new System.Drawing.Size(121, 23);
            this.cbxWorker.TabIndex = 6;
            this.cbxWorker.SelectedIndexChanged += new System.EventHandler(this.cbxWorker_SelectedIndexChanged);
            // 
            // lblWorker
            // 
            this.lblWorker.AutoSize = true;
            this.lblWorker.Location = new System.Drawing.Point(483, 75);
            this.lblWorker.Name = "lblWorker";
            this.lblWorker.Size = new System.Drawing.Size(48, 15);
            this.lblWorker.TabIndex = 7;
            this.lblWorker.Text = "Worker:";
            // 
            // lblAssignLoaders
            // 
            this.lblAssignLoaders.AutoSize = true;
            this.lblAssignLoaders.Location = new System.Drawing.Point(12, 109);
            this.lblAssignLoaders.Name = "lblAssignLoaders";
            this.lblAssignLoaders.Size = new System.Drawing.Size(132, 15);
            this.lblAssignLoaders.TabIndex = 8;
            this.lblAssignLoaders.Text = "Loaders to be Assigned:";
            // 
            // lblAssignedLoaders
            // 
            this.lblAssignedLoaders.AutoSize = true;
            this.lblAssignedLoaders.Location = new System.Drawing.Point(483, 109);
            this.lblAssignedLoaders.Name = "lblAssignedLoaders";
            this.lblAssignedLoaders.Size = new System.Drawing.Size(102, 15);
            this.lblAssignedLoaders.TabIndex = 9;
            this.lblAssignedLoaders.Text = "Assigned Loaders:";
            // 
            // frmCreateAssignLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 450);
            this.Controls.Add(this.lblAssignedLoaders);
            this.Controls.Add(this.lblAssignLoaders);
            this.Controls.Add(this.lblWorker);
            this.Controls.Add(this.cbxWorker);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.lsvAssignedLoaders);
            this.Controls.Add(this.lsvUnassignedLoaders);
            this.Controls.Add(this.btnCreateLoader);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCreateAssignLoader";
            this.Text = "Create and Assign Loader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Button btnCreateLoader;
        private ListView lsvUnassignedLoaders;
        private ListView lsvAssignedLoaders;
        private Button btnMoveRight;
        private Button btnMoveLeft;
        private ComboBox cbxWorker;
        private Label lblWorker;
        private Label lblAssignLoaders;
        private Label lblAssignedLoaders;
    }
}