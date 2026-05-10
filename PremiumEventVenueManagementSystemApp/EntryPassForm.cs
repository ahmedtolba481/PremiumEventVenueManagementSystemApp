using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class EntryPassForm : Form
    {
        public EntryPassForm()
        {
            InitializeComponent();
            UiTheme.ApplyGrid(dgvEntryPasses);
            UiTheme.StyleCrudButton(btnInsert, UiTheme.InsertColor);
            UiTheme.StyleCrudButton(btnUpdate, UiTheme.UpdateColor);
            UiTheme.StyleCrudButton(btnDelete, UiTheme.DeleteColor);
            UiTheme.StyleMutedButton(btnClear);
            UiTheme.StyleMutedButton(btnLoad);
            UiTheme.StyleCrudButton(btnSearch, UiTheme.SearchColor);
        }

        private void EntryPassForm_Load(object sender, EventArgs e)
        {
            cmbIssueStatus.Items.AddRange(new object[] { "Pending", "Issued", "Cancelled" });
            if (cmbIssueStatus.Items.Count > 0) cmbIssueStatus.SelectedIndex = 0;
            
            LoadCategories();
            BtnLoadCore();
        }

        private void LoadCategories()
        {
            try
            {
                cmbCategory.DataSource =
                    Database.FillDataTable(@"SELECT CategoryID, CategoryName FROM TicketCategory ORDER BY CategoryID DESC");
                cmbCategory.DisplayMember = "CategoryName";
                cmbCategory.ValueMember = "CategoryID";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnLoadCore()
        {
            try
            {
                const string sql = @"SELECT ep.PassID, ep.CategoryID, tc.CategoryName, ep.QRCode, ep.IssueStatus 
 FROM EntryPass ep
 INNER JOIN TicketCategory tc ON ep.CategoryID = tc.CategoryID ORDER BY ep.PassID";
                dgvEntryPasses.DataSource = Database.FillDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadCategories();
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
                const string sql = @"SELECT ep.PassID, ep.CategoryID, tc.CategoryName, ep.QRCode, ep.IssueStatus 
 FROM EntryPass ep
 INNER JOIN TicketCategory tc ON ep.CategoryID = tc.CategoryID
 WHERE ep.QRCode LIKE '%' + @s + '%' OR tc.CategoryName LIKE '%' + @s + '%' OR ep.IssueStatus LIKE '%' + @s + '%'";
                dgvEntryPasses.DataSource = Database.FillDataTable(sql, new SqlParameter("@s", term));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvEntryPasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvEntryPasses.Rows[e.RowIndex];
            txtPassID.Text = row.Cells["PassID"].Value?.ToString() ?? "";
            if (row.Cells["CategoryID"].Value != DBNull.Value)
                cmbCategory.SelectedValue = Convert.ToInt32(row.Cells["CategoryID"].Value);

            txtQrCode.Text = row.Cells["QRCode"].Value?.ToString() ?? "";
            cmbIssueStatus.SelectedItem = row.Cells["IssueStatus"].Value?.ToString() ?? "Pending";
        }

        private bool ValidateFields()
        {
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Select a ticket category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQrCode.Text))
            {
                MessageBox.Show("QR Code is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbIssueStatus.SelectedItem == null)
            {
                MessageBox.Show("Issue status is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
                var cid = Convert.ToInt32(cmbCategory.SelectedValue);
                const string sql = @"INSERT INTO EntryPass (CategoryID, QRCode, IssueStatus)
VALUES (@cid, @qr, @st)";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@cid", cid),
                    new SqlParameter("@qr", txtQrCode.Text.Trim()),
                    new SqlParameter("@st", cmbIssueStatus.SelectedItem.ToString()));

                MessageBox.Show("Entry pass created.", "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadCore();
                btnClear_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPassID.Text, out var pid))
            {
                MessageBox.Show("Select an entry pass row.", "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidateFields())
                return;

            try
            {
                var cid = Convert.ToInt32(cmbCategory.SelectedValue);
                const string sql = @"UPDATE EntryPass SET CategoryID=@cid, QRCode=@qr, IssueStatus=@st WHERE PassID=@pid";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@pid", pid),
                    new SqlParameter("@cid", cid),
                    new SqlParameter("@qr", txtQrCode.Text.Trim()),
                    new SqlParameter("@st", cmbIssueStatus.SelectedItem.ToString()));

                MessageBox.Show("Entry pass updated.", "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPassID.Text, out var pid))
            {
                MessageBox.Show("Select an entry pass row.", "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete this entry pass?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Database.ExecuteNonQuery("DELETE FROM EntryPass WHERE PassID=@id", new SqlParameter("@id", pid));
                MessageBox.Show("Deleted.", "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadCore();
                btnClear_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Entry Passes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPassID.Clear();
            txtQrCode.Clear();
            if (cmbIssueStatus.Items.Count > 0)
                cmbIssueStatus.SelectedIndex = 0;
            txtSearch.Clear();
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
            dgvEntryPasses.ClearSelection();
        }
    }
}
