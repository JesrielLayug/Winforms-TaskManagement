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

namespace TaskManagement.Services
{
    public class EmployeeRequestService : IEmployeeRequestService
    {
        private const string fileName = "app-settings.json";
        private readonly string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, fileName);

        private readonly IEmployeeRequestRepository employeeRequestRepository;

        public EmployeeRequestService(IEmployeeRequestRepository employeeRequestRepository)
        {
            this.employeeRequestRepository = employeeRequestRepository;
        }

        public async Task<Response> Add(EmployeeSubRequest request)
        {
            try
            {
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
                    RequestorId = GetCurrentUserId(),
                    DateRequestCreated = DateTime.Now,
                    RequestorName = GetCurrentUserName(),
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

                if (File.Exists(filePath))
                {

                    var domainRequests = await employeeRequestRepository.GetAll(GetCurrentUserId());

                    foreach(var item in domainRequests)
                    {
                        requests.Add(new EmployeeSubRequest
                        {
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
                        });
                    }

                    return requests;
                }

                return null;
                //var domainRequests = await employeeRequestRepository.GetAll();
            }
            catch
            {
                throw;
            }
        }

        private string GetCurrentUserId()
        {
            string jsonString = File.ReadAllText(filePath);

            User user = JsonSerializer.Deserialize<User>(jsonString);

            return user.Id;
        }

        private string GetCurrentUserName()
        {
            string jsonString = File.ReadAllText(filePath);

            User user = JsonSerializer.Deserialize<User>(jsonString);

            return user.FullName;
        }
    }
}
