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

            await userRepository.Add(newUser);

            return new Response
            {
                IsSuccess = true,
                Message = "Successfully added the user."
            };
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
    }
}
