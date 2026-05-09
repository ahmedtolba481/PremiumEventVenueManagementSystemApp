using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class ReportsForm : Form
    {
        public ReportsForm()
        {
            InitializeComponent();
            UiTheme.ApplyGrid(dgvReports);
            var blue = UiTheme.SearchColor;
            UiTheme.StyleCrudButton(btnVip, blue);
            UiTheme.StyleCrudButton(btnRevenue, blue);
            UiTheme.StyleCrudButton(btnAttendance, blue);
            UiTheme.StyleCrudButton(btnVenueUsage, blue);
            UiTheme.StyleCrudButton(btnGatheringStaff, blue);
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            lblHeading.Select();
        }

        private void ShowReport(DataTable dt, string titleHint)
        {
            dgvReports.DataSource = null;
            dgvReports.DataSource = dt;
            Text = "Reports • " + titleHint;
        }

        private static void Warn(Exception ex)
        {
            MessageBox.Show(ex.Message, "Reports", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnVip_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = @"SELECT DISTINCT p.PatronID, p.FirstName, p.LastName, p.Email,
 tc.CategoryName, tc.Price
FROM Patron p
INNER JOIN " + Database.PurchaseTableQualified + @" pur ON p.PatronID = pur.PatronID
INNER JOIN TicketCategory tc ON tc.CategoryID = pur.CategoryID
WHERE tc.CategoryName LIKE @vip";
                ShowReport(Database.FillDataTable(sql, new SqlParameter("@vip", "%VIP%")), "VIP Customers");
            }
            catch (Exception ex)
            {
                Warn(ex);
            }
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = @"SELECT g.Title AS EventTitle,
 SUM(tc.Price) AS TotalTicketRevenue
FROM " + Database.PurchaseTableQualified + @" pur
INNER JOIN TicketCategory tc ON tc.CategoryID = pur.CategoryID
INNER JOIN Gathering g ON g.GatheringID = tc.GatheringID
GROUP BY g.GatheringID, g.Title
ORDER BY TotalTicketRevenue DESC";
                ShowReport(Database.FillDataTable(sql), "Revenue");
            }
            catch (Exception ex)
            {
                Warn(ex);
            }
        }

        private void btnAttendance_Click(object sender, EventArgs e)
        {
            try
            {
                var sql = @"SELECT g.Title, COUNT(*) AS PurchaseCount
FROM " + Database.PurchaseTableQualified + @" pur
INNER JOIN TicketCategory tc ON tc.CategoryID = pur.CategoryID
INNER JOIN Gathering g ON g.GatheringID = tc.GatheringID
GROUP BY g.GatheringID, g.Title
ORDER BY PurchaseCount DESC";
                ShowReport(Database.FillDataTable(sql), "Event Attendance");
            }
            catch (Exception ex)
            {
                Warn(ex);
            }
        }

        private void btnVenueUsage_Click(object sender, EventArgs e)
        {
            try
            {
                const string sql = @"SELECT v.VenueName, COUNT(g.GatheringID) AS EventCount
FROM Venue v
LEFT JOIN Gathering g ON g.VenueID = v.VenueID
GROUP BY v.VenueID, v.VenueName
ORDER BY EventCount DESC";
                ShowReport(Database.FillDataTable(sql), "Venue Usage");
            }
            catch (Exception ex)
            {
                Warn(ex);
            }
        }

        private void btnGatheringStaff_Click(object sender, EventArgs e)
        {
            try
            {
                const string sql = @"SELECT g.Title AS GatheringTitle,
 ts.FirstName, ts.LastName, ts.Role
FROM Gathering g
INNER JOIN GatheringStaff gs ON gs.GatheringID = g.GatheringID
INNER JOIN TechnicalStaff ts ON ts.StaffID = gs.StaffID
ORDER BY g.GatheringID, ts.StaffID";
                ShowReport(Database.FillDataTable(sql), "Gathering Staff");
            }
            catch (Exception ex)
            {
                Warn(ex);
            }
        }
    }
}
