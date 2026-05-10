using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class TechnicalStaffForm : Form
    {
        public TechnicalStaffForm()
        {
            InitializeComponent();
            UiTheme.ApplyGrid(dgvStaff);
            UiTheme.ApplyGrid(dgvConduct);
            UiTheme.StyleCrudButton(btnInsertStaff, UiTheme.InsertColor);
            UiTheme.StyleCrudButton(btnUpdateStaff, UiTheme.UpdateColor);
            UiTheme.StyleCrudButton(btnDeleteStaff, UiTheme.DeleteColor);
            UiTheme.StyleMutedButton(btnClearStaff);
            UiTheme.StyleMutedButton(btnLoadStaff);
            UiTheme.StyleCrudButton(btnSearchStaff, UiTheme.SearchColor);
            UiTheme.StyleCrudButton(btnConductInsert, UiTheme.InsertColor);
            UiTheme.StyleCrudButton(btnConductUpdate, UiTheme.UpdateColor);
            UiTheme.StyleCrudButton(btnConductDelete, UiTheme.DeleteColor);
            UiTheme.StyleMutedButton(btnConductClear);
            UiTheme.StyleMutedButton(btnConductReload);
        }

        private int? SelectedStaffId =>
            int.TryParse(txtStaffID.Text, out var sid) ? sid : (int?)null;

        private void TechnicalStaffForm_Load(object sender, EventArgs e)
        {
            LoadSupervisors(null);
            BtnLoadStaffCore();
        }

        private void LoadSupervisors(int? excludeStaffId)
        {
            var dt = Database.FillDataTable(@"SELECT StaffID AS SupervisorID, LastName+N', '+FirstName AS SupervisorLabel FROM TechnicalStaff ORDER BY StaffID");
            var prepend = dt.Clone();
            var r = prepend.NewRow();
            r["SupervisorID"] = DBNull.Value;
            r["SupervisorLabel"] = "(None)";
            prepend.Rows.Add(r.ItemArray);
            foreach (DataRow row in dt.Rows)
                prepend.ImportRow(row);

            if (excludeStaffId.HasValue)
                for (var i = prepend.Rows.Count - 1; i >= 0; i--)
                {
                    var v = prepend.Rows[i]["SupervisorID"];
                    if (v != DBNull.Value && Convert.ToInt32(v) == excludeStaffId.Value)
                        prepend.Rows.RemoveAt(i);
                }

            cmbSupervisor.DataSource = prepend;
            cmbSupervisor.DisplayMember = "SupervisorLabel";
            cmbSupervisor.ValueMember = "SupervisorID";
        }

        private void BtnLoadStaffCore()
        {
            try
            {
                const string sql = @"SELECT ts.StaffID, ts.Tec_StaffID, sup.LastName+N', '+sup.FirstName AS SupervisorName,
 ts.FirstName, ts.LastName, ts.Role, ts.ExperienceYears
FROM TechnicalStaff ts
LEFT JOIN TechnicalStaff sup ON sup.StaffID = ts.Tec_StaffID ORDER BY ts.StaffID";
                dgvStaff.DataSource = Database.FillDataTable(sql);
                dgvConduct.DataSource = null;
                ConductClear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Technical Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadStaff_Click(object sender, EventArgs e)
        {
            BtnLoadStaffCore();
        }

        private void btnSearchStaff_Click(object sender, EventArgs e)
        {
            var term = (txtStaffSearch.Text ?? "").Trim();
            if (string.IsNullOrEmpty(term))
            {
                BtnLoadStaffCore();
                return;
            }

            try
            {
                const string sql = @"SELECT ts.StaffID, ts.Tec_StaffID,
 sup.LastName+N', '+sup.FirstName AS SupervisorName, ts.FirstName, ts.LastName, ts.Role, ts.ExperienceYears
FROM TechnicalStaff ts
LEFT JOIN TechnicalStaff sup ON sup.StaffID = ts.Tec_StaffID
WHERE ts.FirstName LIKE '%' + @s + '%' OR ts.LastName LIKE '%' + @s + '%' OR ts.Role LIKE '%' + @s + '%'";
                dgvStaff.DataSource = Database.FillDataTable(sql, new SqlParameter("@s", term));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Technical Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvStaff_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvStaff.Rows[e.RowIndex];
            var sid = Convert.ToInt32(row.Cells["StaffID"].Value);
            txtStaffID.Text = sid.ToString();
            txtFirst.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
            txtLast.Text = row.Cells["LastName"].Value?.ToString() ?? "";
            txtRole.Text = row.Cells["Role"].Value?.ToString() ?? "";
            if (row.Cells["ExperienceYears"].Value != DBNull.Value)
                numYears.Value = Convert.ToDecimal(row.Cells["ExperienceYears"].Value);

            LoadSupervisors(sid);

            object supId = DBNull.Value;
            if (row.Cells["Tec_StaffID"].Value != DBNull.Value)
                supId = Convert.ToInt32(row.Cells["Tec_StaffID"].Value);
            SafeSetSupervisor(supId);

            LoadConductForStaff(sid);
        }

        private void SafeSetSupervisor(object supIdOrNull)
        {
            try
            {
                if (supIdOrNull == DBNull.Value || supIdOrNull == null || supIdOrNull.Equals(0))
                {
                    cmbSupervisor.SelectedIndex = 0;
                    return;
                }

                cmbSupervisor.SelectedValue = Convert.ToInt32(supIdOrNull);
            }
            catch
            {
                cmbSupervisor.SelectedIndex = 0;
            }
        }

        private void btnInsertStaff_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirst.Text) || string.IsNullOrWhiteSpace(txtLast.Text))
            {
                MessageBox.Show("Names are required.", "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SqlParameter supParam =
                    GetSupervisorParam();

                const string sql = @"INSERT INTO TechnicalStaff (Tec_StaffID, FirstName, LastName, Role, ExperienceYears)
VALUES (@sup, @fn, @ln, @role, @y)";
                Database.ExecuteNonQuery(sql,
                    supParam,
                    new SqlParameter("@fn", txtFirst.Text.Trim()),
                    new SqlParameter("@ln", txtLast.Text.Trim()),
                    new SqlParameter("@role", txtRole.Text.Trim()),
                    new SqlParameter("@y", (int)numYears.Value));

                MessageBox.Show("Staff created.", "Technical Staff", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                BtnLoadStaffCore();
                BtnClearStaffCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Technical Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private SqlParameter GetSupervisorParam()
        {
            var val = cmbSupervisor.SelectedValue;
            object sup = DBNull.Value;
            if (val != DBNull.Value && val != null)
                sup = Convert.ToInt32(val);
            return new SqlParameter("@sup", sup);
        }

        private void btnUpdateStaff_Click(object sender, EventArgs e)
        {
            if (!SelectedStaffId.HasValue)
            {
                MessageBox.Show("Select a staff member.", "Technical Staff", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            LoadSupervisors(SelectedStaffId.Value);

            try
            {
                SqlParameter supParam = GetSupervisorParam();
                object supVal = supParam.Value == DBNull.Value ? DBNull.Value : supParam.Value;
                object self = SelectedStaffId.Value;
                if (supVal != DBNull.Value && Equals(supVal, self))
                {
                    MessageBox.Show("A staff member cannot supervise themselves.", "Validation",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Database.ExecuteNonQuery(
                    @"UPDATE TechnicalStaff SET Tec_StaffID=@sup, FirstName=@fn, LastName=@ln, Role=@role, ExperienceYears=@y WHERE StaffID=@id",
                    new SqlParameter("@id", SelectedStaffId.Value),
                    supParam,
                    new SqlParameter("@fn", txtFirst.Text.Trim()),
                    new SqlParameter("@ln", txtLast.Text.Trim()),
                    new SqlParameter("@role", txtRole.Text.Trim()),
                    new SqlParameter("@y", (int)numYears.Value));

                MessageBox.Show("Staff updated.", "Technical Staff", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                BtnLoadStaffCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Technical Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteStaff_Click(object sender, EventArgs e)
        {
            if (!SelectedStaffId.HasValue)
                return;

            if (MessageBox.Show("Delete this staff row and dependent conduct/contact rows?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Database.ExecuteNonQuery(@"UPDATE TechnicalStaff SET Tec_StaffID=NULL WHERE Tec_StaffID=@sid",
                    new SqlParameter("@sid", SelectedStaffId.Value));
                Database.ExecuteNonQuery("DELETE FROM Staff_Conduct WHERE StaffID=@sid",
                    new SqlParameter("@sid", SelectedStaffId.Value));
                try
                {
                    Database.ExecuteNonQuery(@"DELETE FROM GatheringStaff WHERE StaffID=@sid",
                        new SqlParameter("@sid", SelectedStaffId.Value));
                }
                catch
                { /* GatheringStaff junction may differ */ }

                Database.ExecuteNonQuery("DELETE FROM TechnicalStaff WHERE StaffID=@sid",
                    new SqlParameter("@sid", SelectedStaffId.Value));

                MessageBox.Show("Deleted.", "Technical Staff", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                BtnClearStaffCore();
                BtnLoadStaffCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Technical Staff", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClearStaffCore()
        {
            txtStaffID.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            txtRole.Clear();
            numYears.Value = 0;
            txtStaffSearch.Clear();
            dgvStaff.ClearSelection();
            dgvConduct.DataSource = null;
            ConductClear();
            LoadSupervisors(null);
        }

        private void btnClearStaff_Click(object sender, EventArgs e)
        {
            BtnClearStaffCore();
        }

        private void LoadConductForStaff(int staffId)
        {
            try
            {
                const string sql = @"SELECT ConductID, StaffID, Phone, Email FROM Staff_Conduct WHERE StaffID=@sid ORDER BY ConductID";
                dgvConduct.DataSource =
                    Database.FillDataTable(sql, new SqlParameter("@sid", staffId));
            }
            catch
            {
                try
                {
                    const string alt = @"SELECT StaffID AS ConductKey, StaffID, Phone, Email FROM Staff_Conduct WHERE StaffID=@sid";
                    dgvConduct.DataSource =
                        Database.FillDataTable(alt, new SqlParameter("@sid", staffId));
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Conduct", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                }
            }

            ConductClear();
        }

        private void dgvConduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var row = dgvConduct.Rows[e.RowIndex];

            txtConductPhone.Text =
                SafeCell(row, "Phone")
                ?? "";
            txtConductEmail.Text =
                SafeCell(row, "Email")
                ?? "";

            var cidText = SafeCell(row, "ConductID");
            txtConductID.Text = cidText ?? "";
        }

        private static string SafeCell(DataGridViewRow row, string header)
        {
            if (!row.DataGridView.Columns.Contains(header))
                return null;

            var v = row.Cells[header].Value;
            return v == DBNull.Value || v == null ? "" : v.ToString();
        }

        private void ConductClear()
        {
            txtConductID.Clear();
            txtConductPhone.Clear();
            txtConductEmail.Clear();
            dgvConduct.ClearSelection();
        }

        private void btnConductClear_Click(object sender, EventArgs e)
        {
            ConductClear();
        }

        private void btnConductReload_Click(object sender, EventArgs e)
        {
            if (SelectedStaffId.HasValue)
                LoadConductForStaff(SelectedStaffId.Value);
        }

        private void btnConductInsert_Click(object sender, EventArgs e)
        {
            if (!SelectedStaffId.HasValue)
                return;
            if (string.IsNullOrWhiteSpace(txtConductPhone.Text) &&
                string.IsNullOrWhiteSpace(txtConductEmail.Text))
            {
                MessageBox.Show("Enter phone or email.", "Conduct", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            try
            {
                Database.ExecuteNonQuery(
                    @"INSERT INTO Staff_Conduct (StaffID, Phone, Email) VALUES (@sid, @phone, @email)",
                    new SqlParameter("@sid", SelectedStaffId.Value),
                    new SqlParameter("@phone", (object)(txtConductPhone.Text ?? "").Trim()),
                    new SqlParameter("@email", (object)(txtConductEmail.Text ?? "").Trim()));

                MessageBox.Show("Contact recorded.", "Conduct", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                LoadConductForStaff(SelectedStaffId.Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Conduct", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnConductUpdate_Click(object sender, EventArgs e)
        {
            if (!SelectedStaffId.HasValue)
                return;

            if (int.TryParse(txtConductID.Text, out var conductId))
            {
                TryUpdateByConductId(conductId);
                return;
            }

            UpsertConductByStaff();
        }

        private void TryUpdateByConductId(int conductId)
        {
            try
            {
                Database.ExecuteNonQuery(@"UPDATE Staff_Conduct SET Phone=@p, Email=@e WHERE ConductID=@c AND StaffID=@s",
                    new SqlParameter("@c", conductId),
                    new SqlParameter("@s", SelectedStaffId.Value),
                    new SqlParameter("@p", txtConductPhone.Text.Trim()),
                    new SqlParameter("@e", txtConductEmail.Text.Trim()));

                LoadConductForStaff(SelectedStaffId.Value);
            }
            catch
            {
                UpsertConductByStaff();
            }
        }

        private void UpsertConductByStaff()
        {
            var affected = Database.ExecuteNonQuery(@"UPDATE Staff_Conduct SET Phone=@p, Email=@e WHERE StaffID=@s",
                new SqlParameter("@s", SelectedStaffId.Value),
                new SqlParameter("@p", txtConductPhone.Text.Trim()),
                new SqlParameter("@e", txtConductEmail.Text.Trim()));

            if (affected == 0)
                Database.ExecuteNonQuery(
                    @"INSERT INTO Staff_Conduct (StaffID, Phone, Email) VALUES (@sid, @phone, @email)",
                    new SqlParameter("@sid", SelectedStaffId.Value),
                    new SqlParameter("@phone", txtConductPhone.Text.Trim()),
                    new SqlParameter("@email", txtConductEmail.Text.Trim()));

            LoadConductForStaff(SelectedStaffId.Value);
        }

        private void btnConductDelete_Click(object sender, EventArgs e)
        {
            if (!SelectedStaffId.HasValue)
                return;

            if (int.TryParse(txtConductID.Text, out var cid))
            {
                if (MessageBox.Show("Delete this contact row?", "Confirm", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) != DialogResult.Yes)
                    return;
                try
                {
                    Database.ExecuteNonQuery(@"DELETE FROM Staff_Conduct WHERE ConductID=@cid",
                        new SqlParameter("@cid", cid));
                    LoadConductForStaff(SelectedStaffId.Value);
                    ConductClear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Conduct", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (MessageBox.Show("Clear all Staff_Conduct rows for this employee?", "Confirm",
                         MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                     DialogResult.Yes)
            {
                Database.ExecuteNonQuery("DELETE FROM Staff_Conduct WHERE StaffID=@sid",
                    new SqlParameter("@sid", SelectedStaffId.Value));
                LoadConductForStaff(SelectedStaffId.Value);
            }
        }
    }
}
