namespace WinFormsApp
{
    partial class frmCarManagement
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
            txtManufacturer = new TextBox();
            lbCarName = new Label();
            lbPrice = new Label();
            lbReleaseYear = new Label();
            lbCarID = new Label();
            lbManufacturer = new Label();
            txtReleaseYear = new TextBox();
            txtCarName = new TextBox();
            txtCarID = new TextBox();
            txtPrice = new TextBox();
            btnLoad = new Button();
            btnNew = new Button();
            btnDelete = new Button();
            dgvCarList = new DataGridView();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCarList).BeginInit();
            SuspendLayout();
            // 
            // txtManufacturer
            // 
            txtManufacturer.BorderStyle = BorderStyle.FixedSingle;
            txtManufacturer.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtManufacturer.Location = new Point(180, 138);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(279, 36);
            txtManufacturer.TabIndex = 11;
            // 
            // lbCarName
            // 
            lbCarName.AutoSize = true;
            lbCarName.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbCarName.Location = new Point(12, 82);
            lbCarName.Name = "lbCarName";
            lbCarName.Size = new Size(124, 37);
            lbCarName.TabIndex = 17;
            lbCarName.Text = "Car Name";
            // 
            // lbPrice
            // 
            lbPrice.AutoSize = true;
            lbPrice.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbPrice.Location = new Point(500, 30);
            lbPrice.Name = "lbPrice";
            lbPrice.Size = new Size(73, 37);
            lbPrice.TabIndex = 19;
            lbPrice.Text = "Price";
            // 
            // lbReleaseYear
            // 
            lbReleaseYear.AutoSize = true;
            lbReleaseYear.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbReleaseYear.Location = new Point(500, 94);
            lbReleaseYear.Name = "lbReleaseYear";
            lbReleaseYear.Size = new Size(176, 37);
            lbReleaseYear.TabIndex = 20;
            lbReleaseYear.Text = "Released Year";
            // 
            // lbCarID
            // 
            lbCarID.AutoSize = true;
            lbCarID.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbCarID.Location = new Point(12, 27);
            lbCarID.Name = "lbCarID";
            lbCarID.Size = new Size(82, 37);
            lbCarID.TabIndex = 21;
            lbCarID.Text = "Car ID";
            // 
            // lbManufacturer
            // 
            lbManufacturer.AutoSize = true;
            lbManufacturer.Font = new Font("Sans Serif Collection", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbManufacturer.Location = new Point(12, 137);
            lbManufacturer.Name = "lbManufacturer";
            lbManufacturer.Size = new Size(156, 37);
            lbManufacturer.TabIndex = 22;
            lbManufacturer.Text = "Manufacturer";
            // 
            // txtReleaseYear
            // 
            txtReleaseYear.BorderStyle = BorderStyle.FixedSingle;
            txtReleaseYear.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtReleaseYear.Location = new Point(691, 92);
            txtReleaseYear.Name = "txtReleaseYear";
            txtReleaseYear.Size = new Size(279, 36);
            txtReleaseYear.TabIndex = 23;
            // 
            // txtCarName
            // 
            txtCarName.BorderStyle = BorderStyle.FixedSingle;
            txtCarName.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarName.Location = new Point(180, 83);
            txtCarName.Name = "txtCarName";
            txtCarName.Size = new Size(279, 36);
            txtCarName.TabIndex = 24;
            // 
            // txtCarID
            // 
            txtCarID.BorderStyle = BorderStyle.FixedSingle;
            txtCarID.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtCarID.Location = new Point(180, 28);
            txtCarID.Name = "txtCarID";
            txtCarID.Size = new Size(279, 36);
            txtCarID.TabIndex = 25;
            // 
            // txtPrice
            // 
            txtPrice.BorderStyle = BorderStyle.FixedSingle;
            txtPrice.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            txtPrice.Location = new Point(691, 25);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(279, 36);
            txtPrice.TabIndex = 26;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(290, 193);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(94, 29);
            btnLoad.TabIndex = 27;
            btnLoad.TabStop = false;
            btnLoad.Text = "Load";
            btnLoad.UseVisualStyleBackColor = true;
            btnLoad.Click += btnLoad_Click;
            // 
            // btnNew
            // 
            btnNew.Location = new Point(479, 193);
            btnNew.Name = "btnNew";
            btnNew.Size = new Size(94, 29);
            btnNew.TabIndex = 28;
            btnNew.TabStop = false;
            btnNew.Text = "New";
            btnNew.UseVisualStyleBackColor = true;
            btnNew.Click += btnNew_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(655, 193);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 29;
            btnDelete.TabStop = false;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // dgvCarList
            // 
            dgvCarList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCarList.Location = new Point(22, 239);
            dgvCarList.Name = "dgvCarList";
            dgvCarList.ReadOnly = true;
            dgvCarList.RowHeadersWidth = 51;
            dgvCarList.RowTemplate.Height = 29;
            dgvCarList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvCarList.Size = new Size(968, 174);
            dgvCarList.TabIndex = 30;
            dgvCarList.CellDoubleClick += dgvCarList_CellDoubleClick;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Retry;
            btnClose.Location = new Point(479, 419);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 31;
            btnClose.TabStop = false;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmCarManagement
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1020, 450);
            Controls.Add(btnClose);
            Controls.Add(dgvCarList);
            Controls.Add(btnDelete);
            Controls.Add(btnNew);
            Controls.Add(btnLoad);
            Controls.Add(txtPrice);
            Controls.Add(txtCarID);
            Controls.Add(txtCarName);
            Controls.Add(txtReleaseYear);
            Controls.Add(lbManufacturer);
            Controls.Add(lbCarID);
            Controls.Add(lbReleaseYear);
            Controls.Add(lbPrice);
            Controls.Add(lbCarName);
            Controls.Add(txtManufacturer);
            Name = "frmCarManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Car Management";
            Load += frmCarManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCarList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox txtManufacturer;
        private Label lbCarName;
        private Label lbPrice;
        private Label lbReleaseYear;
        private Label lbCarID;
        private Label lbManufacturer;
        private TextBox txtReleaseYear;
        private TextBox txtCarName;
        private TextBox txtCarID;
        private TextBox txtPrice;
        private Button btnLoad;
        private Button btnNew;
        private Button btnDelete;
        private DataGridView dgvCarList;
        private Button btnClose;
    }
}