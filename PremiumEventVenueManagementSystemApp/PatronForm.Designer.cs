namespace PremiumEventVenueManagementSystemApp
{
    partial class PatronForm
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
            this.lblPatronID = new System.Windows.Forms.Label();
            this.lblFirst = new System.Windows.Forms.Label();
            this.lblLast = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblReg = new System.Windows.Forms.Label();
            this.txtPatronID = new System.Windows.Forms.TextBox();
            this.txtFirst = new System.Windows.Forms.TextBox();
            this.txtLast = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dtpRegistration = new System.Windows.Forms.DateTimePicker();
            this.txtPatronSearch = new System.Windows.Forms.TextBox();
            this.lblPatronSearch = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoadPatrons = new System.Windows.Forms.Button();
            this.btnSearchPatron = new System.Windows.Forms.Button();
            this.dgvPatrons = new System.Windows.Forms.DataGridView();
            this.lblPhones = new System.Windows.Forms.Label();
            this.lblPhoneID = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneID = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.btnPhoneInsert = new System.Windows.Forms.Button();
            this.btnPhoneUpdate = new System.Windows.Forms.Button();
            this.btnPhoneDelete = new System.Windows.Forms.Button();
            this.btnPhoneClear = new System.Windows.Forms.Button();
            this.btnPhoneReload = new System.Windows.Forms.Button();
            this.dgvPhones = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrons)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(18, 12);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(248, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Patron Management";
            // 
            // lblPatronID
            // 
            this.lblPatronID.AutoSize = true;
            this.lblPatronID.Location = new System.Drawing.Point(20, 60);
            this.lblPatronID.Name = "lblPatronID";
            this.lblPatronID.Size = new System.Drawing.Size(66, 15);
            this.lblPatronID.TabIndex = 1;
            this.lblPatronID.Text = "Patron ID";
            // 
            // lblFirst
            // 
            this.lblFirst.AutoSize = true;
            this.lblFirst.Location = new System.Drawing.Point(20, 93);
            this.lblFirst.Name = "lblFirst";
            this.lblFirst.Size = new System.Drawing.Size(67, 15);
            this.lblFirst.TabIndex = 2;
            this.lblFirst.Text = "First Name";
            // 
            // lblLast
            // 
            this.lblLast.AutoSize = true;
            this.lblLast.Location = new System.Drawing.Point(20, 126);
            this.lblLast.Name = "lblLast";
            this.lblLast.Size = new System.Drawing.Size(66, 15);
            this.lblLast.TabIndex = 3;
            this.lblLast.Text = "Last Name";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(320, 60);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(41, 15);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Email";
            // 
            // lblReg
            // 
            this.lblReg.AutoSize = true;
            this.lblReg.Location = new System.Drawing.Point(320, 93);
            this.lblReg.Name = "lblReg";
            this.lblReg.Size = new System.Drawing.Size(110, 15);
            this.lblReg.TabIndex = 5;
            this.lblReg.Text = "Registration Date";
            // 
            // txtPatronID
            // 
            this.txtPatronID.Location = new System.Drawing.Point(130, 57);
            this.txtPatronID.Name = "txtPatronID";
            this.txtPatronID.ReadOnly = true;
            this.txtPatronID.Size = new System.Drawing.Size(160, 23);
            this.txtPatronID.TabIndex = 6;
            // 
            // txtFirst
            // 
            this.txtFirst.Location = new System.Drawing.Point(130, 90);
            this.txtFirst.Name = "txtFirst";
            this.txtFirst.Size = new System.Drawing.Size(160, 23);
            this.txtFirst.TabIndex = 7;
            // 
            // txtLast
            // 
            this.txtLast.Location = new System.Drawing.Point(130, 123);
            this.txtLast.Name = "txtLast";
            this.txtLast.Size = new System.Drawing.Size(160, 23);
            this.txtLast.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(450, 57);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(260, 23);
            this.txtEmail.TabIndex = 9;
            // 
            // dtpRegistration
            // 
            this.dtpRegistration.Location = new System.Drawing.Point(450, 87);
            this.dtpRegistration.Name = "dtpRegistration";
            this.dtpRegistration.Size = new System.Drawing.Size(260, 23);
            this.dtpRegistration.TabIndex = 10;
            // 
            // txtPatronSearch
            // 
            this.txtPatronSearch.Location = new System.Drawing.Point(130, 158);
            this.txtPatronSearch.Name = "txtPatronSearch";
            this.txtPatronSearch.Size = new System.Drawing.Size(400, 23);
            this.txtPatronSearch.TabIndex = 11;
            // 
            // lblPatronSearch
            // 
            this.lblPatronSearch.AutoSize = true;
            this.lblPatronSearch.Location = new System.Drawing.Point(20, 161);
            this.lblPatronSearch.Name = "lblPatronSearch";
            this.lblPatronSearch.Size = new System.Drawing.Size(45, 15);
            this.lblPatronSearch.TabIndex = 12;
            this.lblPatronSearch.Text = "Search";
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(20, 196);
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
            this.btnUpdate.Location = new System.Drawing.Point(120, 196);
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
            this.btnDelete.Location = new System.Drawing.Point(220, 196);
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
            this.btnClear.Location = new System.Drawing.Point(320, 196);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(90, 34);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoadPatrons
            // 
            this.btnLoadPatrons.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadPatrons.ForeColor = System.Drawing.Color.White;
            this.btnLoadPatrons.Location = new System.Drawing.Point(420, 196);
            this.btnLoadPatrons.Name = "btnLoadPatrons";
            this.btnLoadPatrons.Size = new System.Drawing.Size(90, 34);
            this.btnLoadPatrons.TabIndex = 17;
            this.btnLoadPatrons.Text = "Load";
            this.btnLoadPatrons.UseVisualStyleBackColor = false;
            this.btnLoadPatrons.Click += new System.EventHandler(this.btnLoadPatrons_Click);
            // 
            // btnSearchPatron
            // 
            this.btnSearchPatron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchPatron.ForeColor = System.Drawing.Color.White;
            this.btnSearchPatron.Location = new System.Drawing.Point(520, 196);
            this.btnSearchPatron.Name = "btnSearchPatron";
            this.btnSearchPatron.Size = new System.Drawing.Size(90, 34);
            this.btnSearchPatron.TabIndex = 18;
            this.btnSearchPatron.Text = "Search";
            this.btnSearchPatron.UseVisualStyleBackColor = false;
            this.btnSearchPatron.Click += new System.EventHandler(this.btnSearchPatron_Click);
            // 
            // dgvPatrons
            // 
            this.dgvPatrons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPatrons.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPatrons.Location = new System.Drawing.Point(18, 244);
            this.dgvPatrons.Name = "dgvPatrons";
            this.dgvPatrons.Size = new System.Drawing.Size(1110, 200);
            this.dgvPatrons.TabIndex = 19;
            this.dgvPatrons.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPatrons_CellClick);
            // 
            // lblPhones
            // 
            this.lblPhones.AutoSize = true;
            this.lblPhones.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPhones.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblPhones.Location = new System.Drawing.Point(18, 456);
            this.lblPhones.Name = "lblPhones";
            this.lblPhones.Size = new System.Drawing.Size(128, 25);
            this.lblPhones.TabIndex = 20;
            this.lblPhones.Text = "Patron Phone";
            // 
            // lblPhoneID
            // 
            this.lblPhoneID.AutoSize = true;
            this.lblPhoneID.Location = new System.Drawing.Point(18, 496);
            this.lblPhoneID.Name = "lblPhoneID";
            this.lblPhoneID.Size = new System.Drawing.Size(56, 15);
            this.lblPhoneID.TabIndex = 21;
            this.lblPhoneID.Text = "Phone ID";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Location = new System.Drawing.Point(220, 496);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(48, 15);
            this.lblPhoneNumber.TabIndex = 22;
            this.lblPhoneNumber.Text = "Phone #";
            // 
            // txtPhoneID
            // 
            this.txtPhoneID.Location = new System.Drawing.Point(100, 493);
            this.txtPhoneID.Name = "txtPhoneID";
            this.txtPhoneID.ReadOnly = true;
            this.txtPhoneID.Size = new System.Drawing.Size(90, 23);
            this.txtPhoneID.TabIndex = 23;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(300, 493);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(200, 23);
            this.txtPhoneNumber.TabIndex = 24;
            // 
            // btnPhoneInsert
            // 
            this.btnPhoneInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoneInsert.ForeColor = System.Drawing.Color.White;
            this.btnPhoneInsert.Location = new System.Drawing.Point(520, 489);
            this.btnPhoneInsert.Name = "btnPhoneInsert";
            this.btnPhoneInsert.Size = new System.Drawing.Size(80, 28);
            this.btnPhoneInsert.TabIndex = 25;
            this.btnPhoneInsert.Text = "Add";
            this.btnPhoneInsert.UseVisualStyleBackColor = false;
            this.btnPhoneInsert.Click += new System.EventHandler(this.btnPhoneInsert_Click);
            // 
            // btnPhoneUpdate
            // 
            this.btnPhoneUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoneUpdate.ForeColor = System.Drawing.Color.White;
            this.btnPhoneUpdate.Location = new System.Drawing.Point(610, 489);
            this.btnPhoneUpdate.Name = "btnPhoneUpdate";
            this.btnPhoneUpdate.Size = new System.Drawing.Size(80, 28);
            this.btnPhoneUpdate.TabIndex = 26;
            this.btnPhoneUpdate.Text = "Save";
            this.btnPhoneUpdate.UseVisualStyleBackColor = false;
            this.btnPhoneUpdate.Click += new System.EventHandler(this.btnPhoneUpdate_Click);
            // 
            // btnPhoneDelete
            // 
            this.btnPhoneDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoneDelete.ForeColor = System.Drawing.Color.White;
            this.btnPhoneDelete.Location = new System.Drawing.Point(700, 489);
            this.btnPhoneDelete.Name = "btnPhoneDelete";
            this.btnPhoneDelete.Size = new System.Drawing.Size(80, 28);
            this.btnPhoneDelete.TabIndex = 27;
            this.btnPhoneDelete.Text = "Del";
            this.btnPhoneDelete.UseVisualStyleBackColor = false;
            this.btnPhoneDelete.Click += new System.EventHandler(this.btnPhoneDelete_Click);
            // 
            // btnPhoneClear
            // 
            this.btnPhoneClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoneClear.ForeColor = System.Drawing.Color.White;
            this.btnPhoneClear.Location = new System.Drawing.Point(790, 489);
            this.btnPhoneClear.Name = "btnPhoneClear";
            this.btnPhoneClear.Size = new System.Drawing.Size(80, 28);
            this.btnPhoneClear.TabIndex = 28;
            this.btnPhoneClear.Text = "Clear";
            this.btnPhoneClear.UseVisualStyleBackColor = false;
            this.btnPhoneClear.Click += new System.EventHandler(this.btnPhoneClear_Click);
            // 
            // btnPhoneReload
            // 
            this.btnPhoneReload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPhoneReload.ForeColor = System.Drawing.Color.White;
            this.btnPhoneReload.Location = new System.Drawing.Point(880, 489);
            this.btnPhoneReload.Name = "btnPhoneReload";
            this.btnPhoneReload.Size = new System.Drawing.Size(80, 28);
            this.btnPhoneReload.TabIndex = 29;
            this.btnPhoneReload.Text = "Reload";
            this.btnPhoneReload.UseVisualStyleBackColor = false;
            this.btnPhoneReload.Click += new System.EventHandler(this.btnPhoneReload_Click);
            // 
            // dgvPhones
            // 
            this.dgvPhones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPhones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhones.Location = new System.Drawing.Point(18, 532);
            this.dgvPhones.Name = "dgvPhones";
            this.dgvPhones.Size = new System.Drawing.Size(1110, 180);
            this.dgvPhones.TabIndex = 30;
            this.dgvPhones.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPhones_CellClick);
            // 
            // PatronForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1148, 730);
            this.Controls.Add(this.dgvPhones);
            this.Controls.Add(this.btnPhoneReload);
            this.Controls.Add(this.btnPhoneClear);
            this.Controls.Add(this.btnPhoneDelete);
            this.Controls.Add(this.btnPhoneUpdate);
            this.Controls.Add(this.btnPhoneInsert);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtPhoneID);
            this.Controls.Add(this.lblPhoneNumber);
            this.Controls.Add(this.lblPhoneID);
            this.Controls.Add(this.lblPhones);
            this.Controls.Add(this.dgvPatrons);
            this.Controls.Add(this.btnSearchPatron);
            this.Controls.Add(this.btnLoadPatrons);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.lblPatronSearch);
            this.Controls.Add(this.txtPatronSearch);
            this.Controls.Add(this.dtpRegistration);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtLast);
            this.Controls.Add(this.txtFirst);
            this.Controls.Add(this.txtPatronID);
            this.Controls.Add(this.lblReg);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblLast);
            this.Controls.Add(this.lblFirst);
            this.Controls.Add(this.lblPatronID);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "PatronForm";
            this.Text = "Patrons";
            this.Load += new System.EventHandler(this.PatronForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPatrons)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhones)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblPatronID;
        private System.Windows.Forms.Label lblFirst;
        private System.Windows.Forms.Label lblLast;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblReg;
        private System.Windows.Forms.TextBox txtPatronID;
        private System.Windows.Forms.TextBox txtFirst;
        private System.Windows.Forms.TextBox txtLast;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DateTimePicker dtpRegistration;
        private System.Windows.Forms.TextBox txtPatronSearch;
        private System.Windows.Forms.Label lblPatronSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoadPatrons;
        private System.Windows.Forms.Button btnSearchPatron;
        private System.Windows.Forms.DataGridView dgvPatrons;
        private System.Windows.Forms.Label lblPhones;
        private System.Windows.Forms.Label lblPhoneID;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtPhoneID;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.Button btnPhoneInsert;
        private System.Windows.Forms.Button btnPhoneUpdate;
        private System.Windows.Forms.Button btnPhoneDelete;
        private System.Windows.Forms.Button btnPhoneClear;
        private System.Windows.Forms.Button btnPhoneReload;
        private System.Windows.Forms.DataGridView dgvPhones;
    }
}
