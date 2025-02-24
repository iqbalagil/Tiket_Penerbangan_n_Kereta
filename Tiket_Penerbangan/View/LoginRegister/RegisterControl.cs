using System;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tiket_Penerbangan.LoginRegister
{

    public partial class RegisterControl: UserControl
    {
        private readonly ErrorProvider error;
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        public RegisterControl()
        {
            InitializeComponent();
            
            error = new ErrorProvider();
            error.BlinkStyle = ErrorBlinkStyle.NeverBlink;

            txtUsername.Validating += TxtUsername_Validate;
            txtEmail.Validating += TxtEmail_Validating;
            txtPassword.Validating += TxtPassword_Validating;
            txtVerifyPassword.Validating += TxtVerifyPassword_Validating;
        }

        private void TxtUsername_Validate(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                error.SetError(txtUsername, "Email is required");
                txtUsername.BorderColor = System.Drawing.Color.Red;
                e.Cancel = true;
                return;
            }
            if(txtUsername.Text.Length < 3)
            {
                error.SetError(txtUsername, "Email must be at least 3 characters long");
                txtUsername.BorderColor = System.Drawing.Color.Red;
                e.Cancel = true;
                return;
            }
            if (!Regex.IsMatch(txtUsername.Text, "^[a-zA-Z0-9_]+$"))
            {
                error.SetError(txtUsername, "Username can only contain letters, numbers, and underscores");
                txtUsername.BorderColor = System.Drawing.Color.Red;
                e.Cancel = true;
                return;
            }
            else
            {
                txtUsername.BorderColor = Color.LightGreen;
                error.Clear();
            }

                
        }

        private void TxtEmail_Validating(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                error.SetError(txtEmail, "Email is required");
                return;
            }

            if (!IsValidEmail(txtEmail.Text))
            {
                error.SetError(txtEmail, "Invalid email format");
                return;
            }
            else
            {
                txtEmail.BorderColor = Color.LightGreen;
                error.Clear();
            }
        }

        private void TxtPassword_Validating(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                error.SetError(txtPassword, "Password is required");
                return;
            }

            if (txtPassword.Text.Length < 6)
            {
                error.SetError(txtPassword, "Password must be at least 6 characters");
                return;
            }

            if (!IsPasswordStrong(txtPassword.Text))
            {
                error.SetError(txtPassword, "Password must contain at least one uppercase letter, one lowercase letter, and one number");
                return;
            } else
            {
                txtPassword.BorderColor = Color.LightGreen;
                error.Clear();
            }
        }

        private void TxtVerifyPassword_Validating(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtVerifyPassword.Text))
            {
                error.SetError(txtVerifyPassword, "Please confirm your password");
                return;
            }

            if (txtPassword.Text != txtVerifyPassword.Text)
            {
                error.SetError(txtVerifyPassword, "Passwords do not match");
                return;
            }

            else
            {
                txtVerifyPassword.BorderColor = Color.LightGreen;
                error.Clear();
            }

        }

        private bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch
            {
                return false;
            }
        }

        private bool IsPasswordStrong(string password)
        {
            return Regex.IsMatch(password, @"[A-Z]") && 
                   Regex.IsMatch(password, @"[a-z]") && 
                   Regex.IsMatch(password, @"[0-9]");   
        }

        public bool ValidateAll()
        {
            bool isValid = true;

            var e = new CancelEventArgs();

            TxtUsername_Validate(txtUsername, e);
            if (e.Cancel) isValid = false;

            TxtEmail_Validating(txtEmail, e);
            if (e.Cancel) isValid = false;

            TxtPassword_Validating(txtPassword, e);
            if (e.Cancel) isValid = false;

            TxtVerifyPassword_Validating(txtVerifyPassword, e);
            if (e.Cancel) isValid = false;

            return isValid;
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {
            if (!ValidateAll())
            {
                MessageBox.Show("Please fix all validation errors before proceeding.",
                    "Validation Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            } else
            {
                try
                {
                    using(SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        string checkQuery = "SELECT COUNT(*) FROM Penumpang WHERE Email = @Email";
                        using(SqlCommand checkCmd = new SqlCommand(checkQuery, conn))
                        {
                            checkCmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            int exists = (int)checkCmd.ExecuteScalar();
                            if (exists > 0)
                            {
                                MessageBox.Show("Email sudah terdaftar, Silahkan gunakan email lain", "Registration Failed",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return;
                            }
                        }

                        string insertQuery = @"INSERT INTO Penumpangs (Email, Password, Username, NoTelepon, Role) " +
                            "VALUES (@Email, @Password, @Name, @NoTelepon, @Role)";

                        using (SqlCommand cmd = new SqlCommand(insertQuery, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                            cmd.Parameters.AddWithValue("@Password", txtPassword.Text);
                            cmd.Parameters.AddWithValue("@Name", txtUsername.Text);
                            cmd.Parameters.AddWithValue("@PhoneNumber", DBNull.Value);
                            cmd.Parameters.AddWithValue("@Role", "customer");
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Registration successful", "Registration Success",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

                            int result = cmd.ExecuteNonQuery();
                            if(result > 0)
                            {
                                MessageBox.Show("Regsitrasi berhasil silakan login.",
                                    "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information);
                               
                            }
                            else
                            {
                                MessageBox.Show("Registrasi gagal, silakan coba lagi.",
                                     "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Terjadi kesalahan: {ex.Message}",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
            }
        }

        private void changeStatePassword(object sender, EventArgs e)
        {
            txtVerifyPassword.UseSystemPasswordChar = !revealPassword.Checked;
            if (revealPassword.Checked == true) txtVerifyPassword.PasswordChar = '\0';
            else txtVerifyPassword.PasswordChar = '*';

        }

        private void changeStatePasswordVerify(object sender, EventArgs e)
        {
            txtVerifyPassword.UseSystemPasswordChar = !revealPassword2.Checked;
            if(revealPassword2.Checked == true) txtVerifyPassword.PasswordChar = '\0';
            else txtVerifyPassword.PasswordChar = '*';
        }

        private void guna2ImageButton1_Click(object sender, EventArgs e)
        {
            backBtn.Click += (s, c) =>
            {
                this.Controls.Clear();
                this.Controls.Add(new LoginControl());
            };


        }
    }
}
