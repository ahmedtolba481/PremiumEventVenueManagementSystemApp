using System;
using System.Drawing;
using System.Windows.Forms;

namespace PremiumEventVenueManagementSystemApp
{
    internal static class UiTheme
    {
        public static readonly Color InsertColor = Color.SeaGreen;
        public static readonly Color UpdateColor = Color.DarkOrange;
        public static readonly Color DeleteColor = Color.Crimson;
        public static readonly Color SearchColor = Color.DodgerBlue;
        private static readonly Color HeaderBack = Color.MidnightBlue;

        public static void ApplyGrid(DataGridView dgv)
        {
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.MultiSelect = false;
            dgv.RowHeadersVisible = false;
            dgv.ReadOnly = true;
            dgv.EnableHeadersVisualStyles = false;
            dgv.BackgroundColor = Color.WhiteSmoke;
            dgv.BorderStyle = BorderStyle.None;
            dgv.Font = new Font("Segoe UI", 10F);

            dgv.ColumnHeadersDefaultCellStyle.BackColor = HeaderBack;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            dgv.ColumnHeadersHeight = 32;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 250, 252);
            dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(59, 130, 246);
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;
        }

        public static void StyleCrudButton(Button btn, Color backColor)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = backColor;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);

            Color original = backColor;

            btn.MouseEnter += (s, e) =>
            {
                var darken = Darken(backColor);
                btn.BackColor = darken;
            };
            btn.MouseLeave += (s, e) => { btn.BackColor = original; };
        }

        private static Color Darken(Color c)
        {
            return Color.FromArgb(
                Math.Max(0, (int)(c.R * 0.85)),
                Math.Max(0, (int)(c.G * 0.85)),
                Math.Max(0, (int)(c.B * 0.85)));
        }

        public static void ApplyListStyle(ListBox lst)
        {
            lst.BorderStyle = BorderStyle.FixedSingle;
            lst.BackColor = Color.White;
            lst.Font = new Font("Segoe UI", 10F);
        }

        /// <summary>Secondary action (neutral blue-gray).</summary>
        public static void StyleMutedButton(Button btn)
        {
            var c = Color.FromArgb(75, 85, 99);
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.BackColor = c;
            btn.ForeColor = Color.White;
            btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btn.MouseEnter += (s, e) => btn.BackColor = Darken(c);
            btn.MouseLeave += (s, e) => btn.BackColor = c;
        }
    }
}
