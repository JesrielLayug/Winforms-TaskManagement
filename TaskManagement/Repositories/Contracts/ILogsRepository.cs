using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Repositories.Contracts
{
    public interface ILogsRepository
    {
        Task Add(UserLogs logs);
        Task<IEnumerable<UserLogs>> GetByUserId(string userId);
    }
}
