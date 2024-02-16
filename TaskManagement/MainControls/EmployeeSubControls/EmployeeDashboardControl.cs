using LiveCharts;
using LiveCharts.Wpf;
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
using TaskManagement.Services;
using TaskManagement.Services.Contracts;
using TaskManagement.Utilities;

namespace TaskManagement.MainControls.EmployeeSubControls
{
    public partial class EmployeeDashboardControl : UserControl
    {
        private readonly IUserService userService;
        private readonly ITicketService ticketService;
        private readonly IEmployeeRequestService requestService;

        UserSettingsProvider SettingsProvider = new UserSettingsProvider();

        private string[] XAxisLabels = new string[7];

        private IEnumerable<User> Employees;
        private IEnumerable<TicketInfo> Tickets;
        private IEnumerable<EmployeeTicketInfo> EmployeeTickets;
        private IEnumerable<EmployeeTicketInfo> EmployeeTicketsRequest;

        public EmployeeDashboardControl(
            IUserService userService,
            ITicketService ticketService,
            IEmployeeRequestService requestService)
        {
            this.userService = userService;
            this.ticketService = ticketService;
            this.requestService = requestService;

            InitializeComponent();
        }

        private async void InitializeQuantities()
        {
            var groupByStatus = Tickets.GroupBy(t => (t.TicketStatus, t.AssignUserId));

            var currentUser = SettingsProvider.GetCurrentUserId();

            List<TicketInfo> nextUpTickets = groupByStatus.FirstOrDefault(g => g.Key == ("Next Up", currentUser))?.ToList() ?? null;
            List<TicketInfo> inProgressTickets = groupByStatus.FirstOrDefault(g => g.Key == ("In Progress", currentUser))?.ToList() ?? null;
            List<TicketInfo> completedTickets = groupByStatus.FirstOrDefault(g => g.Key == ("Completed", currentUser))?.ToList() ?? null;

            var nextUpQuantity = (nextUpTickets?.Count() ?? 0).ToString();
            var inProgressQuantity = (inProgressTickets?.Count() ?? 0).ToString();
            var completedQuantity = (completedTickets?.Count() ?? 0).ToString();


            LBNextUpQuantity.Text = nextUpQuantity;
            LBInProgressQuantity.Text = inProgressQuantity;
            LBCompletedQuantity.Text = completedQuantity;
            LBEmployeesQuantity.Text = EmployeeTicketsRequest.Count().ToString();

        }

        private async Task RefreshTickets()
        {
            Tickets = await ticketService.GetByAssignUser();
            Employees = await userService.GetAll();
            EmployeeTickets = await requestService.GetAllApproved();
            EmployeeTicketsRequest = await requestService.GetAllUserRequest();
        }

        private string[] InitializeDaysPerWeek()
        {
            //string[] xAxisLabels = new string[7];
            DateTime previousDay = DateTime.Now;

            for(int i = 0; i < 7; i++) 
            {
                XAxisLabels[i] = previousDay.ToString("MMM d");

                if(i == 6)
                    previousDay = previousDay.AddDays(1);
            }
            return XAxisLabels;
        }

        private async void EmployeeDashboardControl_Load(object sender, EventArgs e)
        {
            await RefreshTickets();


            InitializeQuantities();
            InitializeCarteisanChart();
            InitializeCompletedPriorityCartesian();
            InitializeCompletedChart();
            InitializeApprovedChart();

        }

        #region Pie Chart

        private void InitializeCompletedChart()
        {
            var completedTickets = EmployeeTickets.Where(t => t.TicketStatus == "Completed");

            var countsByPriority = completedTickets.GroupBy(t => t.Priority)
                    .Select(g => new { Priority = g.Key, Count = g.Count() });

            PopulateCompletedChart(countsByPriority);
        }

        private void PopulateCompletedChart(IEnumerable<dynamic> countsByPriority)
        {
            pieChart2.Series.Clear();

            if (!countsByPriority.Any())
            {
                // Add an empty series to display an empty pie chart
                pieChart2.Series.Add(new PieSeries
                {
                    Title = "No Data",
                    Values = new ChartValues<int> { 5 },
                    DataLabels = true
                });
            }
            else
            {
                foreach (var item in countsByPriority)
                {
                    var series = new PieSeries
                    {
                        Title = $"{item.Priority}",
                        Values = new ChartValues<int> { item.Count },
                        DataLabels = true
                    };

                    pieChart2.Series.Add(series);
                }
            }

            pieChart2.LegendLocation = LegendLocation.Bottom;
        }

        #endregion

        #region Pie Chart 2
        private void InitializeApprovedChart()
        {
            var approvedTickets = EmployeeTickets.Where(t => t.IsApproved == true);

            var countsByStatus = approvedTickets.GroupBy(t => t.TicketStatus)
                .Select(g => new { TicketStatus = g.Key, Count = g.Count() });

            PopulateApprovedChart(countsByStatus);
        }

