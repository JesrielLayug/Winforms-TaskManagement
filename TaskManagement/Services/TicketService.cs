using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Repositories.Contracts;
using TaskManagement.Services.Contracts;

namespace TaskManagement.Services
{
    public class TicketService : ITicketService
    {
        private readonly ITicketRepository ticketRepository;
        private readonly IUserRepository userRepository;

        public TicketService(ITicketRepository ticketRepository, IUserRepository userRepository)
        {
            this.ticketRepository = ticketRepository;
            this.userRepository = userRepository;
        }

        public async Task<Response> Add(TicketEditor task)
        {
            try
            {
                var assignee = await userRepository.GetByName(task.AssignName);
                var creator = await userRepository.GetByName(task.CreatedBy);

                var taskTobeAdded = new Ticket
                {
                    Title = task.Title,
                    AssignUserId = assignee.Id,
                    Priority = task.Priority,
                    Division = task.Division,
                    TicketStatus = task.TicketStatus,
                    StartDate = task.StartDate,
                    DueDate = task.DueDate,
                    Description = task.Description,
                    IsDeleted = false,
                    CreatorId = creator.Id
                };

                if (creator.Role == "Admin")
                    taskTobeAdded.IsApprove = true;
                else
                    taskTobeAdded.IsApprove = false;

                await ticketRepository.Add(taskTobeAdded);

                return new Response
                {
                    IsSuccess = true,
                    Message = "Successfully added the task."
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    IsError = true,
                    Message = ex.Message,
                };
            }

        }

        public async Task<IEnumerable<TicketInfo>> GetAll()
        {
            try
            {
                var tickets = await ticketRepository.GetAll();
                var users = await userRepository.GetAll();

                return (from ticket in tickets
                        join creatorUser in users on ticket.CreatorId equals creatorUser.Id
                        join assignedUser in users on ticket.AssignUserId equals assignedUser.Id
                        select new TicketInfo
                        {
                            Id = ticket.Id,
                            Title = ticket.Title,
                            AssignUserId = ticket.AssignUserId,
                            AssignUserName = assignedUser.FullName,
                            AssignRole = assignedUser.Role,
                            Priority = ticket.Priority,
                            Division = ticket.Division,
                            TicketStatus = ticket.TicketStatus,
                            StartDate = ticket.StartDate,
                            DueDate = ticket.DueDate,
                            Description = ticket.Description,
                            IsApprove = ticket.IsApprove,
                            IsDeleted = ticket.IsDeleted,
                            CreatorId = creatorUser.Id,
                            CreatorFullName = creatorUser.FullName,
                            CreatorRole = creatorUser.Role
                        }).ToList();
            }
            catch
            {
                throw;
            }
        }
    }
}
