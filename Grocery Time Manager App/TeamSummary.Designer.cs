namespace Grocery_Time_Manager_App
{
    partial class TeamSummary
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
            this.lblSummaryDate = new System.Windows.Forms.Label();
            this.dtpSummaryDate = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.lblSummary = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 23);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // lblSummaryDate
            // 
            this.lblSummaryDate.AutoSize = true;
            this.lblSummaryDate.Location = new System.Drawing.Point(12, 64);
            this.lblSummaryDate.Name = "lblSummaryDate";
            this.lblSummaryDate.Size = new System.Drawing.Size(70, 15);
            this.lblSummaryDate.TabIndex = 11;
            this.lblSummaryDate.Text = "For the Day:";
            // 
            // dtpSummaryDate
            // 
            this.dtpSummaryDate.Location = new System.Drawing.Point(88, 58);
            this.dtpSummaryDate.Name = "dtpSummaryDate";
            this.dtpSummaryDate.Size = new System.Drawing.Size(200, 23);
            this.dtpSummaryDate.TabIndex = 10;
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 108);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(479, 316);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // lblSummary
            // 
            this.lblSummary.AutoSize = true;
            this.lblSummary.Location = new System.Drawing.Point(12, 90);
            this.lblSummary.Name = "lblSummary";
            this.lblSummary.Size = new System.Drawing.Size(61, 15);
            this.lblSummary.TabIndex = 13;
            this.lblSummary.Text = "Summary:";
            // 
            // TeamSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblSummary);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblSummaryDate);
            this.Controls.Add(this.dtpSummaryDate);
            this.Controls.Add(this.btnBack);
            this.Name = "TeamSummary";
            this.Text = "TeamSummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Label lblSummaryDate;
        private DateTimePicker dtpSummaryDate;
        private ListView listView1;
        private Label lblSummary;
    }
}