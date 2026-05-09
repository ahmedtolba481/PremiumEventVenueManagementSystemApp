using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class GatheringForm : Form
    {
        public GatheringForm()
        {
            InitializeComponent();
            UiTheme.ApplyGrid(dgvGatherings);
            UiTheme.StyleCrudButton(btnInsert, UiTheme.InsertColor);
            UiTheme.StyleCrudButton(btnUpdate, UiTheme.UpdateColor);
            UiTheme.StyleCrudButton(btnDelete, UiTheme.DeleteColor);
            UiTheme.StyleMutedButton(btnClear);
            UiTheme.StyleMutedButton(btnLoad);
            UiTheme.StyleCrudButton(btnSearch, UiTheme.SearchColor);

            cmbStatus.Items.AddRange(new object[]
            {
                "Scheduled", "Open", "Completed", "Cancelled"
            });
        }

        private void GatheringForm_Load(object sender, EventArgs e)
        {
            if (cmbStatus.Items.Count > 0 && cmbStatus.SelectedIndex < 0)
                cmbStatus.SelectedIndex = 0;
            LoadVenuesCombo();
            BtnLoadGatheringsCore();
        }

        private void LoadVenuesCombo()
        {
            try
            {
                cmbVenue.DataSource = Database.FillDataTable("SELECT VenueID, VenueName FROM Venue ORDER BY VenueName");
                cmbVenue.DisplayMember = "VenueName";
                cmbVenue.ValueMember = "VenueID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoadGatheringsCore()
        {
            try
            {
                const string sql = @"SELECT g.GatheringID, g.VenueID, v.VenueName, g.Title, g.Category,
 g.StartTime, g.EndTime, g.Status FROM Gathering g INNER JOIN Venue v ON g.VenueID=v.VenueID
ORDER BY g.GatheringID";
                dgvGatherings.DataSource = Database.FillDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            BtnLoadGatheringsCore();
            LoadVenuesCombo();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var term = (txtSearch.Text ?? "").Trim();
            if (string.IsNullOrEmpty(term))
            {
                BtnLoadGatheringsCore();
                return;
            }

            try
            {
                const string sql = @"SELECT g.GatheringID, g.VenueID, v.VenueName, g.Title, g.Category,
 g.StartTime, g.EndTime, g.Status FROM Gathering g INNER JOIN Venue v ON g.VenueID=v.VenueID
WHERE g.Title LIKE '%' + @s + '%' OR g.Category LIKE '%' + @s + '%'";
                dgvGatherings.DataSource = Database.FillDataTable(sql, new SqlParameter("@s", term));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvGatherings_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvGatherings.Rows[e.RowIndex];
            txtGatheringID.Text = row.Cells["GatheringID"].Value?.ToString() ?? "";
            if (row.Cells["VenueID"].Value != DBNull.Value)
                cmbVenue.SelectedValue = Convert.ToInt32(row.Cells["VenueID"].Value);
            txtTitle.Text = row.Cells["Title"].Value?.ToString() ?? "";
            txtCategory.Text = row.Cells["Category"].Value?.ToString() ?? "";

            if (row.Cells["StartTime"].Value != DBNull.Value)
                dtpStart.Value = Convert.ToDateTime(row.Cells["StartTime"].Value);
            if (row.Cells["EndTime"].Value != DBNull.Value)
                dtpEnd.Value = Convert.ToDateTime(row.Cells["EndTime"].Value);

            var st = row.Cells["Status"].Value?.ToString() ?? "";
            var idx = cmbStatus.Items.IndexOf(st);
            cmbStatus.SelectedIndex = idx >= 0 ? idx : 0;
        }

        private bool ValidateGathering()
        {
            if (cmbVenue.SelectedValue == null)
            {
                MessageBox.Show("Select a venue.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Title is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (dtpEnd.Value <= dtpStart.Value)
            {
                MessageBox.Show("End time must be after start time.", "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateGathering())
                return;

            try
            {
                var venueId = Convert.ToInt32(cmbVenue.SelectedValue);
                const string sql = @"INSERT INTO Gathering (VenueID, Title, Category, StartTime, EndTime, Status)
VALUES (@vid, @t, @c, @start, @end, @stat)";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@vid", venueId),
                    new SqlParameter("@t", txtTitle.Text.Trim()),
                    new SqlParameter("@c", txtCategory.Text.Trim()),
                    new SqlParameter("@start", dtpStart.Value),
                    new SqlParameter("@end", dtpEnd.Value),
                    new SqlParameter("@stat", cmbStatus.SelectedItem?.ToString() ?? "Scheduled"));

                MessageBox.Show("Gathering created.", "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadGatheringsCore();
                btnClear_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGatheringID.Text, out var gid))
            {
                MessageBox.Show("Select a gathering.", "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateGathering())
                return;

            try
            {
                var venueId = Convert.ToInt32(cmbVenue.SelectedValue);
                const string sql = @"UPDATE Gathering SET VenueID=@vid, Title=@t, Category=@c, StartTime=@start,
EndTime=@end, Status=@stat WHERE GatheringID=@gid";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@gid", gid),
                    new SqlParameter("@vid", venueId),
                    new SqlParameter("@t", txtTitle.Text.Trim()),
                    new SqlParameter("@c", txtCategory.Text.Trim()),
                    new SqlParameter("@start", dtpStart.Value),
                    new SqlParameter("@end", dtpEnd.Value),
                    new SqlParameter("@stat", cmbStatus.SelectedItem?.ToString() ?? "Scheduled"));

                MessageBox.Show("Gathering updated.", "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadGatheringsCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtGatheringID.Text, out var gid))
            {
                MessageBox.Show("Select a gathering.", "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete this gathering?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Database.ExecuteNonQuery("DELETE FROM Gathering WHERE GatheringID=@id",
                    new SqlParameter("@id", gid));
                MessageBox.Show("Deleted.", "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(null, EventArgs.Empty);
                BtnLoadGatheringsCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Gatherings", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtGatheringID.Clear();
            txtTitle.Clear();
            txtCategory.Clear();
            txtSearch.Clear();
            if (cmbVenue.Items.Count > 0)
                cmbVenue.SelectedIndex = 0;
            if (cmbStatus.Items.Count > 0)
                cmbStatus.SelectedIndex = 0;
            dgvGatherings.ClearSelection();
        }
    }
}
