using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Utilities
{
    public class UserSettingsProvider
    {
        private const string fileName = "app-settings.json";
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        private User GetUserFromSettings()
        {
            string jsonString = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<User>(jsonString);
        }

        public string GetCurrentUserId()
        {
            User user = GetUserFromSettings();
            return user.Id;
        }

        public string GetCurrentUserName()
        {
            User user = GetUserFromSettings();
            return user.FullName;
        }

        public string GetCurrentUserRole()
        {
            User user = GetUserFromSettings();
            return user.Role;
        }

        public void SaveUserToSettings(User user)
        {
            string jsonString = JsonSerializer.Serialize(user);
            File.WriteAllText(filePath, jsonString);
        }

        public void RemoveUserToSettings()
        {
            File.WriteAllText(filePath, string.Empty);
        }
    }
}
