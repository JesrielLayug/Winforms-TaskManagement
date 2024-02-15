using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Repositories.Contracts
{
    public interface IEmployeeRequestRepository
    {
        Task Add(EmployeeRequest request);
        Task Update(EmployeeRequest request, string Id);
        Task<IEnumerable<EmployeeRequest>> GetAll(string employeeId);
        Task<EmployeeRequest> GetById(string id);
    }
}
