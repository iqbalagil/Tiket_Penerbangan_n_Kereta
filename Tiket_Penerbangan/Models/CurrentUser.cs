using System;

namespace Tiket_Penerbangan.Models
{
    public class CurrentUser
    {
        public static int UserId { get; set; }
        public static string Username { get; set; }
        public static string Name { get; set; }
        public static string Role { get; set; }
        public static int LevelId { get; set; }

        public static void SetUser(int userId, string username, string name, string role, int levelId = 0)
        {
            UserId = userId;
            Username = username;
            Name = name;
            Role = role;
            LevelId = levelId;
        }

        public static void Clear()
        {
            UserId = 0;
            Username = null;
            Name = null;
            Role = null;
            LevelId = 0;
        }
    }
}
