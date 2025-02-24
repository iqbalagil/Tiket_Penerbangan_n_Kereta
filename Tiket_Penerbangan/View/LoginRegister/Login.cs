using CuoreUI;
using Guna.UI2.WinForms;
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
using Tiket_Penerbangan.DataAccess;

namespace Tiket_Penerbangan.LoginRegister
{
    public partial class Login : Form
    {
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);


        public Login()
        {
            InitializeComponent();
            InitializeLoginControl();
        }

        private void TitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(this.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void InitializeLoginControl()
        {
            guna2ContainerControl1.Controls.Clear();
            LoginControl login = new LoginControl();
            login.Dock = DockStyle.Right;
            guna2ContainerControl1.Controls.Add(login);
        }


    }
}
