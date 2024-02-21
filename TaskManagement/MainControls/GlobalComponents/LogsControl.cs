using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Models;
using TaskManagement.Services.Contracts;

namespace TaskManagement.MainControls.GlobalComponents
{
    public partial class LogsControl : UserControl
    {
        private readonly ILogsService logsService;

        private IEnumerable<UserLogsEditor> Logs;

        public LogsControl(ILogsService logsService)
        {
            this.logsService = logsService;
            InitializeComponent();
            InitializeDataGridView();
        }

        private async void InitializeDataGridView()
        {
            Logs = await logsService.GetLogs();
            DGVLogs.DataSource = Logs;
        }

        private void BTNSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = TBSearch.Text.ToLower();

            var filteredUsers = Logs.Where(log =>
                log.Date.ToLower().Contains(searchTerm) || 
                log.Time.ToLower().Contains(searchTerm) ||
                log.Action.ToLower().Contains(searchTerm)
            ).ToList();

            DGVLogs.DataSource = filteredUsers;
        }
    }
}
