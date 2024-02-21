using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Services.Contracts
{
    public interface ILogsService
    {
        Task Add(string action);
        Task<IEnumerable<UserLogsEditor>> GetLogs();
    }
}
