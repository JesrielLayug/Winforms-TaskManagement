﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Repositories.Contracts
{
    public interface IEmployeeRequestRepository
    {
        Task Add(EmployeeTicket request);
        Task Update(EmployeeTicket request, string Id);
        Task Delete(string title);
        Task<IEnumerable<EmployeeTicket>> GetAllUserRequest(string employeeId);
        Task<IEnumerable<EmployeeTicket>> GetAll();
        Task<EmployeeTicket> GetById(string id);
        Task<EmployeeTicket> GetByTitle(string name);
        Task<IEnumerable<EmployeeTicket>> GetAllApproved();
    }
}
