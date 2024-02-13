using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.Services.Contracts;
using TaskManagement.UserControls.AdminSubControls;

namespace TaskManagement.UserControls
{
    public partial class AdminControl : UserControl
    {
        private readonly IUserService userService;
        private readonly ITaskService taskService;

        public AdminControl(
            IUserService userService,
            ITaskService taskService
            )
        {
            this.userService = userService;
            this.taskService = taskService;

            InitializeComponent();
            InitializeMainControl();
        }

        private void InitializeMainControl()
        {
            TaskControl taskControl = new TaskControl(userService, taskService);
            taskControl.Dock = DockStyle.Fill;

            MainPanel.Controls.Add(taskControl);
        }
    }
}
