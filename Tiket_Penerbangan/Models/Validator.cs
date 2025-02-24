using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tiket_Penerbangan.Models
{
    public static class Validator
    {
        public static (bool isValid, string errorMessage) ValidateUser(User user)
        {
            if (string.IsNullOrEmpty(user.Email)) return (false, "Email is required");
            if (!IsValidEmail(user.Email)) return (false, "Email is not valid");
            if(string.IsNullOrEmpty(user.Password)) return (false, "Password is required");
            if(user.Password.Length < 6 ) return (false, "Password must be at least 6 characters");
            if (!string.IsNullOrEmpty(user.PhoneNumber) && !IsValidPhoneNumber(user.PhoneNumber)) return (false, "Invalid phone number");
            return (true, string.Empty);
        }

        public static bool IsValidEmail(string email)
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

        private static bool IsValidPhoneNumber(string phoneNubmer)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(phoneNubmer, @"^\+[0-9]{1,3}-[0-9]{3}-[0-9]{6,12}$");
        }

    }
}