        private void PopulateApprovedChart(IEnumerable<dynamic> countsByStatus)
        {
            pieChart3.Series.Clear();

            if (!countsByStatus.Any())
            {
                // Add an empty series to display an empty pie chart
                pieChart3.Series.Add(new PieSeries
                {
                    Title = "No Data",
                    Values = new ChartValues<int> { 5 },
                    DataLabels = true
                });
            }
            else
            {
                foreach (var item in countsByStatus)
                {
                    var series = new PieSeries
                    {
                        Title = item.TicketStatus,
                        Values = new ChartValues<int> { item.Count },
                        DataLabels = true
                    };

                    pieChart3.Series.Add(series);
                }
            }

            pieChart3.LegendLocation = LegendLocation.Right;
        }

        #endregion

        #region Daily Carteisan


        private void InitializeCarteisanChart()
        {

            cartesianChart3.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Day",
                Labels = InitializeDaysPerWeek()
            });

            cartesianChart3.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Number of Tickets",
                MinValue = 0
            });

            cartesianChart3.LegendLocation = LiveCharts.LegendLocation.Bottom;

            if (Tickets.Any())
            {
                AddSeries("Next Up", Tickets);
                AddSeries("In Progress", Tickets);
                AddSeries("Completed", Tickets);
            }
            else
            {
                AddDummySeries("Next Up");
                AddDummySeries("In Progress");
                AddDummySeries("Completed");
            }
        }

        private IEnumerable<int> GetTicketCountByStatus(IEnumerable<TicketInfo> tickets, string status)
        {
            return Enumerable.Range(0, XAxisLabels.Length)
                             .Select(x => tickets.Count(t => t.TicketStatus == status && t.DateCreated.Date == DateTime.Now.AddDays(-x).Date));
        }

        private void AddSeries(string status, IEnumerable<TicketInfo> tickets)
        {
            var series = new LineSeries
            {
                Title = status,
                Values = new ChartValues<int>(GetTicketCountByStatus(tickets, status))
            };

            cartesianChart3.Series.Add(series);
        }

        private void AddDummySeries(string status)
        {
            int[] dummyData;

            if (status == "Next Up")
                dummyData = new int[] { 7, 7, 7, 7, 7, 7, 7 };
            else if (status == "In Progress")
                dummyData = new int[] { 10, 10, 10, 10, 10, 10, 10 };
            else if (status == "Completed")
                dummyData = new int[] { 5, 5, 5, 5, 5, 5, 5 };
            else
                dummyData = new int[0]; // Default case (empty array)

            var series = new LineSeries
            {
                Title = status,
                Values = new ChartValues<int>(dummyData)
            };

            cartesianChart3.Series.Add(series);
        }

        #endregion

        #region Completed Priority Cartesian

        private void InitializeCompletedPriorityCartesian()
        {
            cartesianChart4.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Day",
                Labels = InitializeDaysPerWeek()
            });

            cartesianChart4.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Number of Tickets",
                MinValue = 0
            });

            cartesianChart4.LegendLocation = LiveCharts.LegendLocation.Bottom;

            if (Tickets.Any())
            {
                AddSeriesForPriority("High Priority", Tickets);
                AddSeriesForPriority("Medium Priority", Tickets);
                AddSeriesForPriority("Low Priority", Tickets);
            }
            else
            {
                AddDummyPrioritySeries("High Priority");
                AddDummyPrioritySeries("Medium Priority");
                AddDummyPrioritySeries("Low Priority");
            }
        }

        private void AddSeriesForPriority(string priority, IEnumerable<TicketInfo> tickets)
        {
            var series = new LineSeries
            {
                Title = priority,
                Values = new ChartValues<int>(GetTicketCountByPriority(tickets, priority))
            };

            cartesianChart4.Series.Add(series);
        }

        private IEnumerable<int> GetTicketCountByPriority(IEnumerable<TicketInfo> tickets, string priority)
        {
            return Enumerable.Range(0, XAxisLabels.Length)
                     .Select(x => tickets.Count(t => t.Priority == priority && t.DateCreated.Date == DateTime.Now.AddDays(-x).Date));
        }

        private void AddDummyPrioritySeries(string status)
        {
            int[] dummyData;

            if (status == "Low Priority")
                dummyData = new int[] { 7, 7, 7, 7, 7, 7, 7 };
            else if (status == "Medium Priority")
                dummyData = new int[] { 10, 10, 10, 10, 10, 10, 10 };
            else if (status == "High Priority")
                dummyData = new int[] { 5, 5, 5, 5, 5, 5, 5 };
            else
                dummyData = new int[0]; // Default case (empty array)

            var series = new LineSeries
            {
                Title = status,
                Values = new ChartValues<int>(dummyData)
            };

            cartesianChart4.Series.Add(series);
        }

        #endregion


    }
}
