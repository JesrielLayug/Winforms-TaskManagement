using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Services.Contracts
{
    public interface ITicketService
    {
        Task<Response> Add(TicketEditor task);
        Task<Response> Delete(string id);
        Task<Response> Update(TicketEditor ticket, string id);
        Task<IEnumerable<TicketInfo>> GetAll();
        Task<TicketInfo> GetById(string id);
        Task<IEnumerable<TicketInfo>> GetByAssignUser();
    }
}
