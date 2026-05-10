namespace PremiumEventVenueManagementSystemApp
{
    partial class DashboardForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSubtitle = new System.Windows.Forms.Label();
            this.pnlPatrons = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lblPatronCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlGatherings = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lblGatheringCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlVenue = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lblVenueCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlStaff = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStaffCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTickets = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.lblTicketCount = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.grpActivity = new System.Windows.Forms.GroupBox();
            this.lstActivity = new System.Windows.Forms.ListBox();
            this.grpQuick = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lblSystemInfo = new System.Windows.Forms.Label();
            this.timerDashboard = new System.Windows.Forms.Timer(this.components);
            this.pnlPatrons.SuspendLayout();
            this.pnlGatherings.SuspendLayout();
            this.pnlVenue.SuspendLayout();
            this.pnlStaff.SuspendLayout();
            this.pnlTickets.SuspendLayout();
            this.grpActivity.SuspendLayout();
            this.grpQuick.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(668, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(334, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dashboard Overview";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSubtitle
            // 
            this.lblSubtitle.AutoSize = true;
            this.lblSubtitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtitle.ForeColor = System.Drawing.Color.Gray;
            this.lblSubtitle.Location = new System.Drawing.Point(502, 72);
            this.lblSubtitle.Name = "lblSubtitle";
            this.lblSubtitle.Size = new System.Drawing.Size(703, 32);
            this.lblSubtitle.TabIndex = 1;
            this.lblSubtitle.Text = "Welcome to the Premium Event & Venue Management System";
            this.lblSubtitle.Click += new System.EventHandler(this.lblSubtitle_Click);
            // 
            // pnlPatrons
            // 
            this.pnlPatrons.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlPatrons.Controls.Add(this.label3);
            this.pnlPatrons.Controls.Add(this.lblPatronCount);
            this.pnlPatrons.Controls.Add(this.label2);
            this.pnlPatrons.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlPatrons.Location = new System.Drawing.Point(17, 165);
            this.pnlPatrons.Name = "pnlPatrons";
            this.pnlPatrons.Size = new System.Drawing.Size(240, 140);
            this.pnlPatrons.TabIndex = 2;
            this.pnlPatrons.Click += new System.EventHandler(this.pnlPatrons_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(55, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total Patrons";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // lblPatronCount
            // 
            this.lblPatronCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblPatronCount.AutoSize = true;
            this.lblPatronCount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPatronCount.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPatronCount.ForeColor = System.Drawing.Color.White;
            this.lblPatronCount.Location = new System.Drawing.Point(93, 38);
            this.lblPatronCount.Name = "lblPatronCount";
            this.lblPatronCount.Size = new System.Drawing.Size(46, 54);
            this.lblPatronCount.TabIndex = 1;
            this.lblPatronCount.Text = "0";
            this.lblPatronCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 51);
            this.label2.TabIndex = 0;
            this.label2.Text = "👤";
            // 
            // pnlGatherings
            // 
            this.pnlGatherings.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlGatherings.Controls.Add(this.label4);
            this.pnlGatherings.Controls.Add(this.lblGatheringCount);
            this.pnlGatherings.Controls.Add(this.label6);
            this.pnlGatherings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlGatherings.Location = new System.Drawing.Point(363, 165);
            this.pnlGatherings.Name = "pnlGatherings";
            this.pnlGatherings.Size = new System.Drawing.Size(240, 140);
            this.pnlGatherings.TabIndex = 3;
            this.pnlGatherings.Click += new System.EventHandler(this.pnlGatherings_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(43, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 25);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Gatherings";
            // 
            // lblGatheringCount
            // 
            this.lblGatheringCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblGatheringCount.AutoSize = true;
            this.lblGatheringCount.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGatheringCount.ForeColor = System.Drawing.Color.White;
            this.lblGatheringCount.Location = new System.Drawing.Point(93, 38);
            this.lblGatheringCount.Name = "lblGatheringCount";
            this.lblGatheringCount.Size = new System.Drawing.Size(46, 54);
            this.lblGatheringCount.TabIndex = 1;
            this.lblGatheringCount.Text = "0";
            this.lblGatheringCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Left;
            this.label6.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 51);
            this.label6.TabIndex = 0;
            this.label6.Text = "🎉";
            // 
            // pnlVenue
            // 
            this.pnlVenue.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlVenue.Controls.Add(this.label5);
            this.pnlVenue.Controls.Add(this.lblVenueCount);
            this.pnlVenue.Controls.Add(this.label8);
            this.pnlVenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlVenue.Location = new System.Drawing.Point(711, 165);
            this.pnlVenue.Name = "pnlVenue";
            this.pnlVenue.Size = new System.Drawing.Size(240, 140);
            this.pnlVenue.TabIndex = 4;
            this.pnlVenue.Click += new System.EventHandler(this.pnlVenue_Click);
            this.pnlVenue.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlVenue_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(58, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 25);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Venues";
            // 
            // lblVenueCount
            // 
            this.lblVenueCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblVenueCount.AutoSize = true;
            this.lblVenueCount.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVenueCount.ForeColor = System.Drawing.Color.White;
            this.lblVenueCount.Location = new System.Drawing.Point(93, 38);
            this.lblVenueCount.Name = "lblVenueCount";
            this.lblVenueCount.Size = new System.Drawing.Size(46, 54);
            this.lblVenueCount.TabIndex = 1;
            this.lblVenueCount.Text = "0";
            this.lblVenueCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Left;
            this.label8.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 51);
            this.label8.TabIndex = 0;
            this.label8.Text = "🏢";
            // 
            // pnlStaff
            // 
            this.pnlStaff.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlStaff.Controls.Add(this.label7);
            this.pnlStaff.Controls.Add(this.lblStaffCount);
            this.pnlStaff.Controls.Add(this.label10);
            this.pnlStaff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlStaff.Location = new System.Drawing.Point(1431, 165);
            this.pnlStaff.Name = "pnlStaff";
            this.pnlStaff.Size = new System.Drawing.Size(240, 140);
            this.pnlStaff.TabIndex = 5;
            this.pnlStaff.Click += new System.EventHandler(this.pnlStaff_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(43, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(139, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Technical Staff";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // lblStaffCount
            // 
            this.lblStaffCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblStaffCount.AutoSize = true;
            this.lblStaffCount.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStaffCount.ForeColor = System.Drawing.Color.White;
            this.lblStaffCount.Location = new System.Drawing.Point(93, 38);
            this.lblStaffCount.Name = "lblStaffCount";
            this.lblStaffCount.Size = new System.Drawing.Size(46, 54);
            this.lblStaffCount.TabIndex = 1;
            this.lblStaffCount.Text = "0";
            this.lblStaffCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Left;
            this.label10.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 51);
            this.label10.TabIndex = 0;
            this.label10.Text = "👥";
            // 
            // pnlTickets
            // 
            this.pnlTickets.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTickets.Controls.Add(this.label11);
            this.pnlTickets.Controls.Add(this.lblTicketCount);
            this.pnlTickets.Controls.Add(this.label13);
            this.pnlTickets.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnlTickets.Location = new System.Drawing.Point(1077, 165);
            this.pnlTickets.Name = "pnlTickets";
            this.pnlTickets.Size = new System.Drawing.Size(240, 140);
            this.pnlTickets.TabIndex = 5;
            this.pnlTickets.Click += new System.EventHandler(this.pnlTickets_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(61, 103);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(150, 25);
            this.label11.TabIndex = 2;
            this.label11.Text = "Ticket purchase";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // lblTicketCount
            // 
            this.lblTicketCount.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblTicketCount.AutoSize = true;
            this.lblTicketCount.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTicketCount.ForeColor = System.Drawing.Color.White;
            this.lblTicketCount.Location = new System.Drawing.Point(93, 38);
            this.lblTicketCount.Name = "lblTicketCount";
            this.lblTicketCount.Size = new System.Drawing.Size(46, 54);
            this.lblTicketCount.TabIndex = 1;
            this.lblTicketCount.Text = "0";
            this.lblTicketCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Dock = System.Windows.Forms.DockStyle.Left;
            this.label13.Font = new System.Drawing.Font("Segoe UI Emoji", 28F);
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(0, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(74, 51);
            this.label13.TabIndex = 0;
            this.label13.Text = "🎫";
            // 
            // grpActivity
            // 
            this.grpActivity.BackColor = System.Drawing.Color.White;
            this.grpActivity.Controls.Add(this.lstActivity);
            this.grpActivity.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpActivity.Location = new System.Drawing.Point(77, 400);
            this.grpActivity.Name = "grpActivity";
            this.grpActivity.Size = new System.Drawing.Size(750, 280);
            this.grpActivity.TabIndex = 6;
            this.grpActivity.TabStop = false;
            this.grpActivity.Text = "Recent Activities";
            // 
            // lstActivity
            // 
            this.lstActivity.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstActivity.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstActivity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lstActivity.FormattingEnabled = true;
            this.lstActivity.ItemHeight = 17;
            this.lstActivity.Location = new System.Drawing.Point(3, 29);
            this.lstActivity.Name = "lstActivity";
            this.lstActivity.Size = new System.Drawing.Size(744, 248);
            this.lstActivity.TabIndex = 0;
            // 
            // grpQuick
            // 
            this.grpQuick.BackColor = System.Drawing.Color.White;
            this.grpQuick.Controls.Add(this.button4);
            this.grpQuick.Controls.Add(this.button3);
            this.grpQuick.Controls.Add(this.button2);
            this.grpQuick.Controls.Add(this.button1);
            this.grpQuick.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.grpQuick.Location = new System.Drawing.Point(1249, 400);
            this.grpQuick.Name = "grpQuick";
            this.grpQuick.Size = new System.Drawing.Size(520, 280);
            this.grpQuick.TabIndex = 7;
            this.grpQuick.TabStop = false;
            this.grpQuick.Text = "Quick Actions";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.MidnightBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(21, 172);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(180, 45);
            this.button4.TabIndex = 3;
            this.button4.Text = "Sell Ticket";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.MidnightBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(308, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 45);
            this.button3.TabIndex = 2;
            this.button3.Text = "Add Gathering";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MidnightBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(308, 172);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(180, 45);
            this.button2.TabIndex = 1;
            this.button2.Text = "Generate Report";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.MidnightBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(21, 51);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 45);
            this.button1.TabIndex = 0;
            this.button1.Text = "Add Patron";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblSystemInfo
            // 
            this.lblSystemInfo.AutoSize = true;
            this.lblSystemInfo.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSystemInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblSystemInfo.Location = new System.Drawing.Point(35, 917);
            this.lblSystemInfo.Name = "lblSystemInfo";
            this.lblSystemInfo.Size = new System.Drawing.Size(260, 20);
            this.lblSystemInfo.TabIndex = 8;
            this.lblSystemInfo.Text = "System Status: Connected to SQL Server";
            // 
            // timerDashboard
            // 
            this.timerDashboard.Enabled = true;
            this.timerDashboard.Interval = 5000;
            this.timerDashboard.Tick += new System.EventHandler(this.timerDashboard_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1696, 946);
            this.Controls.Add(this.lblSystemInfo);
            this.Controls.Add(this.grpQuick);
            this.Controls.Add(this.grpActivity);
            this.Controls.Add(this.pnlTickets);
            this.Controls.Add(this.pnlStaff);
            this.Controls.Add(this.pnlVenue);
            this.Controls.Add(this.pnlGatherings);
            this.Controls.Add(this.pnlPatrons);
            this.Controls.Add(this.lblSubtitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DashboardForm";
            this.Text = "DashboardForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.pnlPatrons.ResumeLayout(false);
            this.pnlPatrons.PerformLayout();
            this.pnlGatherings.ResumeLayout(false);
            this.pnlGatherings.PerformLayout();
            this.pnlVenue.ResumeLayout(false);
            this.pnlVenue.PerformLayout();
            this.pnlStaff.ResumeLayout(false);
            this.pnlStaff.PerformLayout();
            this.pnlTickets.ResumeLayout(false);
            this.pnlTickets.PerformLayout();
            this.grpActivity.ResumeLayout(false);
            this.grpQuick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSubtitle;
        private System.Windows.Forms.Panel pnlPatrons;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPatronCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlGatherings;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblGatheringCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlVenue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblVenueCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlStaff;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStaffCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlTickets;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTicketCount;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox grpActivity;
        private System.Windows.Forms.ListBox lstActivity;
        private System.Windows.Forms.GroupBox grpQuick;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblSystemInfo;
        private System.Windows.Forms.Timer timerDashboard;
    }
}