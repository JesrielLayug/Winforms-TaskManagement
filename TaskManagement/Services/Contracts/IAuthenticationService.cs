using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Services.Contracts
{
    public interface IAuthenticationService
    {
        Task<Response> Register(UserEditor user);
        Task<Response> Login(string email, string password);
        Task<Response> Logout();
        Task<Response> ResetPassword(string email, string newPassword);
        void CreatePasswordHash(string password, out byte[] hash, out byte[] salt);
        bool VerifyPasswordHash(string password, byte[] hash, byte[] salt);
    }
}
