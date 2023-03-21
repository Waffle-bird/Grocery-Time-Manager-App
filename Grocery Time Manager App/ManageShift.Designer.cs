namespace Grocery_Time_Manager_App
{
    partial class frmManageShift
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
            this.lsvWorkers = new System.Windows.Forms.ListView();
            this.lsvEmployees = new System.Windows.Forms.ListView();
            this.btnMoveLeft = new System.Windows.Forms.Button();
            this.btnMoveRight = new System.Windows.Forms.Button();
            this.lblEmployees = new System.Windows.Forms.Label();
            this.lblWorkers = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblShiftTime = new System.Windows.Forms.Label();
            this.rbtAM = new System.Windows.Forms.RadioButton();
            this.rbtPM = new System.Windows.Forms.RadioButton();
            this.dtpShiftDay = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 23);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lsvWorkers
            // 
            this.lsvWorkers.Location = new System.Drawing.Point(347, 104);
            this.lsvWorkers.Name = "lsvWorkers";
            this.lsvWorkers.Size = new System.Drawing.Size(228, 311);
            this.lsvWorkers.TabIndex = 3;
            this.lsvWorkers.UseCompatibleStateImageBehavior = false;
            // 
            // lsvEmployees
            // 
            this.lsvEmployees.Location = new System.Drawing.Point(12, 104);
            this.lsvEmployees.Name = "lsvEmployees";
            this.lsvEmployees.Size = new System.Drawing.Size(228, 311);
            this.lsvEmployees.TabIndex = 4;
            this.lsvEmployees.UseCompatibleStateImageBehavior = false;
            // 
            // btnMoveLeft
            // 
            this.btnMoveLeft.Location = new System.Drawing.Point(257, 270);
            this.btnMoveLeft.Name = "btnMoveLeft";
            this.btnMoveLeft.Size = new System.Drawing.Size(75, 23);
            this.btnMoveLeft.TabIndex = 7;
            this.btnMoveLeft.Text = "<===";
            this.btnMoveLeft.UseVisualStyleBackColor = true;
            // 
            // btnMoveRight
            // 
            this.btnMoveRight.Location = new System.Drawing.Point(257, 241);
            this.btnMoveRight.Name = "btnMoveRight";
            this.btnMoveRight.Size = new System.Drawing.Size(75, 23);
            this.btnMoveRight.TabIndex = 6;
            this.btnMoveRight.Text = "===>";
            this.btnMoveRight.UseVisualStyleBackColor = true;
            // 
            // lblEmployees
            // 
            this.lblEmployees.AutoSize = true;
            this.lblEmployees.Location = new System.Drawing.Point(12, 86);
            this.lblEmployees.Name = "lblEmployees";
            this.lblEmployees.Size = new System.Drawing.Size(67, 15);
            this.lblEmployees.TabIndex = 8;
            this.lblEmployees.Text = "Employees:";
            // 
            // lblWorkers
            // 
            this.lblWorkers.AutoSize = true;
            this.lblWorkers.Location = new System.Drawing.Point(347, 86);
            this.lblWorkers.Name = "lblWorkers";
            this.lblWorkers.Size = new System.Drawing.Size(89, 15);
            this.lblWorkers.TabIndex = 9;
            this.lblWorkers.Text = "Working Today:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(347, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Day:";
            // 
            // lblShiftTime
            // 
            this.lblShiftTime.AutoSize = true;
            this.lblShiftTime.Location = new System.Drawing.Point(347, 12);
            this.lblShiftTime.Name = "lblShiftTime";
            this.lblShiftTime.Size = new System.Drawing.Size(66, 15);
            this.lblShiftTime.TabIndex = 12;
            this.lblShiftTime.Text = " Shift Time:";
            // 
            // rbtAM
            // 
            this.rbtAM.AutoSize = true;
            this.rbtAM.Location = new System.Drawing.Point(419, 10);
            this.rbtAM.Name = "rbtAM";
            this.rbtAM.Size = new System.Drawing.Size(44, 19);
            this.rbtAM.TabIndex = 13;
            this.rbtAM.TabStop = true;
            this.rbtAM.Text = "AM";
            this.rbtAM.UseVisualStyleBackColor = true;
            // 
            // rbtPM
            // 
            this.rbtPM.AutoSize = true;
            this.rbtPM.Location = new System.Drawing.Point(478, 10);
            this.rbtPM.Name = "rbtPM";
            this.rbtPM.Size = new System.Drawing.Size(43, 19);
            this.rbtPM.TabIndex = 14;
            this.rbtPM.TabStop = true;
            this.rbtPM.Text = "PM";
            this.rbtPM.UseVisualStyleBackColor = true;
            // 
            // dtpShiftDay
            // 
            this.dtpShiftDay.Location = new System.Drawing.Point(383, 35);
            this.dtpShiftDay.Name = "dtpShiftDay";
            this.dtpShiftDay.Size = new System.Drawing.Size(192, 23);
            this.dtpShiftDay.TabIndex = 15;
            // 
            // frmManageShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpShiftDay);
            this.Controls.Add(this.rbtPM);
            this.Controls.Add(this.rbtAM);
            this.Controls.Add(this.lblShiftTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWorkers);
            this.Controls.Add(this.lblEmployees);
            this.Controls.Add(this.btnMoveLeft);
            this.Controls.Add(this.btnMoveRight);
            this.Controls.Add(this.lsvEmployees);
            this.Controls.Add(this.lsvWorkers);
            this.Controls.Add(this.btnBack);
            this.Name = "frmManageShift";
            this.Text = "ManageShift";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private ListView lsvWorkers;
        private ListView lsvEmployees;
        private Button btnMoveLeft;
        private Button btnMoveRight;
        private Label lblEmployees;
        private Label lblWorkers;
        private Label label2;
        private Label lblShiftTime;
        private RadioButton rbtAM;
        private RadioButton rbtPM;
        private DateTimePicker dtpShiftDay;
    }
}