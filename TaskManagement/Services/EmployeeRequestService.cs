using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Repositories.Contracts;
using TaskManagement.Services.Contracts;
using TaskManagement.Utilities;

namespace TaskManagement.Services
{
    public class EmployeeRequestService : IEmployeeRequestService
    {
        UserSettingsProvider settingsProvider = new UserSettingsProvider();

        private readonly IEmployeeRequestRepository employeeRequestRepository;

        public EmployeeRequestService(IEmployeeRequestRepository employeeRequestRepository)
        {
            this.employeeRequestRepository = employeeRequestRepository;
        }

        public async Task<Response> Add(EmployeeSubRequest request)
        {
            try
            {
                var currentUserId = settingsProvider.GetCurrentUserId();
                var currentUserName = settingsProvider.GetCurrentUserName();

                var newRequest = new EmployeeRequest
                {
                    TicketId = request.TicketId,
                    Title = request.Title,
                    AssignName = request.AssignName,
                    Priority = request.Priority,
                    Division = request.Division,
                    TicketStatus = request.TicketStatus,
                    StartDate = request.StartDate,
                    DueDate = request.DueDate,
                    Description = request.Description,
                    IsApproved = false,
                    IsCancelled = false,
                    RequestorId = currentUserId,
                    DateRequestCreated = DateTime.Now,
                    RequestorName = currentUserName,
                };

                if (request.IsApproved == false)
                    newRequest.Request = "Add";
                else
                    newRequest.Request = "Update";

                await employeeRequestRepository.Add(newRequest);
                return new Response
                {
                    IsSuccess = true,
                    Message = "Ticket successfully requested."
                };

            } 
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<EmployeeSubRequest>> GetAll()
        {
            try
            {
                List<EmployeeSubRequest> requests = new List<EmployeeSubRequest>();

                var currentUserId = settingsProvider.GetCurrentUserId();

                var domainRequests = await employeeRequestRepository.GetAll(currentUserId);

                foreach(var item in domainRequests)
                {
                    requests.Add(new EmployeeSubRequest
                    {
                        Id = item.Id,
                        TicketId = item.TicketId,
                        Title = item.Title,
                        AssignName = item.AssignName,
                        Priority = item.Priority,
                        Division = item.Division,
                        TicketStatus = item.TicketStatus,
                        StartDate = item.StartDate,
                        DueDate = item.DueDate,
                        Description = item.Description,
                        IsApproved = item.IsApproved,
                        DateRequestCreated = item.DateRequestCreated.ToString("MMM d"),
                        RequestorName = item.RequestorName,
                    });
                }

                return requests;

            }
            catch
            {
                throw;
            }
        }

        public async Task<Response> Update(EmployeeSubRequest request)
        {
            try
            {
                var existingRequest = await employeeRequestRepository.GetById(request.Id);
                if(existingRequest != null)
                {
                    existingRequest.Title = request.Title;
                    existingRequest.AssignName = request.AssignName;
                    existingRequest.Priority = request.Priority;
                    existingRequest.Division = request.Division;
                    existingRequest.TicketStatus = request.Division;
                    existingRequest.StartDate = request.StartDate;
                    existingRequest.DueDate = request.DueDate;
                    existingRequest.Description = request.Description;

                    await employeeRequestRepository.Update(existingRequest, request.Id);
                    return new Response
                    {
                        IsSuccess = true,
                        Message = "Successfully Updated."
                    };
                }
                return new Response
                {
                    IsSuccess = false,
                    Message = "Failed to update."
                };
            }
            catch
            {
                throw;
            }
        }
    }
}
