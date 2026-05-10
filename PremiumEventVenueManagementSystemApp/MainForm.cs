using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void OpenForm(Form form)
        {
            // Remove old forms/controls
            pnlMain.Controls.Clear();

            // Make form work inside panel
            form.TopLevel = false;

            // Remove borders
            form.FormBorderStyle = FormBorderStyle.None;

            // Fill the panel
            form.Dock = DockStyle.Fill;

            // Add form into panel
            pnlMain.Controls.Add(form);

            // Show form
            form.Show(); }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm(this));
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private readonly Color _chromeBtnDefault = Color.FromArgb(31, 41, 55);
        private readonly Color _chromeBtnHover = Color.FromArgb(55, 65, 81);

        private void btnChrome_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button b)
                b.BackColor = _chromeBtnHover;
        }

        private void btnChrome_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button b)
                b.BackColor = _chromeBtnDefault;
        }

        private readonly Color _sidebarBg = Color.FromArgb(55, 65, 81);
        private readonly Color _sidebarHover = Color.FromArgb(75, 85, 104);

        private void SidebarBtn_MouseEnter(object sender, EventArgs e)
        {
            if (sender is Button b)
                b.BackColor = _sidebarHover;
        }

        private void SidebarBtn_MouseLeave(object sender, EventArgs e)
        {
            if (sender is Button b)
                b.BackColor = _sidebarBg;
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm(this));
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenForm(new PatronForm());
        }

        private void btnGathering_Click(object sender, EventArgs e)
        {
            OpenForm(new GatheringForm());
        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenForm(new TicketCategoryForm());
        }

        private void Purchases_Click(object sender, EventArgs e)
        {
            OpenForm(new PurchaseForm());
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            OpenForm(new TechnicalStaffForm());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            OpenForm(new VenueForm());
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            OpenForm(new ReportsForm());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnEntryPass_Click(object sender, EventArgs e)
        {
            OpenForm(new EntryPassForm());
        }
    }
}
