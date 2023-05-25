namespace Grocery_Time_Manager_App
{
    partial class frmCreateLoader
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
            this.lblAisle = new System.Windows.Forms.Label();
            this.lblProductType = new System.Windows.Forms.Label();
            this.lblNumBoxes = new System.Windows.Forms.Label();
            this.lblTimeIssued = new System.Windows.Forms.Label();
            this.nudAisle = new System.Windows.Forms.NumericUpDown();
            this.nudNumBoxes = new System.Windows.Forms.NumericUpDown();
            this.dtpTimeIssued = new System.Windows.Forms.DateTimePicker();
            this.cbxProductType = new System.Windows.Forms.ComboBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btnClearFields = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAisle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBoxes)).BeginInit();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(12, 12);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(95, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblAisle
            // 
            this.lblAisle.AutoSize = true;
            this.lblAisle.Location = new System.Drawing.Point(56, 62);
            this.lblAisle.Name = "lblAisle";
            this.lblAisle.Size = new System.Drawing.Size(35, 15);
            this.lblAisle.TabIndex = 2;
            this.lblAisle.Text = "Aisle:";
            // 
            // lblProductType
            // 
            this.lblProductType.AutoSize = true;
            this.lblProductType.Location = new System.Drawing.Point(12, 101);
            this.lblProductType.Name = "lblProductType";
            this.lblProductType.Size = new System.Drawing.Size(79, 15);
            this.lblProductType.TabIndex = 3;
            this.lblProductType.Text = "Product Type:";
            // 
            // lblNumBoxes
            // 
            this.lblNumBoxes.AutoSize = true;
            this.lblNumBoxes.Location = new System.Drawing.Point(28, 142);
            this.lblNumBoxes.Name = "lblNumBoxes";
            this.lblNumBoxes.Size = new System.Drawing.Size(63, 15);
            this.lblNumBoxes.TabIndex = 4;
            this.lblNumBoxes.Text = "No. Boxes:";
            // 
            // lblTimeIssued
            // 
            this.lblTimeIssued.AutoSize = true;
            this.lblTimeIssued.Location = new System.Drawing.Point(19, 183);
            this.lblTimeIssued.Name = "lblTimeIssued";
            this.lblTimeIssued.Size = new System.Drawing.Size(72, 15);
            this.lblTimeIssued.TabIndex = 5;
            this.lblTimeIssued.Text = "Time Issued:";
            // 
            // nudAisle
            // 
            this.nudAisle.Location = new System.Drawing.Point(106, 60);
            this.nudAisle.Name = "nudAisle";
            this.nudAisle.Size = new System.Drawing.Size(120, 23);
            this.nudAisle.TabIndex = 6;
            // 
            // nudNumBoxes
            // 
            this.nudNumBoxes.Location = new System.Drawing.Point(106, 140);
            this.nudNumBoxes.Name = "nudNumBoxes";
            this.nudNumBoxes.Size = new System.Drawing.Size(120, 23);
            this.nudNumBoxes.TabIndex = 7;
            // 
            // dtpTimeIssued
            // 
            this.dtpTimeIssued.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTimeIssued.Location = new System.Drawing.Point(106, 177);
            this.dtpTimeIssued.Name = "dtpTimeIssued";
            this.dtpTimeIssued.Size = new System.Drawing.Size(191, 23);
            this.dtpTimeIssued.TabIndex = 8;
            this.dtpTimeIssued.Value = new System.DateTime(2023, 3, 20, 12, 53, 22, 0);
            // 
            // cbxProductType
            // 
            this.cbxProductType.FormattingEnabled = true;
            this.cbxProductType.Location = new System.Drawing.Point(106, 98);
            this.cbxProductType.Name = "cbxProductType";
            this.cbxProductType.Size = new System.Drawing.Size(120, 23);
            this.cbxProductType.TabIndex = 9;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(12, 290);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(168, 43);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Location = new System.Drawing.Point(202, 206);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(95, 23);
            this.btnClearFields.TabIndex = 11;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            // 
            // frmCreateLoader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.cbxProductType);
            this.Controls.Add(this.dtpTimeIssued);
            this.Controls.Add(this.nudNumBoxes);
            this.Controls.Add(this.nudAisle);
            this.Controls.Add(this.lblTimeIssued);
            this.Controls.Add(this.lblNumBoxes);
            this.Controls.Add(this.lblProductType);
            this.Controls.Add(this.lblAisle);
            this.Controls.Add(this.btnBack);
            this.Name = "frmCreateLoader";
            this.Text = "Create Loader";
            ((System.ComponentModel.ISupportInitialize)(this.nudAisle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumBoxes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Label lblAisle;
        private Label lblProductType;
        private Label lblNumBoxes;
        private Label lblTimeIssued;
        private NumericUpDown nudAisle;
        private NumericUpDown nudNumBoxes;
        private DateTimePicker dtpTimeIssued;
        private ComboBox cbxProductType;
        private Button btnEnter;
        private Button btnClearFields;
    }
}