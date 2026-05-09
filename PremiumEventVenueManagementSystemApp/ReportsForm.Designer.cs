namespace PremiumEventVenueManagementSystemApp
{
    partial class ReportsForm
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
            this.lblReportHint = new System.Windows.Forms.Label();
            this.btnVip = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnAttendance = new System.Windows.Forms.Button();
            this.btnVenueUsage = new System.Windows.Forms.Button();
            this.btnGatheringStaff = new System.Windows.Forms.Button();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHeading
            // 
            this.lblHeading.AutoSize = true;
            this.lblHeading.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblHeading.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblHeading.Location = new System.Drawing.Point(24, 16);
            this.lblHeading.Name = "lblHeading";
            this.lblHeading.Size = new System.Drawing.Size(103, 32);
            this.lblHeading.TabIndex = 0;
            this.lblHeading.Text = "Reports";
            // 
            // lblReportHint
            // 
            this.lblReportHint.AutoSize = true;
            this.lblReportHint.ForeColor = System.Drawing.Color.Gray;
            this.lblReportHint.Location = new System.Drawing.Point(24, 54);
            this.lblReportHint.Name = "lblReportHint";
            this.lblReportHint.Size = new System.Drawing.Size(536, 15);
            this.lblReportHint.TabIndex = 1;
            this.lblReportHint.Text = "Each button runs a fixed read-only JOIN query suited for your relational schema.";
            // 
            // btnVip
            // 
            this.btnVip.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVip.ForeColor = System.Drawing.Color.White;
            this.btnVip.Location = new System.Drawing.Point(26, 90);
            this.btnVip.Name = "btnVip";
            this.btnVip.Size = new System.Drawing.Size(208, 40);
            this.btnVip.TabIndex = 2;
            this.btnVip.Text = "VIP Customers";
            this.btnVip.UseVisualStyleBackColor = false;
            this.btnVip.Click += new System.EventHandler(this.btnVip_Click);
            // 
            // btnRevenue
            // 
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.ForeColor = System.Drawing.Color.White;
            this.btnRevenue.Location = new System.Drawing.Point(252, 90);
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Size = new System.Drawing.Size(206, 40);
            this.btnRevenue.TabIndex = 3;
            this.btnRevenue.Text = "Revenue Report";
            this.btnRevenue.UseVisualStyleBackColor = false;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);
            // 
            // btnAttendance
            // 
            this.btnAttendance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttendance.ForeColor = System.Drawing.Color.White;
            this.btnAttendance.Location = new System.Drawing.Point(476, 90);
            this.btnAttendance.Name = "btnAttendance";
            this.btnAttendance.Size = new System.Drawing.Size(206, 40);
            this.btnAttendance.TabIndex = 4;
            this.btnAttendance.Text = "Event Attendance";
            this.btnAttendance.UseVisualStyleBackColor = false;
            this.btnAttendance.Click += new System.EventHandler(this.btnAttendance_Click);
            // 
            // btnVenueUsage
            // 
            this.btnVenueUsage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenueUsage.ForeColor = System.Drawing.Color.White;
            this.btnVenueUsage.Location = new System.Drawing.Point(700, 90);
            this.btnVenueUsage.Name = "btnVenueUsage";
            this.btnVenueUsage.Size = new System.Drawing.Size(206, 40);
            this.btnVenueUsage.TabIndex = 5;
            this.btnVenueUsage.Text = "Venue Usage";
            this.btnVenueUsage.UseVisualStyleBackColor = false;
            this.btnVenueUsage.Click += new System.EventHandler(this.btnVenueUsage_Click);
            // 
            // btnGatheringStaff
            // 
            this.btnGatheringStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGatheringStaff.ForeColor = System.Drawing.Color.White;
            this.btnGatheringStaff.Location = new System.Drawing.Point(926, 90);
            this.btnGatheringStaff.Name = "btnGatheringStaff";
            this.btnGatheringStaff.Size = new System.Drawing.Size(206, 40);
            this.btnGatheringStaff.TabIndex = 6;
            this.btnGatheringStaff.Text = "Gathering Staff";
            this.btnGatheringStaff.UseVisualStyleBackColor = false;
            this.btnGatheringStaff.Click += new System.EventHandler(this.btnGatheringStaff_Click);
            // 
            // dgvReports
            // 
            this.dgvReports.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Location = new System.Drawing.Point(24, 150);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.Size = new System.Drawing.Size(1106, 480);
            this.dgvReports.TabIndex = 7;
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1148, 658);
            this.Controls.Add(this.dgvReports);
            this.Controls.Add(this.btnGatheringStaff);
            this.Controls.Add(this.btnVenueUsage);
            this.Controls.Add(this.btnAttendance);
            this.Controls.Add(this.btnRevenue);
            this.Controls.Add(this.btnVip);
            this.Controls.Add(this.lblReportHint);
            this.Controls.Add(this.lblHeading);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "ReportsForm";
            this.Text = "Reports";
            this.Load += new System.EventHandler(this.ReportsForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblHeading;
        private System.Windows.Forms.Label lblReportHint;
        private System.Windows.Forms.Button btnVip;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnAttendance;
        private System.Windows.Forms.Button btnVenueUsage;
        private System.Windows.Forms.Button btnGatheringStaff;
        private System.Windows.Forms.DataGridView dgvReports;
    }
}
