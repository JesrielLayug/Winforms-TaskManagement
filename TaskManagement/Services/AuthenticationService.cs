using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Repositories.Contracts;
using TaskManagement.Services.Contracts;

namespace TaskManagement.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private const string fileName = "app-settings.json";
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        private readonly IUserRepository userRepository;

        public AuthenticationService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<Response> Login(string email, string password)
        {
            var existingUser = await userRepository.GetByEmail(email);
            if(existingUser != null)
            {
                if(existingUser.Password == password)
                {

                    string jsonString = JsonSerializer.Serialize(existingUser);

                    File.WriteAllText(filePath, jsonString);

                    return new Response
                    {
                        IsSuccess = true,
                        Message = "Successfully login.",
                        Role = existingUser.Role
                    };
                }
                return new Response
                {
                    IsWrongPassword = true,
                    Message = "Incorrect Password."
                };
            }
            return new Response
            {
                IsWrongEmail = true,
                Message = "Email does not exist."
            };
        }

        public async Task<Response> Logout()
        {
            if (File.Exists(filePath))
            {
                File.WriteAllText(filePath, string.Empty);

                return new Response
                {
                    IsSuccess = true,
                    Message = "Successfully logged out user."
                };
            }
            return new Response
            {
                IsSuccess = false,
                Message = "Failed to log out user."
            };
        }
    }
}
