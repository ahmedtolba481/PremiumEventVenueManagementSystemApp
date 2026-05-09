namespace PremiumEventVenueManagementSystemApp
{
    partial class TechnicalStaffForm
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
            this.lblStaffID = new System.Windows.Forms.Label();
            this.lblSupervisor = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblYears = new System.Windows.Forms.Label();
            this.txtStaffID = new System.Windows.Forms.TextBox();
            this.cmbSupervisor = new System.Windows.Forms.ComboBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.numYears = new System.Windows.Forms.NumericUpDown();
            this.lblStaffSearch = new System.Windows.Forms.Label();
            this.txtStaffSearch = new System.Windows.Forms.TextBox();
            this.btnInsertStaff = new System.Windows.Forms.Button();
            this.btnUpdateStaff = new System.Windows.Forms.Button();
            this.btnDeleteStaff = new System.Windows.Forms.Button();
            this.btnClearStaff = new System.Windows.Forms.Button();
            this.btnLoadStaff = new System.Windows.Forms.Button();
            this.btnSearchStaff = new System.Windows.Forms.Button();
            this.dgvStaff = new System.Windows.Forms.DataGridView();
            this.lblConduct = new System.Windows.Forms.Label();
            this.lblConductID = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtConductID = new System.Windows.Forms.TextBox();
            this.txtConductPhone = new System.Windows.Forms.TextBox();
            this.txtConductEmail = new System.Windows.Forms.TextBox();
            this.btnConductInsert = new System.Windows.Forms.Button();
            this.btnConductUpdate = new System.Windows.Forms.Button();
            this.btnConductDelete = new System.Windows.Forms.Button();
            this.btnConductClear = new System.Windows.Forms.Button();
            this.btnConductReload = new System.Windows.Forms.Button();
            this.dgvConduct = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduct)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(20, 10);
            this.lblHeading.Size = new System.Drawing.Size(198, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Technical Staff";
            // 
            // lblStaffID
            // 
            this.lblStaffID.AutoSize = true;
            this.lblStaffID.Location = new System.Drawing.Point(22, 60);
            this.lblStaffID.Name = "lblStaffID";
            this.lblStaffID.Size = new System.Drawing.Size(53, 15);
            this.lblStaffID.TabIndex = 1;
            this.lblStaffID.Text = "Staff ID";
            // 
            // lblSupervisor
            // 
            this.lblSupervisor.AutoSize = true;
            this.lblSupervisor.Location = new System.Drawing.Point(360, 60);
            this.lblSupervisor.Name = "lblSupervisor";
            this.lblSupervisor.Size = new System.Drawing.Size(70, 15);
            this.lblSupervisor.TabIndex = 2;
            this.lblSupervisor.Text = "Supervisor";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(22, 95);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(67, 15);
            this.lblFirst.TabIndex = 3;
            this.lblFirst.Text = "First Name";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(360, 95);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(66, 15);
            this.lblLast.TabIndex = 4;
            this.lblLast.Text = "Last Name";
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Location = new System.Drawing.Point(22, 130);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(31, 15);
            this.lblRole.TabIndex = 5;
            this.lblRole.Text = "Role";
            // 
            // lblYears
            // 
            this.lblYears.AutoSize = true;
            this.lblYears.Location = new System.Drawing.Point(360, 130);
            this.lblYears.Name = "lblYears";
            this.lblYears.Size = new System.Drawing.Size(99, 15);
            this.lblYears.TabIndex = 6;
            this.lblYears.Text = "Experience years";
            // 
            // txtStaffID
            // 
            this.txtStaffID.Location = new System.Drawing.Point(142, 57);
            this.txtStaffID.Name = "txtStaffID";
            this.txtStaffID.ReadOnly = true;
            this.txtStaffID.Size = new System.Drawing.Size(180, 23);
            this.txtStaffID.TabIndex = 7;
            // 
            // cmbSupervisor
            // 
            this.cmbSupervisor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSupervisor.FormattingEnabled = true;
            this.cmbSupervisor.Location = new System.Drawing.Point(470, 57);
            this.cmbSupervisor.Name = "cmbSupervisor";
            this.cmbSupervisor.Size = new System.Drawing.Size(300, 23);
            this.cmbSupervisor.TabIndex = 8;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(142, 92);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(180, 23);
            this.txtFirst.TabIndex = 9;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(470, 92);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(300, 23);
            this.txtLast.TabIndex = 10;
            // 
            // txtRole
            // 
            this.txtRole.Location = new System.Drawing.Point(142, 127);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(180, 23);
            this.txtRole.TabIndex = 11;
            // 
            // numYears
            // 
            this.numYears.Location = new System.Drawing.Point(470, 128);
            this.numYears.Maximum = new decimal(new int[] { 120, 0, 0, 0 });
            this.numYears.Name = "numYears";
            this.numYears.Size = new System.Drawing.Size(120, 23);
            this.numYears.TabIndex = 12;
            // 
            // lblStaffSearch
            // 
            this.lblStaffSearch.AutoSize = true;
            this.lblStaffSearch.Location = new System.Drawing.Point(22, 165);
            this.lblStaffSearch.Name = "lblStaffSearch";
            this.lblStaffSearch.Size = new System.Drawing.Size(45, 15);
            this.lblStaffSearch.TabIndex = 13;
            this.lblStaffSearch.Text = "Search";
            // 
            // txtStaffSearch
            // 
            this.txtStaffSearch.Location = new System.Drawing.Point(142, 162);
            this.txtStaffSearch.Name = "txtStaffSearch";
            this.txtStaffSearch.Size = new System.Drawing.Size(448, 23);
            this.txtStaffSearch.TabIndex = 14;
            // 
            // btnInsertStaff
            // 
            this.btnInsertStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertStaff.ForeColor = System.Drawing.Color.White;
            this.btnInsertStaff.Location = new System.Drawing.Point(22, 199);
            this.btnInsertStaff.Name = "btnInsertStaff";
            this.btnInsertStaff.Size = new System.Drawing.Size(82, 32);
            this.btnInsertStaff.TabIndex = 15;
            this.btnInsertStaff.Text = "Insert";
            this.btnInsertStaff.UseVisualStyleBackColor = false;
            this.btnInsertStaff.Click += new System.EventHandler(this.btnInsertStaff_Click);
            // 
            // btnUpdateStaff
            // 
            this.btnUpdateStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdateStaff.ForeColor = System.Drawing.Color.White;
            this.btnUpdateStaff.Location = new System.Drawing.Point(116, 199);
            this.btnUpdateStaff.Name = "btnUpdateStaff";
            this.btnUpdateStaff.Size = new System.Drawing.Size(82, 32);
            this.btnUpdateStaff.TabIndex = 16;
            this.btnUpdateStaff.Text = "Update";
            this.btnUpdateStaff.UseVisualStyleBackColor = false;
            this.btnUpdateStaff.Click += new System.EventHandler(this.btnUpdateStaff_Click);
            // 
            // btnDeleteStaff
            // 
            this.btnDeleteStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteStaff.ForeColor = System.Drawing.Color.White;
            this.btnDeleteStaff.Location = new System.Drawing.Point(210, 199);
            this.btnDeleteStaff.Name = "btnDeleteStaff";
            this.btnDeleteStaff.Size = new System.Drawing.Size(82, 32);
            this.btnDeleteStaff.TabIndex = 17;
            this.btnDeleteStaff.Text = "Delete";
            this.btnDeleteStaff.UseVisualStyleBackColor = false;
            this.btnDeleteStaff.Click += new System.EventHandler(this.btnDeleteStaff_Click);
            // 
            // btnClearStaff
            // 
            this.btnClearStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearStaff.ForeColor = System.Drawing.Color.White;
            this.btnClearStaff.Location = new System.Drawing.Point(304, 199);
            this.btnClearStaff.Name = "btnClearStaff";
            this.btnClearStaff.Size = new System.Drawing.Size(82, 32);
            this.btnClearStaff.TabIndex = 18;
            this.btnClearStaff.Text = "Clear";
            this.btnClearStaff.UseVisualStyleBackColor = false;
            this.btnClearStaff.Click += new System.EventHandler(this.btnClearStaff_Click);
            // 
            // btnLoadStaff
            // 
            this.btnLoadStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadStaff.ForeColor = System.Drawing.Color.White;
            this.btnLoadStaff.Location = new System.Drawing.Point(398, 199);
            this.btnLoadStaff.Name = "btnLoadStaff";
            this.btnLoadStaff.Size = new System.Drawing.Size(82, 32);
            this.btnLoadStaff.TabIndex = 19;
            this.btnLoadStaff.Text = "Load";
            this.btnLoadStaff.UseVisualStyleBackColor = false;
            this.btnLoadStaff.Click += new System.EventHandler(this.btnLoadStaff_Click);
            // 
            // btnSearchStaff
            // 
            this.btnSearchStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchStaff.ForeColor = System.Drawing.Color.White;
            this.btnSearchStaff.Location = new System.Drawing.Point(492, 199);
            this.btnSearchStaff.Name = "btnSearchStaff";
            this.btnSearchStaff.Size = new System.Drawing.Size(82, 32);
            this.btnSearchStaff.TabIndex = 20;
            this.btnSearchStaff.Text = "Search";
            this.btnSearchStaff.UseVisualStyleBackColor = false;
            this.btnSearchStaff.Click += new System.EventHandler(this.btnSearchStaff_Click);
            // 
            // dgvStaff
            // 
            this.dgvStaff.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStaff.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaff.Location = new System.Drawing.Point(22, 244);
            this.dgvStaff.Name = "dgvStaff";
            this.dgvStaff.Size = new System.Drawing.Size(1106, 200);
            this.dgvStaff.TabIndex = 21;
            this.dgvStaff.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStaff_CellClick);
            // 
            // lblConduct
            // 
            this.lblConduct.AutoSize = true;
            this.lblConduct.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblConduct.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblConduct.Location = new System.Drawing.Point(22, 456);
            this.lblConduct.Name = "lblConduct";
            this.lblConduct.Size = new System.Drawing.Size(182, 25);
            this.lblConduct.TabIndex = 22;
            this.lblConduct.Text = "Staff Conduct (CRM)";
            // 
            // lblConductID
            // 
            this.lblConductID.AutoSize = true;
            this.lblConductID.Location = new System.Drawing.Point(22, 498);
            this.lblConductID.Name = "lblConductID";
            this.lblConductID.Size = new System.Drawing.Size(67, 15);
            this.lblConductID.TabIndex = 23;
            this.lblConductID.Text = "Conduct ID";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(242, 498);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(41, 15);
            this.lblPhone.TabIndex = 24;
            this.lblPhone.Text = "Phone";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(520, 498);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(36, 15);
            this.lblEmail.TabIndex = 25;
            this.lblEmail.Text = "Email";
            // 
            // txtConductID
            // 
            this.txtConductID.Location = new System.Drawing.Point(120, 494);
            this.txtConductID.Name = "txtConductID";
            this.txtConductID.ReadOnly = true;
            this.txtConductID.Size = new System.Drawing.Size(100, 23);
            this.txtConductID.TabIndex = 26;
            // 
            // txtConductPhone
            // 
            this.txtConductPhone.Location = new System.Drawing.Point(297, 495);
            this.txtConductPhone.Name = "txtConductPhone";
            this.txtConductPhone.Size = new System.Drawing.Size(200, 23);
            this.txtConductPhone.TabIndex = 27;
            // 
            // txtConductEmail
            // 
            this.txtConductEmail.Location = new System.Drawing.Point(582, 495);
            this.txtConductEmail.Name = "txtConductEmail";
            this.txtConductEmail.Size = new System.Drawing.Size(220, 23);
            this.txtConductEmail.TabIndex = 28;
            // 
            // btnConductInsert
            // 
            this.btnConductInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductInsert.ForeColor = System.Drawing.Color.White;
            this.btnConductInsert.Location = new System.Drawing.Point(834, 494);
            this.btnConductInsert.Name = "btnConductInsert";
            this.btnConductInsert.Size = new System.Drawing.Size(70, 26);
            this.btnConductInsert.TabIndex = 29;
            this.btnConductInsert.Text = "Add";
            this.btnConductInsert.UseVisualStyleBackColor = false;
            this.btnConductInsert.Click += new System.EventHandler(this.btnConductInsert_Click);
            // 
            // btnConductUpdate
            // 
            this.btnConductUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductUpdate.ForeColor = System.Drawing.Color.White;
            this.btnConductUpdate.Location = new System.Drawing.Point(912, 494);
            this.btnConductUpdate.Name = "btnConductUpdate";
            this.btnConductUpdate.Size = new System.Drawing.Size(70, 26);
            this.btnConductUpdate.TabIndex = 30;
            this.btnConductUpdate.Text = "Save";
            this.btnConductUpdate.UseVisualStyleBackColor = false;
            this.btnConductUpdate.Click += new System.EventHandler(this.btnConductUpdate_Click);
            // 
            // btnConductDelete
            // 
            this.btnConductDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductDelete.ForeColor = System.Drawing.Color.White;
            this.btnConductDelete.Location = new System.Drawing.Point(990, 494);
            this.btnConductDelete.Name = "btnConductDelete";
            this.btnConductDelete.Size = new System.Drawing.Size(60, 26);
            this.btnConductDelete.TabIndex = 31;
            this.btnConductDelete.Text = "Del";
            this.btnConductDelete.UseVisualStyleBackColor = false;
            this.btnConductDelete.Click += new System.EventHandler(this.btnConductDelete_Click);
            // 
            // btnConductClear
            // 
            this.btnConductClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductClear.ForeColor = System.Drawing.Color.White;
            this.btnConductClear.Location = new System.Drawing.Point(834, 528);
            this.btnConductClear.Name = "btnConductClear";
            this.btnConductClear.Size = new System.Drawing.Size(70, 26);
            this.btnConductClear.TabIndex = 32;
            this.btnConductClear.Text = "Clr";
            this.btnConductClear.UseVisualStyleBackColor = false;
            this.btnConductClear.Click += new System.EventHandler(this.btnConductClear_Click);
            // 
            // btnConductReload
            // 
            this.btnConductReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConductReload.ForeColor = System.Drawing.Color.White;
            this.btnConductReload.Location = new System.Drawing.Point(914, 528);
            this.btnConductReload.Name = "btnConductReload";
            this.btnConductReload.Size = new System.Drawing.Size(90, 26);
            this.btnConductReload.TabIndex = 33;
            this.btnConductReload.Text = "Reload";
            this.btnConductReload.UseVisualStyleBackColor = false;
            this.btnConductReload.Click += new System.EventHandler(this.btnConductReload_Click);
            // 
            // dgvConduct
            // 
            this.dgvConduct.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConduct.Location = new System.Drawing.Point(22, 568);
            this.dgvConduct.Name = "dgvConduct";
            this.dgvConduct.Size = new System.Drawing.Size(1106, 160);
            this.dgvConduct.TabIndex = 34;
            this.dgvConduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConduct_CellClick);
            // 
            // TechnicalStaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1148, 744);
            this.Controls.Add(this.dgvConduct);
            this.Controls.Add(this.btnConductReload);
            this.Controls.Add(this.btnConductClear);
            this.Controls.Add(this.btnConductDelete);
            this.Controls.Add(this.btnConductUpdate);
            this.Controls.Add(this.btnConductInsert);
            this.Controls.Add(this.txtConductEmail);
            this.Controls.Add(this.txtConductPhone);
            this.Controls.Add(this.txtConductID);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblConductID);
            this.Controls.Add(this.lblConduct);
            this.Controls.Add(this.dgvStaff);
            this.Controls.Add(this.btnSearchStaff);
            this.Controls.Add(this.btnLoadStaff);
            this.Controls.Add(this.btnClearStaff);
            this.Controls.Add(this.btnDeleteStaff);
            this.Controls.Add(this.btnUpdateStaff);
            this.Controls.Add(this.btnInsertStaff);
            this.Controls.Add(this.txtStaffSearch);
            this.Controls.Add(this.lblStaffSearch);
            this.Controls.Add(this.numYears);
            this.Controls.Add(this.lblYears);
            this.Controls.Add(this.txtRole);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.cmbSupervisor);
            this.Controls.Add(this.lblSupervisor);
            this.Controls.Add(this.txtStaffID);
            this.Controls.Add(this.lblStaffID);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "TechnicalStaffForm";
            this.Text = "Technical Staff";
            this.Load += new System.EventHandler(this.TechnicalStaffForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numYears)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblStaffID;
        private System.Windows.Forms.Label lblSupervisor;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblYears;
        private System.Windows.Forms.TextBox txtStaffID;
        private System.Windows.Forms.ComboBox cmbSupervisor;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.NumericUpDown numYears;
        private System.Windows.Forms.Label lblStaffSearch;
        private System.Windows.Forms.TextBox txtStaffSearch;
        private System.Windows.Forms.Button btnInsertStaff;
        private System.Windows.Forms.Button btnUpdateStaff;
        private System.Windows.Forms.Button btnDeleteStaff;
        private System.Windows.Forms.Button btnClearStaff;
        private System.Windows.Forms.Button btnLoadStaff;
        private System.Windows.Forms.Button btnSearchStaff;
        private System.Windows.Forms.DataGridView dgvStaff;
        private System.Windows.Forms.Label lblConduct;
        private System.Windows.Forms.Label lblConductID;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtConductID;
        private System.Windows.Forms.TextBox txtConductPhone;
        private System.Windows.Forms.TextBox txtConductEmail;
        private System.Windows.Forms.Button btnConductInsert;
        private System.Windows.Forms.Button btnConductUpdate;
        private System.Windows.Forms.Button btnConductDelete;
        private System.Windows.Forms.Button btnConductClear;
        private System.Windows.Forms.Button btnConductReload;
        private System.Windows.Forms.DataGridView dgvConduct;
    }
}
