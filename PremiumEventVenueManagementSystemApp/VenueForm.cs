using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class VenueForm : Form
    {
        public VenueForm()
        {
            InitializeComponent();
            UiTheme.StyleCrudButton(btnInsert, UiTheme.InsertColor);
            UiTheme.StyleCrudButton(btnUpdate, UiTheme.UpdateColor);
            UiTheme.StyleCrudButton(btnDelete, UiTheme.DeleteColor);
            UiTheme.StyleMutedButton(btnClear);
            UiTheme.StyleMutedButton(btnLoad);
            UiTheme.StyleCrudButton(btnSearch, UiTheme.SearchColor);
            UiTheme.ApplyGrid(dgvVenues);
        }

        private bool ValidateFields()
        {
            if (string.IsNullOrWhiteSpace(txtVenueName.Text))
            {
                MessageBox.Show("Venue Name is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("City is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtArea.Text))
            {
                MessageBox.Show("Area is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtStreet.Text))
            {
                MessageBox.Show("Street is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (numCapacity.Value < 0)
            {
                MessageBox.Show("Capacity must not be negative.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LoadGrid(DataTable dt)
        {
            dgvVenues.DataSource = null;
            dgvVenues.DataSource = dt;
        }

        private void VenueForm_Load(object sender, EventArgs e)
        {
            BtnLoad_ClickCore();
        }

        private void BtnLoad_ClickCore()
        {
            try
            {
                const string sql = "SELECT VenueID, VenueName, City, Area, Street, MaxSeatingCapacity FROM Venue ORDER BY VenueID";
                LoadGrid(Database.FillDataTable(sql));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venues", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            BtnLoad_ClickCore();
        }

        private void dgvVenues_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvVenues.Rows[e.RowIndex];
            txtVenueID.Text = row.Cells["VenueID"].Value?.ToString() ?? "";
            txtVenueName.Text = row.Cells["VenueName"].Value?.ToString() ?? "";
            txtCity.Text = row.Cells["City"].Value?.ToString() ?? "";
            txtArea.Text = row.Cells["Area"].Value?.ToString() ?? "";
            txtStreet.Text = row.Cells["Street"].Value?.ToString() ?? "";
            if (row.Cells["MaxSeatingCapacity"].Value != DBNull.Value)
                numCapacity.Value = Convert.ToDecimal(row.Cells["MaxSeatingCapacity"].Value);
            else
                numCapacity.Value = 0;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                const string sql = @"INSERT INTO Venue (VenueName, City, Area, Street, MaxSeatingCapacity)
VALUES (@name, @city, @area, @street, @cap)";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@name", txtVenueName.Text.Trim()),
                    new SqlParameter("@city", txtCity.Text.Trim()),
                    new SqlParameter("@area", txtArea.Text.Trim()),
                    new SqlParameter("@street", txtStreet.Text.Trim()),
                    new SqlParameter("@cap", (int)numCapacity.Value));

                MessageBox.Show("Venue inserted successfully.", "Venues", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoad_ClickCore();
                btnClear_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venues", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtVenueID.Text, out var id))
            {
                MessageBox.Show("Select a venue row to update.", "Venues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!ValidateFields())
                return;

            try
            {
                const string sql = @"UPDATE Venue SET VenueName=@name, City=@city, Area=@area, Street=@street, MaxSeatingCapacity=@cap
WHERE VenueID=@id";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@id", id),
                    new SqlParameter("@name", txtVenueName.Text.Trim()),
                    new SqlParameter("@city", txtCity.Text.Trim()),
                    new SqlParameter("@area", txtArea.Text.Trim()),
                    new SqlParameter("@street", txtStreet.Text.Trim()),
                    new SqlParameter("@cap", (int)numCapacity.Value));

                MessageBox.Show("Venue updated successfully.", "Venues", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoad_ClickCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venues", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtVenueID.Text, out var id))
            {
                MessageBox.Show("Select a venue row to delete.", "Venues", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Delete this venue?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                const string sql = "DELETE FROM Venue WHERE VenueID=@id";
                Database.ExecuteNonQuery(sql, new SqlParameter("@id", id));
                MessageBox.Show("Venue deleted.", "Venues", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoad_ClickCore();
                btnClear_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venues", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtVenueID.Clear();
            txtVenueName.Clear();
            txtCity.Clear();
            txtArea.Clear();
            txtStreet.Clear();
            numCapacity.Value = 0;
            txtSearch.Clear();
            dgvVenues.ClearSelection();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var term = (txtSearch.Text ?? "").Trim();
            if (string.IsNullOrEmpty(term))
            {
                BtnLoad_ClickCore();
                return;
            }

            try
            {
                const string sql = @"SELECT VenueID, VenueName, City, Area, Street, MaxSeatingCapacity FROM Venue
WHERE VenueName LIKE '%' + @s + '%' OR City LIKE '%' + @s + '%' OR Area LIKE '%' + @s + '%'";
                LoadGrid(Database.FillDataTable(sql, new SqlParameter("@s", term)));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Venues", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
