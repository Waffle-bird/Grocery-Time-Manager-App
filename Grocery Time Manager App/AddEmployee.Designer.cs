namespace Grocery_Time_Manager_App
{
    partial class frmAddEmployee
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
            lblName = new Label();
            tbxName = new TextBox();
            lblAddEmployee = new Label();
            btnEnter = new Button();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 23);
            btnBack.TabIndex = 3;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(12, 92);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 4;
            lblName.Text = "Name:";
            // 
            // tbxName
            // 
            tbxName.Location = new Point(69, 89);
            tbxName.Name = "tbxName";
            tbxName.Size = new Size(100, 23);
            tbxName.TabIndex = 5;
            // 
            // lblAddEmployee
            // 
            lblAddEmployee.AutoSize = true;
            lblAddEmployee.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            lblAddEmployee.Location = new Point(12, 49);
            lblAddEmployee.Name = "lblAddEmployee";
            lblAddEmployee.Size = new Size(163, 25);
            lblAddEmployee.TabIndex = 6;
            lblAddEmployee.Text = "Add an Employee:";
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(12, 144);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(95, 23);
            btnEnter.TabIndex = 7;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // frmAddEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnEnter);
            Controls.Add(lblAddEmployee);
            Controls.Add(tbxName);
            Controls.Add(lblName);
            Controls.Add(btnBack);
            Name = "frmAddEmployee";
            Text = "Add Employee";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnBack;
        private Label lblName;
        private TextBox tbxName;
        private Label lblAddEmployee;
        private Button btnEnter;
    }
}