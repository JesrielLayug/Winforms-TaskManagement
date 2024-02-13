using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Services.Contracts
{
    public interface ITaskService
    {
        Task<Response> Add(TaskItemEditor task);
    }
}
