namespace PremiumEventVenueManagementSystemApp
{
    partial class EntryPassForm
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
            this.lblPassId = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.lblQrCode = new System.Windows.Forms.Label();
            this.lblIssueStatus = new System.Windows.Forms.Label();
            this.txtPassID = new System.Windows.Forms.TextBox();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.txtQrCode = new System.Windows.Forms.TextBox();
            this.cmbIssueStatus = new System.Windows.Forms.ComboBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvEntryPasses = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryPasses)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(22, 16);
            this.lblHeading.Size = new System.Drawing.Size(222, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Entry Passes";
            // 
            // lblPassId
            // 
            this.lblPassId.AutoSize = true;
            this.lblPassId.Location = new System.Drawing.Point(24, 68);
            this.lblPassId.Name = "lblPassId";
            this.lblPassId.Size = new System.Drawing.Size(46, 15);
            this.lblPassId.TabIndex = 1;
            this.lblPassId.Text = "Pass ID";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Location = new System.Drawing.Point(24, 102);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(55, 15);
            this.lblCategory.TabIndex = 2;
            this.lblCategory.Text = "Category";
            // 
            // lblQrCode
            // 
            this.lblQrCode.AutoSize = true;
            this.lblQrCode.Location = new System.Drawing.Point(400, 68);
            this.lblQrCode.Name = "lblQrCode";
            this.lblQrCode.Size = new System.Drawing.Size(54, 15);
            this.lblQrCode.TabIndex = 3;
            this.lblQrCode.Text = "QR Code";
            // 
            // lblIssueStatus
            // 
            this.lblIssueStatus.AutoSize = true;
            this.lblIssueStatus.Location = new System.Drawing.Point(400, 102);
            this.lblIssueStatus.Name = "lblIssueStatus";
            this.lblIssueStatus.Size = new System.Drawing.Size(69, 15);
            this.lblIssueStatus.TabIndex = 4;
            this.lblIssueStatus.Text = "Issue Status";
            // 
            // txtPassID
            // 
            this.txtPassID.Location = new System.Drawing.Point(136, 65);
            this.txtPassID.Name = "txtPassID";
            this.txtPassID.ReadOnly = true;
            this.txtPassID.Size = new System.Drawing.Size(220, 23);
            this.txtPassID.TabIndex = 6;
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(136, 99);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(220, 23);
            this.cmbCategory.TabIndex = 7;
            // 
            // txtQrCode
            // 
            this.txtQrCode.Location = new System.Drawing.Point(526, 65);
            this.txtQrCode.Name = "txtQrCode";
            this.txtQrCode.Size = new System.Drawing.Size(240, 23);
            this.txtQrCode.TabIndex = 8;
            // 
            // cmbIssueStatus
            // 
            this.cmbIssueStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIssueStatus.FormattingEnabled = true;
            this.cmbIssueStatus.Location = new System.Drawing.Point(526, 99);
            this.cmbIssueStatus.Name = "cmbIssueStatus";
            this.cmbIssueStatus.Size = new System.Drawing.Size(240, 23);
            this.cmbIssueStatus.TabIndex = 9;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(24, 176);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(45, 15);
            this.lblSearch.TabIndex = 11;
            this.lblSearch.Text = "Search";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(136, 173);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(500, 23);
            this.txtSearch.TabIndex = 12;
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(24, 215);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(90, 34);
            this.btnInsert.TabIndex = 13;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(124, 215);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 34);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(224, 215);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(90, 34);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(324, 215);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 34);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(424, 215);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(90, 34);
            this.btnLoad.TabIndex = 17;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(524, 215);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 34);
            this.btnSearch.TabIndex = 18;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvEntryPasses
            // 
            this.dgvEntryPasses.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvEntryPasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEntryPasses.Location = new System.Drawing.Point(22, 264);
            this.dgvEntryPasses.Name = "dgvEntryPasses";
            this.dgvEntryPasses.Size = new System.Drawing.Size(1108, 352);
            this.dgvEntryPasses.TabIndex = 19;
            this.dgvEntryPasses.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvEntryPasses_CellClick);
            // 
            // EntryPassForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1148, 642);
            this.Controls.Add(this.dgvEntryPasses);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.cmbIssueStatus);
            this.Controls.Add(this.lblIssueStatus);
            this.Controls.Add(this.txtQrCode);
            this.Controls.Add(this.lblQrCode);
            this.Controls.Add(this.cmbCategory);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.txtPassID);
            this.Controls.Add(this.lblPassId);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "EntryPassForm";
            this.Text = "Entry Passes";
            this.Load += new System.EventHandler(this.EntryPassForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEntryPasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblPassId;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblQrCode;
        private System.Windows.Forms.Label lblIssueStatus;
        private System.Windows.Forms.TextBox txtPassID;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.TextBox txtQrCode;
        private System.Windows.Forms.ComboBox cmbIssueStatus;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvEntryPasses;
    }
}
