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
using TaskManagement.Views;

namespace TaskManagement.UserControls.AdminSubControls
{
    public partial class TaskControl : UserControl
    {
        private readonly IUserService userService;
        private readonly ITaskService taskService;

        public TaskControl(
            IUserService userService,
            ITaskService taskService
            )
        {
            this.userService = userService;
            this.taskService = taskService;

            InitializeComponent();
        }

        private void BTNCreate_Click(object sender, EventArgs e)
        {
            EditorTaskView create = new EditorTaskView(userService, taskService);
            create.ShowDialog();
        }
    }
}
