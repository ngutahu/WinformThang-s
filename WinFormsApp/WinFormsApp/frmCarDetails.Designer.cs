namespace WinFormsApp
{
    partial class frmCarDetails
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbCarID = new Label();
            lbCarName = new Label();
            lbManu = new Label();
            lbPrice = new Label();
            lbReleased = new Label();
            txtCarID = new TextBox();
            txtCarName = new TextBox();
            btnSave = new Button();
            txtPrice = new MaskedTextBox();
            txtReleasedYear = new MaskedTextBox();
            cboManufacturer = new ComboBox();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbCarID.Location = new Point(111, 29);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(110, 49);
            lbCarID.TabIndex = 0;
            lbCarID.Text = "Car ID";
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbCarName.Location = new Point(111, 104);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(165, 49);
            lbCarName.TabIndex = 2;
            lbCarName.Text = "Car Name";
            // 
            // lbManu
            // 
            lbManu.AutoSize = true;
            lbManu.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbManu.Location = new Point(111, 173);
            lbManu.Name = "lbManu";
            lbManu.Size = new Size(211, 49);
            lbManu.TabIndex = 3;
            lbManu.Text = "Manufacturer";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(111, 236);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(94, 49);
            lbPrice.TabIndex = 4;
            lbPrice.Text = "Price";
            // 
            // lbReleased
            // 
            lbReleased.AutoSize = true;
            lbReleased.Font = new Font("Sans Serif Collection", 11.999999F, FontStyle.Regular, GraphicsUnit.Point);
            lbReleased.Location = new Point(111, 309);
            lbReleased.Name = "lbReleased";
            lbReleased.Size = new Size(227, 49);
            lbReleased.TabIndex = 5;
            lbReleased.Text = "Released Year";
            // 
            // txtCarID
            // 
            txtCarID.BorderStyle = BorderStyle.FixedSingle;
            txtCarID.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarID.Location = new Point(351, 31);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(323, 41);
            txtCarID.TabIndex = 6;
            // 
            // txtCarName
            // 
            txtCarName.BorderStyle = BorderStyle.FixedSingle;
            txtCarName.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarName.Location = new Point(351, 104);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(323, 41);
            txtCarName.TabIndex = 7;
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(272, 382);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 11;
            btnSave.TabStop = false;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtPrice
            // 
            txtPrice.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(351, 237);
            txtPrice.Mask = "00000000000000000000";
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(323, 41);
            txtPrice.TabIndex = 12;
            txtPrice.Text = "0";
            // 
            // txtReleasedYear
            // 
            txtReleasedYear.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            txtReleasedYear.Location = new Point(351, 317);
            txtReleasedYear.Mask = "000000";
            txtReleasedYear.Name = "txtReleasedYear";
            txtReleasedYear.Size = new Size(323, 41);
            txtReleasedYear.TabIndex = 13;
            txtReleasedYear.Text = "0";
            // 
            // cboManufacturer
            // 
            cboManufacturer.BackColor = SystemColors.MenuBar;
            cboManufacturer.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            cboManufacturer.FormattingEnabled = true;
            cboManufacturer.Items.AddRange(new object[] { "Audi", "BMW", "Ford", "Honda", "Hyundai", "Kia", "Suzuki", "Toyota", "Porsche" });
            cboManufacturer.Location = new Point(351, 173);
            cboManufacturer.Name = "cboManufacturer";
            cboManufacturer.Size = new Size(323, 43);
            cboManufacturer.TabIndex = 14;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(461, 382);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 15;
            btnCancel.TabStop = false;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmCarDetails
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCancel);
            Controls.Add(cboManufacturer);
            Controls.Add(txtReleasedYear);
            Controls.Add(txtPrice);
            Controls.Add(btnSave);
            Controls.Add(txtCarName);
            Controls.Add(txtCarID);
            Controls.Add(lbReleased);
            Controls.Add(lbPrice);
            Controls.Add(lbManu);
            Controls.Add(lbCarName);
            Controls.Add(lbCarID);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "frmCarDetails";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmCarDetails";
            Load += frmCarDetails_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbCarID;
        private Label lbCarName;
        private Label lbManu;
        private Label lbPrice;
        private Label lbReleased;
        private TextBox txtCarID;
        private TextBox txtCarName;
        private TextBox txtManu;
        private Button btnSave;
        private MaskedTextBox txtPrice;
        private MaskedTextBox txtReleasedYear;
        private ComboBox cboManufacturer;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnCancel;
    }
}