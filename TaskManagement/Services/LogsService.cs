using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskManagement.Models;
using TaskManagement.Repositories.Contracts;
using TaskManagement.Services.Contracts;
using TaskManagement.Utilities;

namespace TaskManagement.Services
{
    public class LogsService : ILogsService
    {
        UserSettingsProvider SettingsProvider = new UserSettingsProvider();
        private readonly ILogsRepository logsRepository;

        public LogsService(ILogsRepository logsRepository)
        {
            this.logsRepository = logsRepository;
        }

        public async Task Add(string action)
        {
            try
            {
                var log = new UserLogs
                {
                    TimeStamp = DateTime.Now,
                    UserId = SettingsProvider.GetCurrentUserId(),
                    Action = action
                };

                await logsRepository.Add(log);
            }
            catch
            {
                throw;
            }
        }

        public async Task<IEnumerable<UserLogsEditor>> GetLogs()
        {
            try
            {
                var domainLogs = await logsRepository.GetByUserId(SettingsProvider.GetCurrentUserId());
                var dtoLogs = new List<UserLogsEditor>();

                foreach(var log in domainLogs)
                {
                    dtoLogs.Add(new UserLogsEditor
                    {
                        Date = log.TimeStamp.ToString("MMM d"),
                        Time = log.TimeStamp.ToString("hh:mm tt"),
                        Action = log.Action
                    });
                }

                return dtoLogs;
            }
            catch
            {
                throw;
            }
        }
    }
}
