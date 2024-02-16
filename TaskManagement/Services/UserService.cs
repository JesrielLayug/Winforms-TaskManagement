using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Repositories.Contracts;
using TaskManagement.Services.Contracts;

namespace TaskManagement.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;

        public UserService(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        public async Task<Response> Add(UserEditor user)
        {
            var newUser = new User();
            newUser.Role = user.Role;
            newUser.FullName = user.FullName;
            newUser.Gender = user.Gender;
            newUser.Email = user.Email;
            newUser.Password = user.Password;
            newUser.Position = user.Position;
            newUser.Authorization = user.Authorization;

            await userRepository.Add(newUser);

            return new Response
            {
                IsSuccess = true,
                Message = "Successfully added the user."
            };
        }

        public async Task<Response> ChangePassword(string email, string newPassword)
        {
            var existingUser = await userRepository.GetByEmail(email);

            if(existingUser != null)
            {
                existingUser.Password = newPassword;
                await userRepository.Update(existingUser, existingUser.Id);
                return new Response
                {
                    IsSuccess = true,
                    Message = $"Successfully changed the password of {existingUser.Email} to {newPassword}. Log in now."
                };
            }
            return new Response
            {
                IsSuccess = false,
                Message = "Email does not exist."
            };
        }

        public async Task<Response> Delete(UserEditor user)
        {
            try
            {
                var existingUser = await userRepository.GetByEmail(user.Email);
                if(existingUser != null)
                {
                    await userRepository.Delete(existingUser.Id);
                    return new Response
                    {
                        IsSuccess = true,
                        Message = "Successfully Deleted the user"
                    };
                }
                return new Response
                {
                    IsSuccess = false,
                    Message = "Failed to Deleted the user"
                };
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            try
            {
                return await userRepository.GetAll();
            }
            catch
            {
                throw;
            }
        }

        public async Task<Response> Update(User user, string name)
        {
            try
            {
                var existingUser = await userRepository.GetByName(name);
                if (existingUser != null)
                {
                    existingUser.Role = user.Role;
                    existingUser.FullName = user.FullName;
                    existingUser.Gender = user.Gender;
                    existingUser.Position = user.Position;
                    existingUser.Email = user.Email;
                    existingUser.Password = user.Password;
                    existingUser.Authorization = user.Authorization;

                    await userRepository.Update(existingUser, existingUser.Id);
                    return new Response
                    {
                        IsSuccess = true,
                        Message = "Successfuly Updated the user."
                    };
                }

                return new Response
                {
                    IsSuccess = false,
                    Message = "Failed Updated the user."
                };
            }
            catch
            {
                throw;
            }
        }
    }
}
