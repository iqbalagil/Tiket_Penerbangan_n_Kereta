using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI2.WinForms;

namespace Tiket_Penerbangan
{
    public partial class PenambahData : Form
    {

        public PenambahData()
        {
            InitializeComponent();
        }

        private void textBoxNama_EnterLeave(object sender, EventArgs e)
        {
            OnTextBoxEnterLeave(sender, namaLengkap, e);
        }

        private void textBoxTelepon_EnterLeave(object sender, EventArgs e)
        {
            OnTextBoxEnterLeave(sender, nomorTelepon, e);
        }

        private void textBoxEmail_EnterLeave(object sender, EventArgs e)
        {
            OnTextBoxEnterLeave(sender, alamatEmail, e);
        }


        private void OnTextBoxEnterLeave(object sender, Label placeholder, EventArgs e)
        {
            if (sender is Guna2TextBox textBox)
            {
                if (textBox.Focused)
                {
                    OnEnter(placeholder, textBox);
                }
                else
                {
                    OnLeave(placeholder, textBox);
                }
            }
        }


        private void OnEnter(object placeholder, Guna2TextBox tb)
        {
            if (placeholder is Label ph)
            {
                ph.Location = new Point(tb.Location.X + 3, tb.Location.Y - 10);
            }
        }

        private void OnLeave(object placeholder, Guna2TextBox tb)
        {
            if (placeholder is Label ph)
            {
                ph.Location = new Point(tb.Location.X + 3, tb.Location.Y + 10);
            }
        }

    }
}
