using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Repositories.Contracts
{
    public interface IUserRepository
    {
        Task Add(User user);
        Task Update(User user, string id);
        Task Delete(string id);
        Task<User> GetByEmail(string email);
        Task<User> GetByName(string name);
        Task<User> GetById(string id);
        Task<IEnumerable<User>> GetAllEmployee();
        Task<IEnumerable<User>> GetAllAdminAndEmployee();
    }
}
