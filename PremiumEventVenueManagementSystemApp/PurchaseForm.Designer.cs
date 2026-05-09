namespace PremiumEventVenueManagementSystemApp
{
    partial class PurchaseForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblHeading = new System.Windows.Forms.Label();
            this.lblPurchaseId = new System.Windows.Forms.Label();
            this.lblPatron = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblPayment = new System.Windows.Forms.Label();
            this.txtPurchaseID = new System.Windows.Forms.TextBox();
            this.cmbPatron = new System.Windows.Forms.ComboBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.cmbPass = new System.Windows.Forms.ComboBox();
            this.dtpPurchase = new System.Windows.Forms.DateTimePicker();
            this.cmbPayment = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvPurchases = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(22, 12);
            this.lblHeading.Size = new System.Drawing.Size(198, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Ticket Purchases";
            // 
            // lblPurchaseId
            // 
            this.lblPurchaseId.AutoSize = true;
            this.lblPurchaseId.Location = new System.Drawing.Point(26, 64);
            this.lblPurchaseId.Name = "lblPurchaseId";
            this.lblPurchaseId.Size = new System.Drawing.Size(72, 15);
            this.lblPurchaseId.TabIndex = 1;
            this.lblPurchaseId.Text = "Key (Patron · Pass · Cat)";
            // 
            // lblPatron
            // 
            this.lblPatron.AutoSize = true;
            this.lblPatron.Location = new System.Drawing.Point(26, 99);
            this.lblPatron.Name = "lblPatron";
            this.lblPatron.Size = new System.Drawing.Size(45, 15);
            this.lblPatron.TabIndex = 2;
            this.lblPatron.Text = "Patron";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(26, 134);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(88, 15);
            this.lblCategory.TabIndex = 3;
            this.lblCategory.Text = "Ticket category";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(450, 64);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(80, 15);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Entry pass ID";
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Location = new System.Drawing.Point(450, 99);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(85, 15);
            this.lblPurchaseDate.TabIndex = 5;
            this.lblPurchaseDate.Text = "Purchase date";
            // 
            // lblPayment
            // 
            this.lblPayment.AutoSize = true;
            this.lblPayment.Location = new System.Drawing.Point(450, 134);
            this.lblPayment.Name = "lblPayment";
            this.lblPayment.Size = new System.Drawing.Size(97, 15);
            this.lblPayment.TabIndex = 6;
            this.lblPayment.Text = "Payment method";
            // 
            // txtPurchaseID
            // 
            this.txtPurchaseID.Location = new System.Drawing.Point(154, 61);
            this.txtPurchaseID.Name = "txtPurchaseID";
            this.txtPurchaseID.ReadOnly = true;
            this.txtPurchaseID.Size = new System.Drawing.Size(260, 23);
            this.txtPurchaseID.TabIndex = 7;
            // 
            // cmbPatron
            // 
            this.cmbPatron.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPatron.FormattingEnabled = true;
            this.cmbPatron.Location = new System.Drawing.Point(154, 96);
            this.cmbPatron.Name = "cmbPatron";
            this.cmbPatron.Size = new System.Drawing.Size(260, 23);
            this.cmbPatron.TabIndex = 8;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(154, 131);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(260, 23);
            this.cmbCategory.TabIndex = 9;
            this.cmbCategory.SelectionChangeCommitted += new System.EventHandler(this.cmbCategory_SelectionChangeCommitted);
            // 
            // cmbPass
            // 
            this.cmbPass.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPass.FormattingEnabled = true;
            this.cmbPass.Location = new System.Drawing.Point(596, 61);
            this.cmbPass.Name = "cmbPass";
            this.cmbPass.Size = new System.Drawing.Size(220, 23);
            this.cmbPass.TabIndex = 10;
            // 
            // dtpPurchase
            // 
            this.dtpPurchase.Location = new System.Drawing.Point(596, 96);
            this.dtpPurchase.Name = "dtpPurchase";
            this.dtpPurchase.ShowUpDown = false;
            this.dtpPurchase.Size = new System.Drawing.Size(260, 23);
            this.dtpPurchase.TabIndex = 11;
            // 
            // cmbPayment
            // 
            this.cmbPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPayment.FormattingEnabled = true;
            this.cmbPayment.Items.AddRange(new object[] {
            "Cash",
            "Credit Card",
            "Online"});
            this.cmbPayment.Location = new System.Drawing.Point(596, 131);
            this.cmbPayment.Name = "cmbPayment";
            this.cmbPayment.Size = new System.Drawing.Size(220, 23);
            this.cmbPayment.TabIndex = 12;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(26, 173);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 13;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(154, 170);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 23);
            this.txtSearch.TabIndex = 14;
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(26, 210);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 34);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(126, 210);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 34);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(226, 210);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 34);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(326, 210);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 34);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(426, 210);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 34);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(526, 210);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 34);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvPurchases
            // 
            this.dgvPurchases.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPurchases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchases.Location = new System.Drawing.Point(22, 262);
            this.dgvPurchases.Name = "dgvPurchases";
            this.dgvPurchases.Size = new System.Drawing.Size(1108, 362);
            this.dgvPurchases.TabIndex = 21;
            this.dgvPurchases.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchases_CellClick);
            // 
            // PurchaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1148, 646);
            this.Controls.Add(this.dgvPurchases);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmbPayment);
            this.Controls.Add(this.lblPayment);
            this.Controls.Add(this.dtpPurchase);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.cmbPass);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.cmbPatron);
            this.Controls.Add(this.lblPatron);
            this.Controls.Add(this.txtPurchaseID);
            this.Controls.Add(this.lblPurchaseId);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "PurchaseForm";
            this.Text = "Purchases";
            this.Load += new System.EventHandler(this.PurchaseForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblPurchaseId;
        private System.Windows.Forms.Label lblPatron;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblPayment;
        private System.Windows.Forms.TextBox txtPurchaseID;
        private System.Windows.Forms.ComboBox cmbPatron;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.ComboBox cmbPass;
        private System.Windows.Forms.DateTimePicker dtpPurchase;
        private System.Windows.Forms.ComboBox cmbPayment;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvPurchases;
    }
}
