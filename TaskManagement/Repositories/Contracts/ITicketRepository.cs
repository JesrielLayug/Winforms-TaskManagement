using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;

namespace TaskManagement.Repositories.Contracts
{
    public interface ITicketRepository
    {
        Task Add(Ticket task);
        Task Delete (string id);
        Task Update(Ticket ticket, string id);
        Task<IEnumerable<Ticket>> GetAll();
    }
}
