using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Repositories.Contracts;
using TaskManagement.Services.Contracts;
using TaskManagement.Utilities;

namespace TaskManagement.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        UserSettingsProvider settingsProvider = new UserSettingsProvider();

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

                    settingsProvider.SaveUserToSettings(existingUser);

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
            settingsProvider.RemoveUserToSettings();
            return new Response
            {
                IsSuccess = true,
                Message = "Successfully logged out user."
            };
        }
    }
}
