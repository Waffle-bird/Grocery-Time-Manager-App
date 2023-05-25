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
            this.btnBack = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.lblAddEmployee = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.IblId = new System.Windows.Forms.Label();
            this.nudId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 23);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 92);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(42, 15);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Name:";
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(69, 89);
            this.tbxName.Name = "tbxName";
            this.tbxName.Size = new System.Drawing.Size(100, 23);
            this.tbxName.TabIndex = 5;
            // 
            // lblAddEmployee
            // 
            this.lblAddEmployee.AutoSize = true;
            this.lblAddEmployee.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAddEmployee.Location = new System.Drawing.Point(12, 49);
            this.lblAddEmployee.Name = "lblAddEmployee";
            this.lblAddEmployee.Size = new System.Drawing.Size(163, 25);
            this.lblAddEmployee.TabIndex = 6;
            this.lblAddEmployee.Text = "Add an Employee:";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(12, 196);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(95, 23);
            this.btnEnter.TabIndex = 7;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // IblId
            // 
            this.IblId.AutoSize = true;
            this.IblId.Location = new System.Drawing.Point(12, 133);
            this.IblId.Name = "IblId";
            this.IblId.Size = new System.Drawing.Size(21, 15);
            this.IblId.TabIndex = 8;
            this.IblId.Text = "ID:";
            // 
            // nudId
            // 
            this.nudId.Location = new System.Drawing.Point(69, 131);
            this.nudId.Name = "nudId";
            this.nudId.Size = new System.Drawing.Size(100, 23);
            this.nudId.TabIndex = 9;
            // 
            // frmAddEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.nudId);
            this.Controls.Add(this.IblId);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblAddEmployee);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.btnBack);
            this.Name = "frmAddEmployee";
            this.Text = "Add Employee";
            ((System.ComponentModel.ISupportInitialize)(this.nudId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Label lblName;
        private TextBox tbxName;
        private Label lblAddEmployee;
        private Button btnEnter;
        private Label IblId;
        private NumericUpDown nudId;
    }
}