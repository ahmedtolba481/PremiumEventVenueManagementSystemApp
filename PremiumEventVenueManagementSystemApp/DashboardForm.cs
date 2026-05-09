using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class DashboardForm : Form
    {
        public Action<Type> Navigate { get; set; }

        private readonly Color _cardBase = Color.MidnightBlue;
        private readonly Color _cardHover = Color.FromArgb(50, 60, 150);

        public DashboardForm()
        {
            InitializeComponent();
            AttachCards();
            UiTheme.ApplyListStyle(lstActivity);
            Resize += (_, __) => LayoutStatPanels();
        }

        private void AttachCards()
        {
            AttachCardNavigation(pnlPatrons, typeof(PatronForm));
            AttachCardNavigation(pnlGatherings, typeof(GatheringForm));
            AttachCardNavigation(pnlVenue, typeof(VenueForm));
            AttachCardNavigation(pnlTickets, typeof(TicketCategoryForm));
            AttachCardNavigation(pnlStaff, typeof(TechnicalStaffForm));
        }

        private void AttachCardNavigation(Panel pnl, Type formType)
        {
            foreach (Control c in pnl.Controls)
                Subscribe(c);

            Subscribe(pnl);

            void Subscribe(Control c)
            {
                EventHandler hoverIn = (_, __) => pnl.BackColor = _cardHover;
                EventHandler hoverOut = (_, __) =>
                {
                    var r = pnl.RectangleToScreen(pnl.ClientRectangle);
                    if (!r.Contains(Cursor.Position))
                        pnl.BackColor = _cardBase;
                };

                EventHandler go = (_, __) => Navigate?.Invoke(formType);

                c.Cursor = Cursors.Hand;
                c.MouseEnter += hoverIn;
                c.MouseLeave += hoverOut;
                c.Click += go;
            }
        }

        private void LoadCounts()
        {
            try
            {
                lblPatronCount.Text = Database.ExecuteScalar("SELECT COUNT(*) FROM PATRON")?.ToString() ?? "0";
                lblGatheringCount.Text = Database.ExecuteScalar("SELECT COUNT(*) FROM GATHERING")?.ToString() ?? "0";
                lblVenueCount.Text = Database.ExecuteScalar("SELECT COUNT(*) FROM VENUE")?.ToString() ?? "0";
                lblTicketCount.Text = Database.ExecuteScalar("SELECT COUNT(*) FROM ENTRYPASS")?.ToString() ?? "0";
                lblStaffCount.Text = Database.ExecuteScalar("SELECT COUNT(*) FROM TECHNICALSTAFF")?.ToString() ?? "0";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Unable to load dashboard statistics:{Environment.NewLine}{ex.Message}",
                    "Dashboard", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                lblPatronCount.Text =
                    lblGatheringCount.Text =
                        lblVenueCount.Text =
                            lblTicketCount.Text =
                                lblStaffCount.Text = "—";
            }
        }

        private void LoadActivities()
        {
            lstActivity.Items.Clear();
            try
            {
                var sql =
                    @"SELECT TOP 15 msg FROM (
    SELECT CAST(N'Purchase P' + CAST(PATRONID AS NVARCHAR(20)) + N' Pass ' + CAST(PASSID AS NVARCHAR(20)) + N' Cat ' + CAST(CATEGORYID AS NVARCHAR(20)) + N' • ' + CONVERT(NVARCHAR(19), PURCHASEDATE, 120) AS NVARCHAR(500)) AS msg, PURCHASEDATE AS dt
      FROM " + Database.PurchaseTableQualified + @"
    UNION ALL
    SELECT CAST(N'Gathering #' + CAST(GatheringID AS NVARCHAR(20)) + N' • ' + ISNULL(Title, N'') AS NVARCHAR(500)), StartTime FROM GATHERING
) AS u
ORDER BY dt DESC";

                var dt = Database.FillDataTable(sql);
                foreach (DataRow row in dt.Rows)
                    lstActivity.Items.Add(row["msg"]?.ToString() ?? "");

                if (lstActivity.Items.Count == 0)
                    AddFallbackActivity();
            }
            catch
            {
                AddFallbackActivity();
            }
        }

        private void AddFallbackActivity()
        {
            lstActivity.Items.Add("New patron registered");
            lstActivity.Items.Add("VIP ticket purchased");
            lstActivity.Items.Add("New gathering scheduled");
            lstActivity.Items.Add("Technical staff assigned");
            lstActivity.Items.Add("Venue added successfully");
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            LayoutStatPanels();
            LoadCounts();
            LoadActivities();
        }

        private void LayoutStatPanels()
        {
            var panels = new[] { pnlPatrons, pnlGatherings, pnlVenue, pnlTickets, pnlStaff };
            const int gap = 12;
            var margin = 16;
            var topRow = pnlPatrons.Top;
            var count = panels.Length;
            var usable = Math.Max(460, ClientSize.Width - margin * 2);
            var width = Math.Max(120, (usable - gap * (count - 1)) / count);

            for (var i = 0; i < count; i++)
            {
                panels[i].Width = width;
                panels[i].Top = topRow;
                panels[i].Left = margin + i * (width + gap);
            }

            var belowStats = panels[0].Bottom + 22;
            grpActivity.Left = margin;
            grpActivity.Top = belowStats;

            var quickBesideLeft = grpActivity.Right + gap;
            if (quickBesideLeft + grpQuick.Width <= ClientSize.Width - margin)
            {
                grpQuick.Left = quickBesideLeft;
                grpQuick.Top = belowStats;
            }
            else
            {
                grpQuick.Left = margin;
                grpQuick.Top = grpActivity.Bottom + gap;
            }

            lblSystemInfo.Left = margin;
            lblSystemInfo.Top = Math.Max(0, ClientSize.Height - lblSystemInfo.Height - 12);
        }

        private void timerDashboard_Tick(object sender, EventArgs e)
        {
            LoadCounts();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Navigate?.Invoke(typeof(PatronForm));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Navigate?.Invoke(typeof(GatheringForm));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Navigate?.Invoke(typeof(PurchaseForm));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Navigate?.Invoke(typeof(ReportsForm));
        }

        private void pnlPatrons_Click(object sender, EventArgs e)
        {
            Navigate?.Invoke(typeof(PatronForm));
        }

        private void pnlGatherings_Click(object sender, EventArgs e)
        {
            Navigate?.Invoke(typeof(GatheringForm));
        }

        private void pnlVenue_Click(object sender, EventArgs e)
        {
            Navigate?.Invoke(typeof(VenueForm));
        }

        private void pnlTickets_Click(object sender, EventArgs e)
        {
            Navigate?.Invoke(typeof(TicketCategoryForm));
        }

        private void pnlStaff_Click(object sender, EventArgs e)
        {
            Navigate?.Invoke(typeof(TechnicalStaffForm));
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void lblSubtitle_Click(object sender, EventArgs e) { }

        private void label3_Click_1(object sender, EventArgs e) { }

        private void label7_Click(object sender, EventArgs e) { }

        private void label11_Click(object sender, EventArgs e) { }

        private void pnlVenue_Paint(object sender, PaintEventArgs e) { }
    }
}
