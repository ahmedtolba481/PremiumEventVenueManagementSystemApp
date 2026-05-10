using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class PurchaseForm : Form
    {
        private int? _keyPatronId;
        private int? _keyPassId;
        private int? _keyCategoryId;

        private bool HasEditingKeys =>
            _keyPatronId.HasValue && _keyPassId.HasValue && _keyCategoryId.HasValue;

        public PurchaseForm()
        {
            InitializeComponent();
            UiTheme.ApplyGrid(dgvPurchases);
            UiTheme.StyleCrudButton(btnInsert, UiTheme.InsertColor);
            UiTheme.StyleCrudButton(btnUpdate, UiTheme.UpdateColor);
            UiTheme.StyleCrudButton(btnDelete, UiTheme.DeleteColor);
            UiTheme.StyleMutedButton(btnClear);
            UiTheme.StyleMutedButton(btnLoad);
            UiTheme.StyleCrudButton(btnSearch, UiTheme.SearchColor);
        }

        private void PurchaseForm_Load(object sender, EventArgs e)
        {
            FillCombos();
            if (cmbPayment.Items.Count > 0 && cmbPayment.SelectedIndex < 0)
                cmbPayment.SelectedIndex = 0;
            BtnLoadCore();
        }

        private void FillCombos()
        {
            try
            {
                cmbPatron.DataSource = Database.FillDataTable(@"SELECT PatronID, FirstName+' '+LastName AS PatronLabel
FROM Patron ORDER BY PatronID");
                cmbPatron.DisplayMember = "PatronLabel";
                cmbPatron.ValueMember = "PatronID";

                cmbCategory.DataSource =
                    Database.FillDataTable(@"SELECT tc.CategoryID, CAST(tc.CategoryID AS NVARCHAR)+N': '+tc.CategoryName+N' • '+ISNULL(g.Title,N'') AS CategoryLabel FROM TicketCategory tc INNER JOIN Gathering g ON g.GatheringID=tc.GatheringID ORDER BY tc.CategoryID");
                cmbCategory.DisplayMember = "CategoryLabel";
                cmbCategory.ValueMember = "CategoryID";

                LoadPassCombo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadPassCombo(int? preferredPassId = null)
        {
            DataTable passes = null;

            if (cmbCategory.SelectedValue != null &&
                int.TryParse(cmbCategory.SelectedValue.ToString(), out var cid))
            {
                try
                {
                    var sql = "SELECT PASSID AS PassID FROM " + Database.EntryPassTableQualified +
                              " WHERE CATEGORYID = @cat ORDER BY PASSID";
                    passes = Database.FillDataTable(sql, new SqlParameter("@cat", cid));
                }
                catch
                {
                    passes = null;
                }
            }

            if (passes == null || passes.Rows.Count == 0)
            {
                try
                {
                    passes = Database.FillDataTable(
                        "SELECT PASSID AS PassID FROM " + Database.EntryPassTableQualified + " ORDER BY PASSID");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(
                        "Could not load entry passes from " + Database.EntryPassTableQualified +
                        ex.Message,
                        "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cmbPass.DataSource = null;
                    return;
                }
            }

            if (!passes.Columns.Contains("Label"))
                passes.Columns.Add("Label", typeof(string));
            foreach (DataRow row in passes.Rows)
                row["Label"] = "Pass #" + row["PassID"];

            cmbPass.DataSource = passes;
            cmbPass.DisplayMember = "Label";
            cmbPass.ValueMember = "PassID";

            if (preferredPassId.HasValue && passes.Rows.Count > 0)
                foreach (DataRow row in passes.Rows)
                {
                    if (Convert.ToInt32(row["PassID"]) == preferredPassId.Value)
                    {
                        cmbPass.SelectedValue = preferredPassId.Value;
                        break;
                    }
                }
        }

        private void cmbCategory_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LoadPassCombo();
        }

        private static string PurchaseSelectSql()
        {
            return @"SELECT pur.PATRONID AS PatronID, pur.PASSID AS PassID, pur.CATEGORYID AS CategoryID,
 pur.PURCHASEDATE AS PurchaseDate, pur.PAYMENTMETHOD AS PaymentMethod,
 p.FirstName + N' '+p.LastName AS PatronName, tc.CategoryName AS CategoryName
FROM " + Database.PurchaseTableQualified + @" pur
INNER JOIN Patron p ON p.PatronID = pur.PATRONID
LEFT JOIN TicketCategory tc ON tc.CategoryID = pur.CATEGORYID ";
        }

        private void BtnLoadCore()
        {
            try
            {
                var sql = PurchaseSelectSql() + "ORDER BY pur.PURCHASEDATE DESC";
                dgvPurchases.DataSource = Database.FillDataTable(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            FillCombos();
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
                var sql = PurchaseSelectSql() + @"WHERE CAST(pur.PATRONID AS NVARCHAR(20)) LIKE N'%' + @s + N'%'
 OR CAST(pur.PASSID AS NVARCHAR(20)) LIKE N'%' + @s + N'%'
 OR CAST(pur.CATEGORYID AS NVARCHAR(20)) LIKE N'%' + @s + N'%'
 OR p.Email LIKE N'%' + @s + N'%'
 OR pur.PAYMENTMETHOD LIKE N'%' + @s + N'%'
ORDER BY pur.PURCHASEDATE DESC";
                dgvPurchases.DataSource = Database.FillDataTable(sql, new SqlParameter("@s", term));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPurchases_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvPurchases.Rows[e.RowIndex];

            _keyPatronId = Convert.ToInt32(row.Cells["PatronID"].Value);
            _keyPassId = Convert.ToInt32(row.Cells["PassID"].Value);
            _keyCategoryId = Convert.ToInt32(row.Cells["CategoryID"].Value);
            txtPurchaseID.Text = $"{_keyPatronId} · {_keyPassId} · {_keyCategoryId}";

            cmbPatron.SelectedValue = _keyPatronId.Value;
            cmbCategory.SelectedValue = _keyCategoryId.Value;
            LoadPassCombo(_keyPassId);
            try
            {
                cmbPass.SelectedValue = _keyPassId.Value;
            }
            catch
            {
               
            }

       if (row.Cells["PurchaseDate"].Value != DBNull.Value)
{
    dtpPurchase.Value =
        Convert.ToDateTime(
            row.Cells["PurchaseDate"].Value
        );
}

            var pay = row.Cells["PaymentMethod"].Value?.ToString() ?? "";
            var ix = cmbPayment.Items.IndexOf(pay);
            cmbPayment.SelectedIndex = ix >= 0 ? ix : 0;
        }

        private bool ValidatePurchase()
        {
            if (cmbPatron.SelectedValue == null)
            {
                MessageBox.Show("Select a patron.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbCategory.SelectedValue == null)
            {
                MessageBox.Show("Select a category.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbPass.SelectedValue == null)
            {
                MessageBox.Show("Select an entry pass.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            if (cmbPayment.SelectedItem == null)
            {
                MessageBox.Show("Select payment method.", "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidatePurchase())
                return;

            try
            {
                var sql = @"INSERT INTO " + Database.PurchaseTableQualified +
                          @" (PATRONID, PASSID, CATEGORYID, PURCHASEDATE, PAYMENTMETHOD)
VALUES (@pid, @pass, @cat, @dt, @pay)";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@pid", Convert.ToInt32(cmbPatron.SelectedValue)),
                    new SqlParameter("@pass", Convert.ToInt32(cmbPass.SelectedValue)),
                    new SqlParameter("@cat", Convert.ToInt32(cmbCategory.SelectedValue)),
                    new SqlParameter("@dt", dtpPurchase.Value),
                    new SqlParameter("@pay", cmbPayment.SelectedItem?.ToString()));

                MessageBox.Show("Purchase recorded.", "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadCore();
                btnClear_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!HasEditingKeys)
            {
                MessageBox.Show("Select a row in the grid first (composite key).", "Purchases",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidatePurchase())
                return;

            try
            {
                var sql = @"UPDATE " + Database.PurchaseTableQualified + @" SET PATRONID=@npid, PASSID=@npass, CATEGORYID=@ncat,
PURCHASEDATE=@dt, PAYMENTMETHOD=@pay
WHERE PATRONID=@opid AND PASSID=@opass AND CATEGORYID=@ocat";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@opid", _keyPatronId.Value),
                    new SqlParameter("@opass", _keyPassId.Value),
                    new SqlParameter("@ocat", _keyCategoryId.Value),
                    new SqlParameter("@npid", Convert.ToInt32(cmbPatron.SelectedValue)),
                    new SqlParameter("@npass", Convert.ToInt32(cmbPass.SelectedValue)),
                    new SqlParameter("@ncat", Convert.ToInt32(cmbCategory.SelectedValue)),
                    new SqlParameter("@dt", dtpPurchase.Value),
                    new SqlParameter("@pay", cmbPayment.SelectedItem?.ToString()));

                MessageBox.Show("Purchase updated.", "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _keyPatronId = Convert.ToInt32(cmbPatron.SelectedValue);
                _keyPassId = Convert.ToInt32(cmbPass.SelectedValue);
                _keyCategoryId = Convert.ToInt32(cmbCategory.SelectedValue);
                txtPurchaseID.Text = $"{_keyPatronId} · {_keyPassId} · {_keyCategoryId}";
                BtnLoadCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!HasEditingKeys)
            {
                MessageBox.Show("Select a purchase row.", "Purchases", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Delete this purchase record?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Database.ExecuteNonQuery(
                    "DELETE FROM " + Database.PurchaseTableQualified + " WHERE PATRONID=@opid AND PASSID=@opass AND CATEGORYID=@ocat",
                    new SqlParameter("@opid", _keyPatronId.Value),
                    new SqlParameter("@opass", _keyPassId.Value),
                    new SqlParameter("@ocat", _keyCategoryId.Value));
                MessageBox.Show("Deleted.", "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadCore();
                btnClear_Click(null, EventArgs.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Purchases", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            _keyPatronId = _keyPassId = _keyCategoryId = null;
            txtPurchaseID.Clear();
            txtSearch.Clear();
            if (cmbPatron.Items.Count > 0)
                cmbPatron.SelectedIndex = 0;
            if (cmbCategory.Items.Count > 0)
                cmbCategory.SelectedIndex = 0;
            if (cmbPayment.Items.Count > 0)
                cmbPayment.SelectedIndex = 0;
            LoadPassCombo();
            dgvPurchases.ClearSelection();
        }
    }
}
