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
            btnBack = new Button();
            lblAisle = new Label();
            lblProductType = new Label();
            lblNumBoxes = new Label();
            lblTimeIssued = new Label();
            nudAisle = new NumericUpDown();
            nudNumBoxes = new NumericUpDown();
            dtpTimeIssued = new DateTimePicker();
            cbxProductType = new ComboBox();
            btnEnter = new Button();
            btnClearFields = new Button();
            ((System.ComponentModel.ISupportInitialize)nudAisle).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudNumBoxes).BeginInit();
            SuspendLayout();
            // 
            // btnBack
            // 
            btnBack.Location = new Point(12, 12);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(95, 23);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // lblAisle
            // 
            lblAisle.AutoSize = true;
            lblAisle.Location = new Point(56, 62);
            lblAisle.Name = "lblAisle";
            lblAisle.Size = new Size(35, 15);
            lblAisle.TabIndex = 2;
            lblAisle.Text = "Aisle:";
            // 
            // lblProductType
            // 
            lblProductType.AutoSize = true;
            lblProductType.Location = new Point(12, 101);
            lblProductType.Name = "lblProductType";
            lblProductType.Size = new Size(79, 15);
            lblProductType.TabIndex = 3;
            lblProductType.Text = "Product Type:";
            // 
            // lblNumBoxes
            // 
            lblNumBoxes.AutoSize = true;
            lblNumBoxes.Location = new Point(28, 142);
            lblNumBoxes.Name = "lblNumBoxes";
            lblNumBoxes.Size = new Size(63, 15);
            lblNumBoxes.TabIndex = 4;
            lblNumBoxes.Text = "No. Boxes:";
            // 
            // lblTimeIssued
            // 
            lblTimeIssued.AutoSize = true;
            lblTimeIssued.Location = new Point(19, 183);
            lblTimeIssued.Name = "lblTimeIssued";
            lblTimeIssued.Size = new Size(72, 15);
            lblTimeIssued.TabIndex = 5;
            lblTimeIssued.Text = "Time Issued:";
            // 
            // nudAisle
            // 
            nudAisle.Location = new Point(106, 60);
            nudAisle.Name = "nudAisle";
            nudAisle.Size = new Size(120, 23);
            nudAisle.TabIndex = 6;
            nudAisle.ValueChanged += nudAisle_ValueChanged;
            // 
            // nudNumBoxes
            // 
            nudNumBoxes.Location = new Point(106, 140);
            nudNumBoxes.Name = "nudNumBoxes";
            nudNumBoxes.Size = new Size(120, 23);
            nudNumBoxes.TabIndex = 7;
            // 
            // dtpTimeIssued
            // 
            dtpTimeIssued.CustomFormat = "hh:mm tt";
            dtpTimeIssued.Format = DateTimePickerFormat.Custom;
            dtpTimeIssued.ImeMode = ImeMode.NoControl;
            dtpTimeIssued.Location = new Point(106, 177);
            dtpTimeIssued.Name = "dtpTimeIssued";
            dtpTimeIssued.Size = new Size(191, 23);
            dtpTimeIssued.TabIndex = 8;
            dtpTimeIssued.Value = new DateTime(2023, 7, 18, 0, 0, 0, 0);
            dtpTimeIssued.ShowUpDown = true;
            // 
            // cbxProductType
            // 
            cbxProductType.DropDownStyle = ComboBoxStyle.DropDownList;
            cbxProductType.FormattingEnabled = true;
            cbxProductType.Location = new Point(106, 98);
            cbxProductType.Name = "cbxProductType";
            cbxProductType.Size = new Size(120, 23);
            cbxProductType.TabIndex = 9;
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(12, 290);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(168, 43);
            btnEnter.TabIndex = 10;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // btnClearFields
            // 
            btnClearFields.Location = new Point(202, 206);
            btnClearFields.Name = "btnClearFields";
            btnClearFields.Size = new Size(95, 23);
            btnClearFields.TabIndex = 11;
            btnClearFields.Text = "Clear Fields";
            btnClearFields.UseVisualStyleBackColor = true;
            btnClearFields.Click += btnClearFields_Click;
            // 
            // frmCreateLoader
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnClearFields);
            Controls.Add(btnEnter);
            Controls.Add(cbxProductType);
            Controls.Add(dtpTimeIssued);
            Controls.Add(nudNumBoxes);
            Controls.Add(nudAisle);
            Controls.Add(lblTimeIssued);
            Controls.Add(lblNumBoxes);
            Controls.Add(lblProductType);
            Controls.Add(lblAisle);
            Controls.Add(btnBack);
            Name = "frmCreateLoader";
            Text = "Create Loader";
            ((System.ComponentModel.ISupportInitialize)nudAisle).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudNumBoxes).EndInit();
            ResumeLayout(false);
            PerformLayout();
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