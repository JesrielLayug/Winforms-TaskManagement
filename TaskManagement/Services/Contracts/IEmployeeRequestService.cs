using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Services.Contracts
{
    public interface IEmployeeRequestService
    {
        Task<Response> Add(EmployeeSubRequest request);
        Task<IEnumerable<EmployeeSubRequest>> GetAll();
    }
}
