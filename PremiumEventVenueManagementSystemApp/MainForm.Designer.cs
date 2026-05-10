namespace PremiumEventVenueManagementSystemApp
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnlWindowButtons = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.pnlSidebar = new System.Windows.Forms.Panel();
            this.btnEntryPass = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnVenue = new System.Windows.Forms.Button();
            this.btnTicket = new System.Windows.Forms.Button();
            this.btnGathering = new System.Windows.Forms.Button();
            this.btnStaff = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.Purchases = new System.Windows.Forms.Button();
            this.btnPatron = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.pnlTop.SuspendLayout();
            this.pnlWindowButtons.SuspendLayout();
            this.pnlSidebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.MidnightBlue;
            this.pnlTop.Controls.Add(this.lblTitle);
            this.pnlTop.Controls.Add(this.pnlWindowButtons);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1441, 80);
            this.pnlTop.TabIndex = 0;
            this.pnlTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(1341, 80);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Premium Event & Venue Management System";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // pnlWindowButtons
            // 
            this.pnlWindowButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pnlWindowButtons.Controls.Add(this.btnClose);
            this.pnlWindowButtons.Controls.Add(this.btnMinimize);
            this.pnlWindowButtons.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlWindowButtons.Location = new System.Drawing.Point(1341, 0);
            this.pnlWindowButtons.Name = "pnlWindowButtons";
            this.pnlWindowButtons.Size = new System.Drawing.Size(100, 80);
            this.pnlWindowButtons.TabIndex = 1;
            this.pnlWindowButtons.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlTop_MouseDown);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(53, 20);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 40);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnChrome_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnChrome_MouseLeave);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Location = new System.Drawing.Point(7, 20);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(40, 40);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "−";
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnChrome_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnChrome_MouseLeave);
            // 
            // pnlSidebar
            // 
            this.pnlSidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(41)))), ((int)(((byte)(55)))));
            this.pnlSidebar.Controls.Add(this.btnEntryPass);
            this.pnlSidebar.Controls.Add(this.button1);
            this.pnlSidebar.Controls.Add(this.btnVenue);
            this.pnlSidebar.Controls.Add(this.btnTicket);
            this.pnlSidebar.Controls.Add(this.btnGathering);
            this.pnlSidebar.Controls.Add(this.btnStaff);
            this.pnlSidebar.Controls.Add(this.btnExit);
            this.pnlSidebar.Controls.Add(this.Purchases);
            this.pnlSidebar.Controls.Add(this.btnPatron);
            this.pnlSidebar.Controls.Add(this.btnDashboard);
            this.pnlSidebar.Controls.Add(this.label1);
            this.pnlSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlSidebar.Location = new System.Drawing.Point(0, 80);
            this.pnlSidebar.Name = "pnlSidebar";
            this.pnlSidebar.Size = new System.Drawing.Size(227, 825);
            this.pnlSidebar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(7, 639);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 52);
            this.button1.TabIndex = 16;
            this.button1.Text = "Reports";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            this.button1.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.button1.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btnVenue
            // 
            this.btnVenue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnVenue.FlatAppearance.BorderSize = 0;
            this.btnVenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVenue.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnVenue.ForeColor = System.Drawing.Color.White;
            this.btnVenue.Location = new System.Drawing.Point(7, 557);
            this.btnVenue.Name = "btnVenue";
            this.btnVenue.Size = new System.Drawing.Size(210, 52);
            this.btnVenue.TabIndex = 15;
            this.btnVenue.Text = "Venues";
            this.btnVenue.UseVisualStyleBackColor = false;
            this.btnVenue.Click += new System.EventHandler(this.button7_Click);
            this.btnVenue.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btnVenue.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btnTicket
            // 
            this.btnTicket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnTicket.FlatAppearance.BorderSize = 0;
            this.btnTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTicket.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnTicket.ForeColor = System.Drawing.Color.White;
            this.btnTicket.Location = new System.Drawing.Point(7, 307);
            this.btnTicket.Name = "btnTicket";
            this.btnTicket.Size = new System.Drawing.Size(210, 52);
            this.btnTicket.TabIndex = 14;
            this.btnTicket.Text = "Ticket Categories";
            this.btnTicket.UseVisualStyleBackColor = false;
            this.btnTicket.Click += new System.EventHandler(this.button6_Click);
            this.btnTicket.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btnTicket.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btnGathering
            // 
            this.btnGathering.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnGathering.FlatAppearance.BorderSize = 0;
            this.btnGathering.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGathering.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnGathering.ForeColor = System.Drawing.Color.White;
            this.btnGathering.Location = new System.Drawing.Point(7, 225);
            this.btnGathering.Name = "btnGathering";
            this.btnGathering.Size = new System.Drawing.Size(210, 52);
            this.btnGathering.TabIndex = 13;
            this.btnGathering.Text = "Gatherings";
            this.btnGathering.UseVisualStyleBackColor = false;
            this.btnGathering.Click += new System.EventHandler(this.btnGathering_Click);
            this.btnGathering.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btnGathering.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btnStaff
            // 
            this.btnStaff.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnStaff.FlatAppearance.BorderSize = 0;
            this.btnStaff.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStaff.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnStaff.ForeColor = System.Drawing.Color.White;
            this.btnStaff.Location = new System.Drawing.Point(7, 474);
            this.btnStaff.Name = "btnStaff";
            this.btnStaff.Size = new System.Drawing.Size(210, 52);
            this.btnStaff.TabIndex = 12;
            this.btnStaff.Text = "Technical Staff";
            this.btnStaff.UseVisualStyleBackColor = false;
            this.btnStaff.Click += new System.EventHandler(this.btnStaff_Click);
            this.btnStaff.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btnStaff.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btnEntryPass
            // 
            this.btnEntryPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnEntryPass.FlatAppearance.BorderSize = 0;
            this.btnEntryPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEntryPass.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnEntryPass.ForeColor = System.Drawing.Color.White;
            this.btnEntryPass.Location = new System.Drawing.Point(7, 715);
            this.btnEntryPass.Name = "btnEntryPass";
            this.btnEntryPass.Size = new System.Drawing.Size(210, 52);
            this.btnEntryPass.TabIndex = 17;
            this.btnEntryPass.Text = "Entry Passes";
            this.btnEntryPass.UseVisualStyleBackColor = false;
            this.btnEntryPass.Click += new System.EventHandler(this.btnEntryPass_Click);
            this.btnEntryPass.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btnEntryPass.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(7, 790);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(210, 52);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.button3_Click);
            this.btnExit.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btnExit.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // Purchases
            // 
            this.Purchases.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.Purchases.FlatAppearance.BorderSize = 0;
            this.Purchases.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Purchases.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.Purchases.ForeColor = System.Drawing.Color.White;
            this.Purchases.Location = new System.Drawing.Point(7, 390);
            this.Purchases.Name = "Purchases";
            this.Purchases.Size = new System.Drawing.Size(210, 52);
            this.Purchases.TabIndex = 10;
            this.Purchases.Text = "Purchases";
            this.Purchases.UseVisualStyleBackColor = false;
            this.Purchases.Click += new System.EventHandler(this.Purchases_Click);
            this.Purchases.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.Purchases.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btnPatron
            // 
            this.btnPatron.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnPatron.FlatAppearance.BorderSize = 0;
            this.btnPatron.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPatron.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnPatron.ForeColor = System.Drawing.Color.White;
            this.btnPatron.Location = new System.Drawing.Point(7, 139);
            this.btnPatron.Name = "btnPatron";
            this.btnPatron.Size = new System.Drawing.Size(210, 52);
            this.btnPatron.TabIndex = 9;
            this.btnPatron.Text = "Patron Management";
            this.btnPatron.UseVisualStyleBackColor = false;
            this.btnPatron.Click += new System.EventHandler(this.button1_Click_2);
            this.btnPatron.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btnPatron.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(65)))), ((int)(((byte)(81)))));
            this.btnDashboard.FlatAppearance.BorderSize = 0;
            this.btnDashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDashboard.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.btnDashboard.ForeColor = System.Drawing.Color.White;
            this.btnDashboard.Location = new System.Drawing.Point(7, 56);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 52);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            this.btnDashboard.MouseEnter += new System.EventHandler(this.SidebarBtn_MouseEnter);
            this.btnDashboard.MouseLeave += new System.EventHandler(this.SidebarBtn_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 5, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "EVENT SYSTEM";
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(227, 80);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1214, 803);
            this.pnlMain.TabIndex = 2;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(227, 883);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "Ready";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1441, 905);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.pnlSidebar);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Segoe UI", 11.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Premium Event & Venue Management System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlWindowButtons.ResumeLayout(false);
            this.pnlSidebar.ResumeLayout(false);
            this.pnlSidebar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlWindowButtons;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel pnlSidebar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnVenue;
        private System.Windows.Forms.Button btnTicket;
        private System.Windows.Forms.Button btnGathering;
        private System.Windows.Forms.Button btnStaff;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button Purchases;
        private System.Windows.Forms.Button btnPatron;
        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnEntryPass;
    }
}
