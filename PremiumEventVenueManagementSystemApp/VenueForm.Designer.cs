namespace PremiumEventVenueManagementSystemApp
{
    partial class VenueForm
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
            this.lblVenueID = new System.Windows.Forms.Label();
            this.lblVenueName = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblCapacity = new System.Windows.Forms.Label();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtVenueID = new System.Windows.Forms.TextBox();
            this.txtVenueName = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.numCapacity = new System.Windows.Forms.NumericUpDown();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dgvVenues = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenues)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(21, 16);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(230, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Venue Management";
            // 
            // lblVenueID
            // 
            this.lblVenueID.AutoSize = true;
            this.lblVenueID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVenueID.Location = new System.Drawing.Point(23, 70);
            this.lblVenueID.Name = "lblVenueID";
            this.lblVenueID.Size = new System.Drawing.Size(68, 19);
            this.lblVenueID.TabIndex = 1;
            this.lblVenueID.Text = "Venue ID";
            // 
            // lblVenueName
            // 
            this.lblVenueName.AutoSize = true;
            this.lblVenueName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblVenueName.Location = new System.Drawing.Point(23, 109);
            this.lblVenueName.Name = "lblVenueName";
            this.lblVenueName.Size = new System.Drawing.Size(88, 19);
            this.lblVenueName.TabIndex = 2;
            this.lblVenueName.Text = "Venue Name";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCity.Location = new System.Drawing.Point(23, 147);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(33, 19);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City";
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblArea.Location = new System.Drawing.Point(392, 70);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(38, 19);
            this.lblArea.TabIndex = 4;
            this.lblArea.Text = "Area";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblStreet.Location = new System.Drawing.Point(392, 109);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(45, 19);
            this.lblStreet.TabIndex = 5;
            this.lblStreet.Text = "Street";
            // 
            // lblCapacity
            // 
            this.lblCapacity.AutoSize = true;
            this.lblCapacity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblCapacity.Location = new System.Drawing.Point(392, 147);
            this.lblCapacity.Name = "lblCapacity";
            this.lblCapacity.Size = new System.Drawing.Size(132, 19);
            this.lblCapacity.TabIndex = 6;
            this.lblCapacity.Text = "Max seating capacity";
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblSearch.Location = new System.Drawing.Point(23, 198);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(51, 19);
            this.lblSearch.TabIndex = 7;
            this.lblSearch.Text = "Search";
            // 
            // txtVenueID
            // 
            this.txtVenueID.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVenueID.Location = new System.Drawing.Point(150, 67);
            this.txtVenueID.Name = "txtVenueID";
            this.txtVenueID.ReadOnly = true;
            this.txtVenueID.Size = new System.Drawing.Size(200, 25);
            this.txtVenueID.TabIndex = 8;
            // 
            // txtVenueName
            // 
            this.txtVenueName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtVenueName.Location = new System.Drawing.Point(150, 106);
            this.txtVenueName.Name = "txtVenueName";
            this.txtVenueName.Size = new System.Drawing.Size(200, 25);
            this.txtVenueName.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtCity.Location = new System.Drawing.Point(150, 144);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(200, 25);
            this.txtCity.TabIndex = 10;
            // 
            // txtArea
            // 
            this.txtArea.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArea.Location = new System.Drawing.Point(550, 67);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(240, 25);
            this.txtArea.TabIndex = 11;
            // 
            // txtStreet
            // 
            this.txtStreet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtStreet.Location = new System.Drawing.Point(550, 106);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(240, 25);
            this.txtStreet.TabIndex = 12;
            // 
            // numCapacity
            // 
            this.numCapacity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.numCapacity.Location = new System.Drawing.Point(550, 145);
            this.numCapacity.Maximum = new decimal(new int[] { 2500000, 0, 0, 0 });
            this.numCapacity.Name = "numCapacity";
            this.numCapacity.Size = new System.Drawing.Size(120, 25);
            this.numCapacity.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(150, 195);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(400, 25);
            this.txtSearch.TabIndex = 14;
            // 
            // btnInsert
            // 
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnInsert.ForeColor = System.Drawing.Color.White;
            this.btnInsert.Location = new System.Drawing.Point(21, 240);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 36);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Location = new System.Drawing.Point(135, 240);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 36);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(249, 240);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 36);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(363, 240);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 36);
            this.btnClear.TabIndex = 18;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoad.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnLoad.ForeColor = System.Drawing.Color.White;
            this.btnLoad.Location = new System.Drawing.Point(477, 240);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(100, 36);
            this.btnLoad.TabIndex = 19;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = false;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(591, 240);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(100, 36);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dgvVenues
            // 
            this.dgvVenues.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenues.Location = new System.Drawing.Point(21, 292);
            this.dgvVenues.Name = "dgvVenues";
            this.dgvVenues.Size = new System.Drawing.Size(1100, 320);
            this.dgvVenues.TabIndex = 21;
            this.dgvVenues.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenues_CellClick);
            // 
            // VenueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1148, 640);
            this.Controls.Add(this.dgvVenues);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.numCapacity);
            this.Controls.Add(this.txtStreet);
            this.Controls.Add(this.txtArea);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtVenueName);
            this.Controls.Add(this.txtVenueID);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.lblCapacity);
            this.Controls.Add(this.lblStreet);
            this.Controls.Add(this.lblArea);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblVenueName);
            this.Controls.Add(this.lblVenueID);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "VenueForm";
            this.Text = "Venues";
            this.Load += new System.EventHandler(this.VenueForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblVenueID;
        private System.Windows.Forms.Label lblVenueName;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblCapacity;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtVenueID;
        private System.Windows.Forms.TextBox txtVenueName;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.NumericUpDown numCapacity;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView dgvVenues;
    }
}
