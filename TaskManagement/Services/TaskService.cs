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
    public class TaskService : ITaskService
    {
        private readonly ITaskRepository taskRepository;
        private readonly IUserRepository userRepository;

        public TaskService(ITaskRepository taskRepository, IUserRepository userRepository)
        {
            this.taskRepository = taskRepository;
            this.userRepository = userRepository;
        }

        public async Task<Response> Add(TaskItemEditor task)
        {
            try
            {
                var assignee = await userRepository.GetByName(task.AssignName);
                var createdBy = await userRepository.GetByName(task.CreatedBy);

                var taskTobeAdded = new TaskItem
                {
                    Title = task.Title,
                    AssignUserId = assignee.Id,
                    Priority = task.Priority,
                    Division = task.Division,
                    TaskStatus = task.TaskStatus,
                    StartDate = task.StartDate,
                    DueDate = task.DueDate,
                    Description = task.Description,
                    IsDeleted = false,
                    UserId = createdBy.Id
                };

                if (createdBy.Role == "Admin")
                    taskTobeAdded.IsApprove = true;
                else
                    taskTobeAdded.IsApprove = false;

                await taskRepository.Add(taskTobeAdded);

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
    }
}
