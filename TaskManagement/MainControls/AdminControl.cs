using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TaskManagement.MainControls.GlobalComponents;
using TaskManagement.MainControls.SubControls;
using TaskManagement.Services.Contracts;
using TaskManagement.UserControls.AdminSubControls;
using TaskManagement.Utilities;

namespace TaskManagement.UserControls
{
    public partial class AdminControl : UserControl
    {
        public event EventHandler LogoutClick;

        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IAuthenticationService authenticationService;
        private readonly IEmployeeRequestService requestService;
        private readonly ILogsService logsService;
        private ButtonColorChanger ButtonColorChanger;
        private UserControlChanger GetUserControlChanger;

        public AdminControl(
            IUserService userService,
            ITicketService ticketService,
            IAuthenticationService authenticationService,
            IEmployeeRequestService requestService,
            ILogsService logsService
            )
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.authenticationService = authenticationService;
            this.requestService = requestService;
            this.logsService = logsService;
            InitializeComponent();
            InitializeButtonEffect();
            InitializeMainControl();
        }

        private void InitializeMainControl()
        {
            List<UserControl> controls = new List<UserControl>()
            {
                new DashboardBaseControl(userService, ticketService),
                new TicketBaseControl(userService, ticketService, requestService, logsService),
                new PendingBaseControl(userService, ticketService, requestService, logsService),
                new AccountBaseControl(userService, authenticationService, logsService),
                new LogsControl(logsService)
            };

            GetUserControlChanger = new UserControlChanger( controls, MainPanel );
            GetUserControlChanger.Display(0);
        }

        private void InitializeButtonEffect()
        {
            Color defaultBackColor = Color.Transparent;
            Color defaultForeColor = Color.White;
            Color newBackColor = Color.FromArgb(64, 123, 255);
            Color newForeColor = Color.FromArgb(64, 123, 255);

            Image defaultDashboard = Properties.Resources.dashboard_3;
            Image defaultTask = Properties.Resources.task;
            Image defaultAccount = Properties.Resources.account;
            Image defaultTime = Properties.Resources.file;
            Image defaultLogout = Properties.Resources.door;
            Image defaultLogged = Properties.Resources.logged_gray;

            Image newDashboard = Properties.Resources.dashboard_3_white;
            Image newTask = Properties.Resources.task_white;
            Image newAccount = Properties.Resources.account_2_white;
            Image newTime = Properties.Resources.file__1_;
            Image newLogout = Properties.Resources.door_white;
            Image newLogged = Properties.Resources.logged_white;

            List<Image> defaultImages = new List<Image>()
            {
                defaultDashboard, defaultTask, defaultTime, defaultAccount, defaultLogged, defaultLogout
            };

            List<Image> newImages = new List<Image>
            {
                newDashboard, newTask, newTime, newAccount, newLogged, newLogout
            };

            List<Button> buttons = new List<Button>()
            {
                BTNDashboard, BTNTicket, BTNPending, BTNAccount, BTNLogs, BTNLogout
            };

            ButtonColorChanger = new ButtonColorChanger(
                newImages, defaultImages, buttons, defaultForeColor, defaultBackColor, newForeColor, newBackColor
                );

            ButtonColorChanger.SelectedButton(BTNDashboard);

        }

        private void BTNTicket_Click(object sender, EventArgs e)
        {
            InitializeMainControl();
            ButtonColorChanger.SelectedButton(BTNTicket);
            GetUserControlChanger.Display(1);
        }

        private void BTNDashboard_Click(object sender, EventArgs e)
        {
            InitializeMainControl();
            ButtonColorChanger.SelectedButton(BTNDashboard);
            GetUserControlChanger.Display(0);
        }

        private void BTNPending_Click(object sender, EventArgs e)
        {
            InitializeMainControl();
            ButtonColorChanger.SelectedButton(BTNPending);
            GetUserControlChanger.Display(2);
        }

        private void BTNAccount_Click(object sender, EventArgs e)
        {
            InitializeMainControl();
            ButtonColorChanger.SelectedButton(BTNAccount);
            GetUserControlChanger.Display(3);
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            ButtonColorChanger.SelectedButton(BTNLogout);
            authenticationService.Logout();
            LogoutClick?.Invoke(this, EventArgs.Empty);

            logsService.Add("Logged out.");
        }

        private void BTNLogs_Click(object sender, EventArgs e)
        {
            InitializeMainControl();
            ButtonColorChanger.SelectedButton(BTNLogs);
            GetUserControlChanger.Display(4);
        }
    }
}
