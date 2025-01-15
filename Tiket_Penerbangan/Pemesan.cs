using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Tiket_Penerbangan
{
    public partial class Pemesan : Form
    {

        SqlConnection conn;

        public Pemesan()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
        }


        private void LoadDataFlightCard()
        {

        }


        private void ChangeView(object view)
        {

            if (guna2Panel3.Controls.Count > 0) guna2Panel3.Controls.Clear();
            if (view == null) throw new ArgumentNullException(nameof(view));
            Form form = view as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            guna2Panel3.Controls.Add(form);
            guna2Panel3.Tag = form;
            form.Show();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            ChangeView(new Kereta());
        }

        private void Pemesanan_Click(object sender, EventArgs e)
        {
            ChangeView(new Pemesan());
        }

    }

    public class Flight
    {
        public string FlightLogo { get; set; }
        public string FlightName { get; set; }
        public string Checkin { get; set; }
        public string CheckOut { get; set; }
        public string Destination { get; set; }
        public decimal Price { get; set; }
    }
}
