using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiket_Penerbangan.Models;

namespace Tiket_Penerbangan.DataAccess
{
    public class UserRepository
    {
        private readonly string _connectionString;

        public UserRepository(string connectionString)
        {
            _connectionString = connectionString;
        }

        public async Task<bool> RegisterUser(User user)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var checkCmd = new SqlCommand(
                    "SELECT COUNT(*) FROM Users WHERE Email = @Email",
                    connection);
                checkCmd.Parameters.AddWithValue("@Email", user.Email);

                int exists = (int)await checkCmd.ExecuteScalarAsync();
                if (exists > 0)
                    return false;

                string hashedPassword = BCrypt.Net.BCrypt.HashPassword(user.Password);

                var cmd = new SqlCommand(
                    "INSERT INTO Users (Email, Password, Name, PhoneNumber, Role) " +
                    "VALUES (@Email, @Password, @Name, @PhoneNumber, @Role)",
                    connection);

                cmd.Parameters.AddWithValue("@Email", user.Email);
                cmd.Parameters.AddWithValue("@Password", hashedPassword);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@PhoneNumber", user.PhoneNumber ?? (object)DBNull.Value);
                cmd.Parameters.AddWithValue("@Role", user.Role);

                await cmd.ExecuteNonQueryAsync();
                return true;
            }
        }

        public async Task<User> ValidateLogin(string email, string password)
        {
            using (var connection = new SqlConnection(_connectionString))
            {
                await connection.OpenAsync();

                var cmd = new SqlCommand(
                    "SELECT UserId, Email, Password, Name, PhoneNumber, Role " +
                    "FROM Users WHERE Email = @Email",
                    connection);
                cmd.Parameters.AddWithValue("@Email", email);

                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    if (!await reader.ReadAsync())
                        return null;

                    string hashedPassword = reader["Password"].ToString();
                    if (!BCrypt.Net.BCrypt.Verify(password, hashedPassword))
                        return null;

                    return new User
                    {
                        UserId = (int)reader["UserId"],
                        Email = reader["Email"].ToString(),
                        Name = reader["Name"].ToString(),
                        PhoneNumber = reader["PhoneNumber"] == DBNull.Value ? null : reader["PhoneNumber"].ToString(),
                        Role = reader["Role"].ToString()
                    };
                }
            }
        }
    }
}
