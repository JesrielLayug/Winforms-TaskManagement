using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.MainControls.EmployeeSubControls;
using TaskManagement.MainControls.GlobalComponents;
using TaskManagement.Services.Contracts;
using TaskManagement.Utilities;

namespace TaskManagement.MainControls
{
    public partial class EmployeeControl : UserControl
    {
        public event EventHandler LogoutClick;

        private ButtonColorChanger ButtonColorChanger;
        private UserControlChanger GetUserControlChanger;
        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;
        private readonly IAuthenticationService authenticationService;
        private readonly ILogsService logsService;

        public EmployeeControl(
            IUserService userService, 
            ITicketService ticketService,
            IEmployeeRequestService requestService,
            IAuthenticationService authenticationService,
            ILogsService logsService
            )
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.requestService = requestService;
            this.authenticationService = authenticationService;
            this.logsService = logsService;
            InitializeComponent();
            InitializeButtonEffect();
            InitializeControls();
        }


        #region Designer
        
        private void InitializeControls()
        {
            List<UserControl> controls = new List<UserControl>()
            {
                new EmployeeDashboardControl(userService, ticketService, requestService),
                new EmployeeTicketControl(userService, ticketService, requestService, logsService),
                new EmployeeRequestControl(userService, ticketService, requestService, logsService),
                new LogsControl(logsService)
            };

            GetUserControlChanger = new UserControlChanger(controls, MainPanel);
            GetUserControlChanger.Display(0);
        }


        private void InitializeButtonEffect()
        {
            Color defaultBackColor = Color.Transparent;
            Color defaultForeColor = Color.White;
            Color newBackColor = Color.FromArgb(0, 141, 255);
            Color newForeColor = Color.FromArgb(64, 123, 255);

            Image defaultDashboard = Properties.Resources.dashboard_3;
            Image defaultTask = Properties.Resources.task;
            Image defaultRequest = Properties.Resources.message_gray;
            Image defaultLogout = Properties.Resources.door;
            Image defaultLogged = Properties.Resources.logged_gray;

            Image newDashboard = Properties.Resources.dashboard_3_white;
            Image newTask = Properties.Resources.task_white;
            Image newRequest = Properties.Resources.message_white;
            Image newLogout = Properties.Resources.door_white;
            Image newLogged = Properties.Resources.logged_white;

            List<Image> defaultImages = new List<Image>
            {
                defaultDashboard, defaultTask, defaultRequest, defaultLogged, defaultLogout
            };

            List<Image> newImages = new List<Image>
            {
                newDashboard, newTask, newRequest, newLogged, newLogout
            };

            List<Button> buttons = new List<Button>
            {
                BTNDashboard, BTNTicket, BTNRequest, BTNLogs, BTNLogout
            };

            ButtonColorChanger = new ButtonColorChanger(
                newImages, defaultImages, buttons, defaultForeColor, defaultBackColor, newForeColor, newBackColor
                );

            ButtonColorChanger.SelectedButton(BTNDashboard);
        }

        #endregion

        #region Click Events

        private void BTNDashboard_Click(object sender, EventArgs e)
        {
            InitializeControls();
            ButtonColorChanger.SelectedButton(BTNDashboard);
            GetUserControlChanger.Display(0);
        }

        private void BTNTicket_Click(object sender, EventArgs e)
        {
            InitializeControls();
            ButtonColorChanger.SelectedButton(BTNTicket);
            GetUserControlChanger.Display(1);
        }

        private void BTNRequest_Click(object sender, EventArgs e)
        {
            InitializeControls();
            ButtonColorChanger.SelectedButton(BTNRequest);
            GetUserControlChanger.Display(2);
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            logsService.Add("Logged out.");
            ButtonColorChanger.SelectedButton(BTNLogout);
            authenticationService.Logout();
            LogoutClick?.Invoke(this, EventArgs.Empty);
        }

        #endregion

        private void BTNLogs_Click(object sender, EventArgs e)
        {
            InitializeControls();
            ButtonColorChanger.SelectedButton(BTNLogs);
            GetUserControlChanger.Display(3);
        }
    }
}
