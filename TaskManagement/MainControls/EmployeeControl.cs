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

        public EmployeeControl(
            IUserService userService, 
            ITicketService ticketService,
            IEmployeeRequestService requestService,
            IAuthenticationService authenticationService
            )
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.requestService = requestService;
            this.authenticationService = authenticationService;
            InitializeComponent();
            InitializeButtonEffect();
            InitializeControls();
        }


        #region Designer
        
        private void InitializeControls()
        {
            List<UserControl> controls = new List<UserControl>()
            {
                new EmployeeDashboardControl(),
                new EmployeeTicketControl(userService, ticketService, requestService),
                new EmployeeRequestControl(requestService)
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

            Image defaultDashboard = Image.FromFile("..\\..\\Resources\\dashboard-3.png");
            Image defaultTask = Image.FromFile("..\\..\\Resources\\Task.png");
            Image defaultRequest = Image.FromFile("..\\..\\Resources\\message-gray.png");
            Image defaultLogout = Image.FromFile("..\\..\\Resources\\door.png");

            Image newDashboard = Image.FromFile("..\\..\\Resources\\dashboard-white.png");
            Image newTask = Image.FromFile("..\\..\\Resources\\task-white.png");
            Image newRequest = Image.FromFile("..\\..\\Resources\\message-white.png");
            Image newLogout = Image.FromFile("..\\..\\Resources\\door-white.png");

            List<Image> defaultImages = new List<Image>
            {
                defaultDashboard, defaultTask, defaultRequest, defaultLogout
            };

            List<Image> newImages = new List<Image>
            {
                newDashboard, newTask, newRequest, newLogout
            };

            List<Button> buttons = new List<Button>
            {
                BTNDashboard, BTNTicket, BTNRequest, BTNLogout
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
            ButtonColorChanger.SelectedButton(BTNLogout);
            authenticationService.Logout();
            LogoutClick?.Invoke(this, EventArgs.Empty);
        }

        #endregion

    }
}
