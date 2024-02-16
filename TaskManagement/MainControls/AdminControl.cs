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
        private ButtonColorChanger ButtonColorChanger;
        private UserControlChanger GetUserControlChanger;

        public AdminControl(
            IUserService userService,
            ITicketService ticketService,
            IAuthenticationService authenticationService,
            IEmployeeRequestService requestService
            )
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.authenticationService = authenticationService;
            this.requestService = requestService;
            InitializeComponent();
            InitializeButtonEffect();
            InitializeMainControl();
        }

        private void InitializeMainControl()
        {
            List<UserControl> controls = new List<UserControl>()
            {
                new DashboardBaseControl(userService, ticketService),
                new TicketBaseControl(userService, ticketService, requestService),
                new PendingBaseControl(userService, ticketService, requestService),
                new AccountBaseControl(userService),
                new SettingsBaseControl()
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

            Image defaultDashboard = Image.FromFile("..\\..\\Resources\\dashboard-3.png");
            Image defaultTask = Image.FromFile("..\\..\\Resources\\Task.png");
            Image defaultAccount = Image.FromFile("..\\..\\Resources\\account-gray.png");
            Image defaultTime = Image.FromFile("..\\..\\Resources\\file.png");
            Image defaultSettings = Image.FromFile("..\\..\\Resources\\tool.png");
            Image defaultLogout = Image.FromFile("..\\..\\Resources\\door.png");

            Image newDashboard = Image.FromFile("..\\..\\Resources\\dashboard-white.png");
            Image newTask = Image.FromFile("..\\..\\Resources\\task-white.png");
            Image newAccount = Image.FromFile("..\\..\\Resources\\account-2-white.png");
            Image newTime = Image.FromFile("..\\..\\Resources\\file (1).png");
            Image newSettings = Image.FromFile("..\\..\\Resources\\tool-white.png");
            Image newLogout = Image.FromFile("..\\..\\Resources\\door-white.png");

            List<Image> defaultImages = new List<Image>()
            {
                defaultDashboard, defaultTask, defaultAccount, defaultTime, defaultSettings, defaultLogout
            };

            List<Image> newImages = new List<Image>
            {
                newDashboard, newTask, newAccount, newTime, newSettings, newLogout
            };

            List<Button> buttons = new List<Button>()
            {
                BTNDashboard, BTNTicket, BTNAccount, BTNPending, BTNSettings, BTNLogout
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

        private void BTNSettings_Click(object sender, EventArgs e)
        {
            ButtonColorChanger.SelectedButton(BTNSettings);
            GetUserControlChanger.Display(4);
        }

        private void BTNLogout_Click(object sender, EventArgs e)
        {
            ButtonColorChanger.SelectedButton(BTNLogout);
            authenticationService.Logout();
            LogoutClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
