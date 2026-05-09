using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class TicketCategoryForm : Form
    {
        public TicketCategoryForm()
        {
            InitializeComponent();
            UiTheme.ApplyGrid(dgvCategories);
            UiTheme.StyleCrudButton(btnInsert, UiTheme.InsertColor);
            UiTheme.StyleCrudButton(btnUpdate, UiTheme.UpdateColor);
            UiTheme.StyleCrudButton(btnDelete, UiTheme.DeleteColor);
            UiTheme.StyleMutedButton(btnClear);
            UiTheme.StyleMutedButton(btnLoad);
            UiTheme.StyleCrudButton(btnSearch, UiTheme.SearchColor);
        }

        private void TicketCategoryForm_Load(object sender, EventArgs e)
        {
            LoadGatherings();
            BtnLoadCore();
        }

        private void LoadGatherings()
        {
            try
            {
                cmbGathering.DataSource =
                    Database.FillDataTable(@"SELECT GatheringID, Title FROM Gathering ORDER BY GatheringID DESC");
                cmbGathering.DisplayMember = "Title";
                cmbGathering.ValueMember = "GatheringID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoadCore()
        {
            try
            {
                const string sql = @"SELECT tc.CategoryID, tc.GatheringID, g.Title AS GatheringTitle, tc.CategoryName,
 tc.Price, tc.AllocatedSeats FROM TicketCategory tc
INNER JOIN Gathering g ON tc.GatheringID = g.GatheringID ORDER BY tc.CategoryID";
                dgvCategories.DataSource = Database.FillDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadGatherings();
            BtnLoadCore();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var term = (txtSearch.Text ?? "").Trim();
            if (string.IsNullOrEmpty(term))
            {
                BtnLoadCore();
                return;
            }

            try
            {
                const string sql = @"SELECT tc.CategoryID, tc.GatheringID, g.Title AS GatheringTitle, tc.CategoryName,
 tc.Price, tc.AllocatedSeats FROM TicketCategory tc
INNER JOIN Gathering g ON tc.GatheringID = g.GatheringID
WHERE tc.CategoryName LIKE '%' + @s + '%' OR g.Title LIKE '%' + @s + '%'";
                dgvCategories.DataSource = Database.FillDataTable(sql, new SqlParameter("@s", term));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvCategories_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvCategories.Rows[e.RowIndex];
            txtCategoryID.Text = row.Cells["CategoryID"].Value?.ToString() ?? "";
            if (row.Cells["GatheringID"].Value != DBNull.Value)
                cmbGathering.SelectedValue = Convert.ToInt32(row.Cells["GatheringID"].Value);

            txtCategoryName.Text = row.Cells["CategoryName"].Value?.ToString() ?? "";
            numPrice.Value = Convert.ToDecimal(row.Cells["Price"].Value);
            numSeats.Value = Convert.ToDecimal(row.Cells["AllocatedSeats"].Value);
        }

        private bool ValidateFields()
        {
            if (cmbGathering.SelectedValue == null)
            {
                MessageBox.Show("Select a gathering.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCategoryName.Text))
            {
                MessageBox.Show("Category name is required.", "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (numPrice.Value < 0 || numSeats.Value < 0)
            {
                MessageBox.Show("Price and seats must not be negative.", "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                var gid = Convert.ToInt32(cmbGathering.SelectedValue);
                const string sql = @"INSERT INTO TicketCategory (GatheringID, CategoryName, Price, AllocatedSeats)
VALUES (@gid, @n, @p, @a)";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@gid", gid),
                    new SqlParameter("@n", txtCategoryName.Text.Trim()),
                    new SqlParameter("@p", numPrice.Value),
                    new SqlParameter("@a", (int)numSeats.Value));

                MessageBox.Show("Category created.", "Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadCore();
                btnClear_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCategoryID.Text, out var cid))
            {
                MessageBox.Show("Select a category row.", "Categories", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateFields())
                return;

            try
            {
                var gid = Convert.ToInt32(cmbGathering.SelectedValue);
                const string sql = @"UPDATE TicketCategory SET GatheringID=@gid, CategoryName=@n, Price=@p,
AllocatedSeats=@a WHERE CategoryID=@cid";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@cid", cid),
                    new SqlParameter("@gid", gid),
                    new SqlParameter("@n", txtCategoryName.Text.Trim()),
                    new SqlParameter("@p", numPrice.Value),
                    new SqlParameter("@a", (int)numSeats.Value));

                MessageBox.Show("Category updated.", "Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCategoryID.Text, out var cid))
            {
                MessageBox.Show("Select a category row.", "Categories", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete this category?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Database.ExecuteNonQuery("DELETE FROM TicketCategory WHERE CategoryID=@id",
                    new SqlParameter("@id", cid));
                MessageBox.Show("Deleted.", "Categories", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadCore();
                btnClear_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Categories", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtCategoryID.Clear();
            txtCategoryName.Clear();
            numPrice.Value = 0;
            numSeats.Value = 0;
            txtSearch.Clear();
            if (cmbGathering.Items.Count > 0)
                cmbGathering.SelectedIndex = 0;
            dgvCategories.ClearSelection();
        }
    }
}
