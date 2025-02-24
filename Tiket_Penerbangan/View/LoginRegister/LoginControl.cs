using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiket_Penerbangan.DataAccess;
using Tiket_Penerbangan.View.CustomerDashboard;

namespace Tiket_Penerbangan.LoginRegister
{
    public partial class LoginControl: UserControl
    {
        private string connectionString = @"Data Source=DESKTOP-FUM0LMT\TIKEXPRESS;Initial Catalog=tiketPenerbangan;Persist Security Info=True;User ID=iqbal;Password=akuiqbal;Trust Server Certificate=True";

        private readonly UserRepository _userRepository;
        private ErrorProvider errorProvider = new ErrorProvider();

        public LoginControl()
        {
            InitializeComponent();
        }

        private void TextEmailValidate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                errorProvider.SetError(emailTextBox, "Email perlu di isi");
                emailTextBox.BorderColor = Color.Red;
                e.Cancel = true;
                return;
            }
            else if (emailTextBox.Text.Contains('@') == false)
            {
                errorProvider.SetError(emailTextBox, "Email tidak valid");
                emailTextBox.BorderColor = Color.Red;
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider.Clear();
                emailTextBox.BorderColor = Color.LightGreen;
            }
        }

        private void TextPasswordValidate(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                errorProvider.SetError(passwordTextBox, "Password is required");
                passwordTextBox.BorderColor = Color.Red;
                e.Cancel = true;
                return;
            }
            else
            {
                errorProvider.Clear();
                emailTextBox.BorderColor = Color.LightGreen;
            }
        }

        private async void loginBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string email = emailTextBox.Text;
                string password = passwordTextBox.Text;

                if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    return;
                }

                var user = await _userRepository.ValidateLogin(email, password);
                if (user != null)
                {
                    //switch (user.Role.ToLower())
                    //{
                    //    case "admin":
                    //        new AdminDashboardPanel().Show();
                    //        break;
                    //    case "petugas":
                    //        new AdminDashboardPanel().Show();
                    //        break;
                    //    default:
                    //        new CustomerDashboardPanel().Show();
                    //        break;

                    //}
                    //this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid email or passwrod.", "Login Failed",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occured: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void revealPasswordS(object sender, EventArgs e)
        {
            passwordTextBox.UseSystemPasswordChar = !revealPassword.Checked;
            if (revealPassword.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void signUplink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            signUplink.LinkClicked += (s, c) =>
            {
                this.Controls.Clear();
                this.Controls.Add(new RegisterControl());
            };
        }
    }
}
