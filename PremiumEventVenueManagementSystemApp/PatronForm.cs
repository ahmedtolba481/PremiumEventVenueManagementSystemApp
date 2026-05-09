using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class PatronForm : Form
    {
        public PatronForm()
        {
            InitializeComponent();
            UiTheme.ApplyGrid(dgvPatrons);
            UiTheme.ApplyGrid(dgvPhones);
            UiTheme.StyleCrudButton(btnInsert, UiTheme.InsertColor);
            UiTheme.StyleCrudButton(btnUpdate, UiTheme.UpdateColor);
            UiTheme.StyleCrudButton(btnDelete, UiTheme.DeleteColor);
            UiTheme.StyleMutedButton(btnClear);
            UiTheme.StyleMutedButton(btnLoadPatrons);
            UiTheme.StyleCrudButton(btnSearchPatron, UiTheme.SearchColor);
            UiTheme.StyleCrudButton(btnPhoneInsert, UiTheme.InsertColor);
            UiTheme.StyleCrudButton(btnPhoneUpdate, UiTheme.UpdateColor);
            UiTheme.StyleCrudButton(btnPhoneDelete, UiTheme.DeleteColor);
            UiTheme.StyleMutedButton(btnPhoneClear);
            UiTheme.StyleMutedButton(btnPhoneReload);
        }

        private int? SelectedPatronId =>
            int.TryParse(txtPatronID.Text, out var id) ? id : (int?)null;

        private void PatronForm_Load(object sender, EventArgs e)
        {
            BtnLoadPatronsCore();
            dtpRegistration.Format = DateTimePickerFormat.Short;
        }

        private void BtnLoadPatronsCore()
        {
            try
            {
                const string sql =
                    "SELECT PatronID, FirstName, LastName, Email, RegistrationDate FROM Patron ORDER BY PatronID";
                dgvPatrons.DataSource = Database.FillDataTable(sql);
                dgvPhones.DataSource = null;
                PhoneClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoadPatrons_Click(object sender, EventArgs e)
        {
            BtnLoadPatronsCore();
        }

        private void btnSearchPatron_Click(object sender, EventArgs e)
        {
            var term = (txtPatronSearch.Text ?? "").Trim();
            if (string.IsNullOrEmpty(term))
            {
                BtnLoadPatronsCore();
                return;
            }

            try
            {
                const string sql = @"SELECT PatronID, FirstName, LastName, Email, RegistrationDate FROM Patron
WHERE FirstName LIKE '%' + @s + '%' OR LastName LIKE '%' + @s + '%' OR Email LIKE '%' + @s + '%'";
                dgvPatrons.DataSource = Database.FillDataTable(sql, new SqlParameter("@s", term));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPatrons_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvPatrons.Rows[e.RowIndex];
            txtPatronID.Text = row.Cells["PatronID"].Value?.ToString() ?? "";
            txtFirst.Text = row.Cells["FirstName"].Value?.ToString() ?? "";
            txtLast.Text = row.Cells["LastName"].Value?.ToString() ?? "";
            txtEmail.Text = row.Cells["Email"].Value?.ToString() ?? "";
            if (row.Cells["RegistrationDate"].Value != DBNull.Value &&
                DateTime.TryParse(row.Cells["RegistrationDate"].Value?.ToString(), CultureInfo.InvariantCulture,
                    DateTimeStyles.AssumeLocal, out var reg))
                dtpRegistration.Value = reg;
            LoadPhonesForPatron();
        }

        private void LoadPhonesForPatron()
        {
            if (!SelectedPatronId.HasValue)
            {
                dgvPhones.DataSource = null;
                return;
            }

            try
            {
                const string sql = "SELECT PhoneID, PatronID, PhoneNumber FROM PatronPhone WHERE PatronID=@id ORDER BY PhoneID";
                dgvPhones.DataSource = Database.FillDataTable(sql, new SqlParameter("@id", SelectedPatronId.Value));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Patron Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidatePatron()
        {
            if (string.IsNullOrWhiteSpace(txtFirst.Text) || string.IsNullOrWhiteSpace(txtLast.Text))
            {
                MessageBox.Show("First and last name are required.", "Validation", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (!ValidatePatron())
                return;

            try
            {
                const string sql = @"INSERT INTO Patron (FirstName, LastName, Email, RegistrationDate)
OUTPUT INSERTED.PatronID VALUES (@fn, @ln, @em, @rd)";
                var newId = Convert.ToInt32(Database.ExecuteScalar(sql,
                    new SqlParameter("@fn", txtFirst.Text.Trim()),
                    new SqlParameter("@ln", txtLast.Text.Trim()),
                    new SqlParameter("@em", txtEmail.Text.Trim()),
                    new SqlParameter("@rd", dtpRegistration.Value.Date)));

                MessageBox.Show("Patron created.", "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadPatronsCore();
                txtPatronID.Text = newId.ToString();
                LoadPhonesForPatron();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (!SelectedPatronId.HasValue)
            {
                MessageBox.Show("Select a patron.", "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!ValidatePatron())
                return;

            try
            {
                const string sql = @"UPDATE Patron SET FirstName=@fn, LastName=@ln, Email=@em, RegistrationDate=@rd
WHERE PatronID=@id";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@id", SelectedPatronId.Value),
                    new SqlParameter("@fn", txtFirst.Text.Trim()),
                    new SqlParameter("@ln", txtLast.Text.Trim()),
                    new SqlParameter("@em", txtEmail.Text.Trim()),
                    new SqlParameter("@rd", dtpRegistration.Value.Date));

                MessageBox.Show("Patron updated.", "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Information);
                BtnLoadPatronsCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (!SelectedPatronId.HasValue)
            {
                MessageBox.Show("Select a patron.", "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (MessageBox.Show("Delete patron and related phone records (if allowed by database)?", "Confirm",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Database.ExecuteNonQuery("DELETE FROM PatronPhone WHERE PatronID=@id",
                    new SqlParameter("@id", SelectedPatronId.Value));
                Database.ExecuteNonQuery("DELETE FROM Patron WHERE PatronID=@id",
                    new SqlParameter("@id", SelectedPatronId.Value));
                MessageBox.Show("Patron deleted.", "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnClear_Click(null, EventArgs.Empty);
                BtnLoadPatronsCore();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Patrons", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtPatronID.Clear();
            txtFirst.Clear();
            txtLast.Clear();
            txtEmail.Clear();
            dtpRegistration.Value = DateTime.Today;
            txtPatronSearch.Clear();
            dgvPatrons.ClearSelection();
            dgvPhones.DataSource = null;
            PhoneClearFields();
        }

        private void dgvPhones_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            var row = dgvPhones.Rows[e.RowIndex];
            txtPhoneID.Text = row.Cells["PhoneID"].Value?.ToString() ?? "";
            txtPhoneNumber.Text = row.Cells["PhoneNumber"].Value?.ToString() ?? "";
        }

        private void PhoneClearFields()
        {
            txtPhoneID.Clear();
            txtPhoneNumber.Clear();
            dgvPhones.ClearSelection();
        }

        private void btnPhoneInsert_Click(object sender, EventArgs e)
        {
            if (!SelectedPatronId.HasValue)
            {
                MessageBox.Show("Select a patron first.", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Enter a phone number.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                const string sql = "INSERT INTO PatronPhone (PatronID, PhoneNumber) VALUES (@pid, @num)";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@pid", SelectedPatronId.Value),
                    new SqlParameter("@num", txtPhoneNumber.Text.Trim()));
                MessageBox.Show("Phone saved.", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhonesForPatron();
                PhoneClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhoneUpdate_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPhoneID.Text, out var phoneId))
            {
                MessageBox.Show("Select a phone row.", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!SelectedPatronId.HasValue || string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                MessageBox.Show("Invalid data.", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                const string sql = "UPDATE PatronPhone SET PhoneNumber=@num WHERE PhoneID=@id AND PatronID=@pid";
                Database.ExecuteNonQuery(sql,
                    new SqlParameter("@id", phoneId),
                    new SqlParameter("@pid", SelectedPatronId.Value),
                    new SqlParameter("@num", txtPhoneNumber.Text.Trim()));
                MessageBox.Show("Phone updated.", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadPhonesForPatron();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhoneDelete_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtPhoneID.Text, out var phoneId))
            {
                MessageBox.Show("Select a phone row.", "Phone", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (MessageBox.Show("Delete this phone number?", "Confirm", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            try
            {
                Database.ExecuteNonQuery("DELETE FROM PatronPhone WHERE PhoneID=@id",
                    new SqlParameter("@id", phoneId));
                LoadPhonesForPatron();
                PhoneClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Phone", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPhoneClear_Click(object sender, EventArgs e)
        {
            PhoneClearFields();
        }

        private void btnPhoneReload_Click(object sender, EventArgs e)
        {
            LoadPhonesForPatron();
        }
    }
}
