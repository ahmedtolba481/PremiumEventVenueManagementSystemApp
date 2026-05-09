using System;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    public partial class MainForm : Form
    {
        [DllImport("user32.dll")]
        private static extern int SendMessage(IntPtr hWnd, int msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        private static extern bool ReleaseCapture();

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;

        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFormFromType(Type formType)
        {
            OpenForm((Form)Activator.CreateInstance(formType));
        }

        private void OpenForm(Form childForm)
        {
            for (var i = pnlMain.Controls.Count - 1; i >= 0; i--)
            {
                var c = pnlMain.Controls[i];
                if (c is Form f)
                {
                    pnlMain.Controls.Remove(f);
                    f.Dispose();
                }
            }

            if (childForm is DashboardForm dashboard)
                dashboard.Navigate = OpenFormFromType;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            pnlMain.Controls.Add(childForm);
            pnlMain.Controls.SetChildIndex(childForm, Math.Max(0, pnlMain.Controls.Count - 1));
            childForm.Show();
            childForm.Focus();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenForm(new DashboardForm());
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
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
            OpenForm(new DashboardForm());
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
    }
}
