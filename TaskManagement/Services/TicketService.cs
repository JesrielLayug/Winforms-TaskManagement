using Amazon.Runtime.Internal.Util;
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
                    DateCreated = DateTime.Now,
                    Description = task.Description,
                    IsApproved = task.IsApproved,
                    CreatorId = creator.Id
                };

                //if (creator.Role == "Admin")
                //    taskTobeAdded.IsApproved = true;
                //else
                //    taskTobeAdded.IsApproved = false;

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

        public async Task<Response> Delete(string id)
        {
            try
            {
                await ticketRepository.Delete(id);
                return new Response
                {
                    IsSuccess = true,
                    Message = "Successfully Deleted"
                };
            }
            catch
            {
                throw;
            }
        }

        public async Task<Response> Update(TicketEditor ticket, string id)
        {
            try
            {
                var assignee = await userRepository.GetByName(ticket.AssignName);
                var creator = await userRepository.GetByName(ticket.CreatedBy);

                var ticketTobeUpdate = new Ticket
                {
                    Id = id,
                    Title = ticket.Title,
                    AssignUserId = assignee.Id,
                    Priority = ticket.Priority,
                    Division = ticket.Division,
                    TicketStatus = ticket.TicketStatus,
                    StartDate = ticket.StartDate,
                    DueDate = ticket.DueDate,
                    DateCreated = DateTime.Now,
                    Description = ticket.Description,
                    IsApproved = ticket.IsApproved,
                    CreatorId = creator.Id,
                };

                await ticketRepository.Update(ticketTobeUpdate, id);
                return new Response
                {
                    IsSuccess = true,
                    Message = "Successfully Updated."
                };
            }
            catch
            {
                throw;
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
                            DateCreated = ticket.DateCreated,
                            Description = ticket.Description,
                            IsApproved = ticket.IsApproved,
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

        public async Task<TicketInfo> GetById(string id)
        {
            try
            {
                var existingTicket = await ticketRepository.GetById(id);
                var assignUser = await userRepository.GetById(existingTicket.AssignUserId);
                var creatorUser = await userRepository.GetById(existingTicket.CreatorId);

                var ticket = new TicketInfo
                {
                    Id = existingTicket.Id,
                    Title = existingTicket.Title,
                    AssignUserId = existingTicket.AssignUserId,
                    AssignUserName = assignUser.FullName,
                    AssignRole = assignUser.Role,
                    Priority = existingTicket.Priority,
                    Division= existingTicket.Division,
                    TicketStatus = existingTicket.TicketStatus,
                    StartDate = existingTicket.StartDate,
                    DueDate= existingTicket.DueDate,
                    DateCreated= existingTicket.DateCreated,
                    Description=existingTicket.Description,
                    IsApproved =existingTicket.IsApproved,
                    CreatorId =existingTicket.CreatorId,
                    CreatorFullName = creatorUser.FullName,
                    CreatorRole=creatorUser.Role,
                };

                return ticket;
            }
            catch
            {
                throw;
            }
        }
    }
}
