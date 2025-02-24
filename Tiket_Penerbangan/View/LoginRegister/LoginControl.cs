using System;
using System.ComponentModel;
using System.Drawing;
using System.Data.SqlClient;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tiket_Penerbangan.Models;
using Tiket_Penerbangan.View.CustomerDashboard;
using Tiket_Penerbangan.View;

namespace Tiket_Penerbangan.LoginRegister
{
    public partial class LoginControl : UserControl
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        private ErrorProvider errorProvider = new ErrorProvider();

        public LoginControl()
        {
            InitializeComponent();
        }

        private void TextEmailValidate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(emailTextBox.Text))
            {
                errorProvider.SetError(emailTextBox, "Email perlu di isi");
                return;
            }
            else
            {
                errorProvider.Clear();
                emailTextBox.BorderColor = Color.LightGreen;
            }
        }

        private void TextPasswordValidate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(passwordTextBox.Text))
            {
                errorProvider.SetError(passwordTextBox, "Password is required");
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
                string username = emailTextBox.Text;
                string password = passwordTextBox.Text;

                if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
                {
                    return;
                }

                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    var penumpangCmd = new SqlCommand(
                        "SELECT PenumpangId, Username, Name FROM Penumpangs WHERE Username = @Username AND Password = @Password",
                        connection);
                    penumpangCmd.Parameters.AddWithValue("@Username", username);
                    penumpangCmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = await penumpangCmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            CurrentUser.SetUser((int)reader["PenumpangId"], reader["Username"].ToString(), reader["Name"].ToString(), "Customer");
                            new CustomerDashboardPanel().Show();
                            this.Hide();
                            return;
                        }
                    }

                    var petugasCmd = new SqlCommand(
                        "SELECT p.PetugasId, p.Username, p.Name, p.LevelId, pl.LevelName, pl.Gaji " +
                        "FROM Petugas p " +
                        "LEFT JOIN PetugasLevel pl ON p.LevelId = pl.LevelId " +
                        "WHERE p.Username = @Username AND p.Password = @Password",
                        connection);
                    petugasCmd.Parameters.AddWithValue("@Username", username);
                    petugasCmd.Parameters.AddWithValue("@Password", password);

                    using (var reader = await petugasCmd.ExecuteReaderAsync())
                    {
                        if (await reader.ReadAsync())
                        {
                            CurrentUser.SetUser((int)reader["PetugasId"], reader["Username"].ToString(), reader["Name"].ToString(), "Petugas", (int)reader["LevelId"]);
                            new AdminDashboardPanel().Show();
                            this.Hide();
                            return;
                        }
                    }

                    MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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