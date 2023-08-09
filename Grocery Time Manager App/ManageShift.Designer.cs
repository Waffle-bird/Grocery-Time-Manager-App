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
            btnBack = new Button();
            lsvWorkers = new ListView();
            lsvEmployees = new ListView();
            btnMoveLeft = new Button();
            btnMoveRight = new Button();
            lblEmployees = new Label();
            lblWorkers = new Label();
            label2 = new Label();
            lblShiftTime = new Label();
            rbtAM = new RadioButton();
            rbtPM = new RadioButton();
            dtpShiftDay = new DateTimePicker();
            tbxSearch = new TextBox();
            lblsearch = new Label();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 23);
            btnBack.TabIndex = 2;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lsvWorkers
            // 
            lsvWorkers.FullRowSelect = true;
            lsvWorkers.Location = new Point(347, 104);
            lsvWorkers.Name = "lsvWorkers";
            lsvWorkers.Size = new Size(228, 311);
            lsvWorkers.TabIndex = 3;
            lsvWorkers.UseCompatibleStateImageBehavior = false;
            lsvWorkers.SelectedIndexChanged += lsvWorkers_SelectedIndexChanged;
            // 
            // lsvEmployees
            // 
            lsvEmployees.FullRowSelect = true;
            lsvEmployees.Location = new Point(12, 104);
            lsvEmployees.Name = "lsvEmployees";
            lsvEmployees.Size = new Size(228, 311);
            lsvEmployees.TabIndex = 4;
            lsvEmployees.UseCompatibleStateImageBehavior = false;
            lsvEmployees.SelectedIndexChanged += lsvEmployees_SelectedIndexChanged;
            // 
            // btnMoveLeft
            // 
            btnMoveLeft.Location = new Point(257, 270);
            btnMoveLeft.Name = "btnMoveLeft";
            btnMoveLeft.Size = new Size(75, 23);
            btnMoveLeft.TabIndex = 7;
            btnMoveLeft.Text = "<===";
            btnMoveLeft.UseVisualStyleBackColor = true;
            btnMoveLeft.Click += btnMoveLeft_Click;
            // 
            // btnMoveRight
            // 
            btnMoveRight.Location = new Point(257, 241);
            btnMoveRight.Name = "btnMoveRight";
            btnMoveRight.Size = new Size(75, 23);
            btnMoveRight.TabIndex = 6;
            btnMoveRight.Text = "===>";
            btnMoveRight.UseVisualStyleBackColor = true;
            btnMoveRight.Click += btnMoveRight_Click;
            // 
            // lblEmployees
            // 
            lblEmployees.AutoSize = true;
            lblEmployees.Location = new Point(12, 86);
            lblEmployees.Name = "lblEmployees";
            lblEmployees.Size = new Size(67, 15);
            lblEmployees.TabIndex = 8;
            lblEmployees.Text = "Employees:";
            // 
            // lblWorkers
            // 
            lblWorkers.AutoSize = true;
            lblWorkers.Location = new Point(347, 86);
            lblWorkers.Name = "lblWorkers";
            lblWorkers.Size = new Size(89, 15);
            lblWorkers.TabIndex = 9;
            lblWorkers.Text = "Working Today:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(347, 40);
            label2.Name = "label2";
            label2.Size = new Size(30, 15);
            label2.TabIndex = 11;
            label2.Text = "Day:";
            // 
            // lblShiftTime
            // 
            lblShiftTime.AutoSize = true;
            lblShiftTime.Location = new Point(347, 12);
            lblShiftTime.Name = "lblShiftTime";
            lblShiftTime.Size = new Size(66, 15);
            lblShiftTime.TabIndex = 12;
            lblShiftTime.Text = " Shift Time:";
            // 
            // rbtAM
            // 
            rbtAM.AutoSize = true;
            rbtAM.Checked = true;
            rbtAM.Location = new Point(419, 10);
            rbtAM.Name = "rbtAM";
            rbtAM.Size = new Size(44, 19);
            rbtAM.TabIndex = 13;
            rbtAM.TabStop = true;
            rbtAM.Text = "AM";
            rbtAM.UseVisualStyleBackColor = true;
            rbtAM.CheckedChanged += rbtAM_CheckedChanged;
            // 
            // rbtPM
            // 
            rbtPM.AutoSize = true;
            rbtPM.Location = new Point(478, 10);
            rbtPM.Name = "rbtPM";
            rbtPM.Size = new Size(43, 19);
            rbtPM.TabIndex = 14;
            rbtPM.Text = "PM";
            rbtPM.UseVisualStyleBackColor = true;
            // 
            // dtpShiftDay
            // 
            dtpShiftDay.Location = new Point(383, 35);
            dtpShiftDay.Name = "dtpShiftDay";
            dtpShiftDay.Size = new Size(192, 23);
            dtpShiftDay.TabIndex = 15;
            dtpShiftDay.ValueChanged += dtpShiftDay_ValueChanged;
            // 
            // tbxSearch
            // 
            tbxSearch.Location = new Point(69, 51);
            tbxSearch.Name = "tbxSearch";
            tbxSearch.Size = new Size(100, 23);
            tbxSearch.TabIndex = 16;
            tbxSearch.TextChanged += tbxSearch_TextChanged;
            // 
            // lblsearch
            // 
            lblsearch.AutoSize = true;
            lblsearch.Location = new Point(12, 54);
            lblsearch.Name = "lblsearch";
            lblsearch.Size = new Size(45, 15);
            lblsearch.TabIndex = 17;
            lblsearch.Text = "Search:";
            // 
            // frmManageShift
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblsearch);
            Controls.Add(tbxSearch);
            Controls.Add(dtpShiftDay);
            Controls.Add(rbtPM);
            Controls.Add(rbtAM);
            Controls.Add(lblShiftTime);
            Controls.Add(label2);
            Controls.Add(lblWorkers);
            Controls.Add(lblEmployees);
            Controls.Add(btnMoveLeft);
            Controls.Add(btnMoveRight);
            Controls.Add(lsvEmployees);
            Controls.Add(lsvWorkers);
            Controls.Add(btnBack);
            Name = "frmManageShift";
            Text = "ManageShift";
            ResumeLayout(false);
            PerformLayout();
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
        private TextBox tbxSearch;
        private Label lblsearch;
    }
}