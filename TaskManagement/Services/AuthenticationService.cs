using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Repositories.Contracts;
using TaskManagement.Services.Contracts;

namespace TaskManagement.Services
{
    public class AuthenticationService : IAuthenticationService
    {
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
    }
}
