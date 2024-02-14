﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Services.Contracts
{
    public interface IUserService
    {
        Task<Response> Add(UserEditor user);
        Task<Response> Update(User user, string name);
        Task<Response> Delete(UserEditor user);
        Task<IEnumerable<User>> GetAll();
    }
}
