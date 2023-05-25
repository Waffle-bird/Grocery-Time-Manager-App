namespace Grocery_Time_Manager_App
{
    partial class frmIndividualSummary
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
            this.lsvWorker = new System.Windows.Forms.ListView();
            this.lblSelectWorker = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblSummary = new System.Windows.Forms.Label();
            this.dtpSummaryDate = new System.Windows.Forms.DateTimePicker();
            this.lblSummaryDate = new System.Windows.Forms.Label();
            this.btnTeamSummary = new System.Windows.Forms.Button();
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
            // lsvWorker
            // 
            this.lsvWorker.Location = new System.Drawing.Point(12, 122);
            this.lsvWorker.Name = "lsvWorker";
            this.lsvWorker.Size = new System.Drawing.Size(239, 316);
            this.lsvWorker.TabIndex = 4;
            this.lsvWorker.UseCompatibleStateImageBehavior = false;
            // 
            // lblSelectWorker
            // 
            this.lblSelectWorker.AutoSize = true;
            this.lblSelectWorker.Location = new System.Drawing.Point(12, 104);
            this.lblSelectWorker.Name = "lblSelectWorker";
            this.lblSelectWorker.Size = new System.Drawing.Size(82, 15);
            this.lblSelectWorker.TabIndex = 5;
            this.lblSelectWorker.Text = "Select Worker:";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(271, 122);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(479, 316);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(271, 104);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(61, 15);
            this.lblSummary.TabIndex = 7;
            this.lblSummary.Text = "Summary:";
            // 
            // dtpSummaryDate
            // 
            this.dtpSummaryDate.Location = new System.Drawing.Point(88, 60);
            this.dtpSummaryDate.Name = "dtpSummaryDate";
            this.dtpSummaryDate.Size = new System.Drawing.Size(200, 23);
            this.dtpSummaryDate.TabIndex = 8;
            // 
            // lblSummaryDate
            // 
            this.lblSummaryDate.AutoSize = true;
            this.lblSummaryDate.Location = new System.Drawing.Point(12, 66);
            this.lblSummaryDate.Name = "lblSummaryDate";
            this.lblSummaryDate.Size = new System.Drawing.Size(70, 15);
            this.lblSummaryDate.TabIndex = 9;
            this.lblSummaryDate.Text = "For the Day:";
            // 
            // btnTeamSummary
            // 
            this.btnTeamSummary.Location = new System.Drawing.Point(659, 12);
            this.btnTeamSummary.Name = "btnTeamSummary";
            this.btnTeamSummary.Size = new System.Drawing.Size(129, 23);
            this.btnTeamSummary.TabIndex = 15;
            this.btnTeamSummary.Text = "Team Summary";
            this.btnTeamSummary.UseVisualStyleBackColor = true;
            this.btnTeamSummary.Click += new System.EventHandler(this.btnTeamSummary_Click);
            // 
            // frmIndividualSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnTeamSummary);
            this.Controls.Add(this.lblSummaryDate);
            this.Controls.Add(this.dtpSummaryDate);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblSelectWorker);
            this.Controls.Add(this.lsvWorker);
            this.Controls.Add(this.btnBack);
            this.Name = "frmIndividualSummary";
            this.Text = "IndividualSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private ListView lsvWorker;
        private Label lblSelectWorker;
        private ListView listView1;
        private Label lblSummary;
        private DateTimePicker dtpSummaryDate;
        private Label lblSummaryDate;
        private Button btnTeamSummary;
    }
}