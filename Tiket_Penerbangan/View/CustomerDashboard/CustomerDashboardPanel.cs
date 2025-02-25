﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiket_Penerbangan.View.CustomerDashboard.ContentTemplate;

namespace Tiket_Penerbangan.View.CustomerDashboard
{
    public partial class CustomerDashboardPanel: Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);

        public CustomerDashboardPanel()
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

        private void PemesananNavigation()
        {
            container.Controls.Clear();
            PemesananContent content = new PemesananContent();
            content.Dock = DockStyle.Fill;
            container.Controls.Add(content);
        }

        private void BookingNavigation()
        {
            container.Controls.Clear();
            BookingPesawat content = new PemesananContent();
            content.Dock = DockStyle.Fill;
            container.Controls.Add(content);
        }
    }
}
