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
            btnBack = new Button();
            btnCreateLoader = new Button();
            lsvUnassignedLoaders = new ListView();
            lsvAssignedLoaders = new ListView();
            btnMoveRight = new Button();
            btnMoveLeft = new Button();
            cbxWorker = new ComboBox();
            lblWorker = new Label();
            lblAssignLoaders = new Label();
            lblAssignedLoaders = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 23);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // btnCreateLoader
            // 
            btnCreateLoader.Location = new Point(12, 41);
            btnCreateLoader.Name = "btnCreateLoader";
            btnCreateLoader.Size = new Size(182, 49);
            btnCreateLoader.TabIndex = 1;
            btnCreateLoader.Text = "Create Loader";
            btnCreateLoader.UseVisualStyleBackColor = true;
            btnCreateLoader.Click += btnCreateLoader_Click;
            // 
            // lsvUnassignedLoaders
            // 
            lsvUnassignedLoaders.FullRowSelect = true;
            lsvUnassignedLoaders.Location = new Point(12, 127);
            lsvUnassignedLoaders.Name = "lsvUnassignedLoaders";
            lsvUnassignedLoaders.Size = new Size(360, 311);
            lsvUnassignedLoaders.TabIndex = 2;
            lsvUnassignedLoaders.UseCompatibleStateImageBehavior = false;
            lsvUnassignedLoaders.SelectedIndexChanged += lsvUnassignedLoaders_SelectedIndexChanged;
            // 
            // lsvAssignedLoaders
            // 
            lsvAssignedLoaders.FullRowSelect = true;
            lsvAssignedLoaders.Location = new Point(483, 127);
            lsvAssignedLoaders.Name = "lsvAssignedLoaders";
            lsvAssignedLoaders.Size = new Size(327, 311);
            lsvAssignedLoaders.TabIndex = 3;
            lsvAssignedLoaders.UseCompatibleStateImageBehavior = false;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Location = new Point(388, 227);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(75, 23);
            btnMoveRight.TabIndex = 4;
            btnMoveRight.Text = "===>";
            btnMoveRight.UseVisualStyleBackColor = true;
            btnMoveRight.Click += btnMoveRight_Click;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Location = new Point(388, 256);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(75, 23);
            btnMoveLeft.TabIndex = 5;
            btnMoveLeft.Text = "<===";
            btnMoveLeft.UseVisualStyleBackColor = true;
            btnMoveLeft.Click += btnMoveLeft_Click;
            // 
            // cbxWorker
            // 
            cbxWorker.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxWorker.FormattingEnabled = true;
            cbxWorker.Location = new Point(537, 72);
            cbxWorker.Name = "cbxWorker";
            cbxWorker.Size = new Size(121, 23);
            cbxWorker.TabIndex = 6;
            // 
            // lblWorker
            // 
            lblWorker.AutoSize = true;
            lblWorker.Location = new Point(483, 75);
            lblWorker.Name = "lblWorker";
            lblWorker.Size = new Size(48, 15);
            lblWorker.TabIndex = 7;
            lblWorker.Text = "Worker:";
            // 
            // lblAssignLoaders
            // 
            lblAssignLoaders.AutoSize = true;
            lblAssignLoaders.Location = new Point(12, 109);
            lblAssignLoaders.Name = "lblAssignLoaders";
            lblAssignLoaders.Size = new Size(132, 15);
            lblAssignLoaders.TabIndex = 8;
            lblAssignLoaders.Text = "Loaders to be Assigned:";
            // 
            // lblAssignedLoaders
            // 
            lblAssignedLoaders.AutoSize = true;
            lblAssignedLoaders.Location = new Point(483, 109);
            lblAssignedLoaders.Name = "lblAssignedLoaders";
            lblAssignedLoaders.Size = new Size(102, 15);
            lblAssignedLoaders.TabIndex = 9;
            lblAssignedLoaders.Text = "Assigned Loaders:";
            // 
            // frmCreateAssignLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 450);
            Controls.Add(lblAssignedLoaders);
            Controls.Add(lblAssignLoaders);
            Controls.Add(lblWorker);
            Controls.Add(cbxWorker);
            Controls.Add(btnMoveLeft);
            Controls.Add(btnMoveRight);
            Controls.Add(lsvAssignedLoaders);
            Controls.Add(lsvUnassignedLoaders);
            Controls.Add(btnCreateLoader);
            Controls.Add(btnBack);
            Name = "frmCreateAssignLoader";
            Text = "Create and Assign Loader";
            ResumeLayout(false);
            PerformLayout();
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