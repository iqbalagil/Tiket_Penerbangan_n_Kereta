using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiket_Penerbangan.Models;
using Tiket_Penerbangan.View.AdminDashboard.ContentPanel;

namespace Tiket_Penerbangan.View
{
    public partial class AdminDashboardPanel : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public AdminDashboardPanel()
        {
            InitializeComponent();
        }
        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void LoadControl(UserControl control)
        {
            container.Controls.Clear();
            control.Dock = DockStyle.Fill;
            container.Controls.Add(control);
        }

        private void dashboardMenu_Click(object sender, EventArgs e)
        {
            LoadControl(new DashboardControl());
        }

        private void flightMenu_Click(object sender, EventArgs e)
        {
            LoadControl(new FlightControl());
        }

        private void userManagementMenu_Click(object sender, EventArgs e)
        {
            if (CurrentUser.Role == "manager")
            {
                LoadControl(new UserManagementControl());
            }
            else
            {
                MessageBox.Show("Access denied. Only super admin can access this section.", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
