using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        public async Task<Response> Register(UserEditor user)
        {
            CreatePasswordHash(user.Password, out byte[] hash, out byte[] salt);

            var newUser = new User();
            newUser.Role = user.Role;
            newUser.FullName = user.FullName;
            newUser.Gender = user.Gender;
            newUser.Email = user.Email;
            newUser.PasswordHash = hash;
            newUser.PasswordSalt = salt;
            newUser.Position = user.Position;
            newUser.Authorization = user.Authorization;

            await userRepository.Add(newUser);

            return new Response
            {
                IsSuccess = true,
                Message = "Successfully added the user."
            };
        }

        public async Task<Response> Login(string email, string password)
        {
            var existingUser = await userRepository.GetByEmail(email);
            if(existingUser != null)
            {
                if(existingUser.Role == "Admin")
                {

                    if (VerifyPasswordHash(password, existingUser.PasswordHash, existingUser.PasswordSalt))
                    {

                        settingsProvider.SaveUserToSettings(existingUser);

                        return new Response
                        {
                            IsAuthorized = true,
                            IsSuccess = true,
                            Message = "Successfully login.",
                            Role = existingUser.Role
                        };
                    }
                }
                else
                {
                    if (existingUser.Authorization == "Allowed")
                    {
                        if (VerifyPasswordHash(password, existingUser.PasswordHash, existingUser.PasswordSalt))
                        {

                            settingsProvider.SaveUserToSettings(existingUser);

                            return new Response
                            {
                                IsAuthorized = true,
                                IsSuccess = true,
                                Message = "Successfully login.",
                                Role = existingUser.Role
                            };
                        }
                    }
                    else
                    {
                        return new Response
                        {
                            IsAuthorized = false,
                            Message = "Sorry you're account was blocked."
                        };
                    }
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

        public async Task<Response> ResetPassword(string email, string newPassword)
        {
            var existingUser = await userRepository.GetByEmail(email);
            if(existingUser != null)
            {
                CreatePasswordHash(newPassword, out byte[] hash, out byte[] salt);

                existingUser.PasswordSalt = salt;
                existingUser.PasswordHash = hash;

                await userRepository.Update(existingUser, existingUser.Id);
                return new Response
                {
                    IsSuccess = true,
                    Message = "Successfully changed the password."
                };
            }

            return new Response
            {
                IsSuccess = false,
                Message = "Email does not exist."
            };
        }

        public void CreatePasswordHash(string password, out byte[] hash, out byte[] salt)
        {
            using (var hmac = new HMACSHA512())
            {
                salt = hmac.Key;
                hash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
            }
        }

        public bool VerifyPasswordHash(string password, byte[] hash, byte[] salt)
        {
            using (var hmac = new HMACSHA512(salt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(hash);
            }
        }

    }
}
