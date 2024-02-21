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
using LiveCharts;
using LiveCharts.Wpf;
using LiveCharts.WinForms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using LiveCharts.Definitions.Charts;

namespace TaskManagement.MainControls.SubControls
{
    public partial class DashboardBaseControl : UserControl
    {
        private string[] XAxisLabels = new string[7];

        private IEnumerable<TicketInfo> Tickets;
        private IEnumerable<User> Employees;

        private readonly IUserService userService;
        private readonly ITicketService ticketService;

        public DashboardBaseControl(IUserService userService, ITicketService ticketService)
        {
            this.userService = userService;
            this.ticketService = ticketService;

            InitializeComponent();
        }

        private async void DashboardBaseControl_Load(object sender, EventArgs e)
        {
            // Refresh tickets
            await RefreshTickets();

            InitializeQuantities();

            // Initialize chart
            InitializeCartesianChart();
            InitializePieChart();
            InitializeBarChart();
            InitializeDivisionCartesianChart();

        }

        private async Task RefreshTickets()
        {
            Tickets = await ticketService.GetAll();
            Employees = await userService.GetAllEmployee();
        }

        private async void InitializeQuantities()
        {
            var groupByStatus = Tickets.GroupBy(t => t.TicketStatus);

            List<TicketInfo> nextUpTickets = groupByStatus.FirstOrDefault(g => g.Key == "Next Up")?.ToList() ?? null;
            List<TicketInfo> inProgressTickets = groupByStatus.FirstOrDefault(g => g.Key == "In Progress")?.ToList() ?? null;
            List<TicketInfo> completedTickets = groupByStatus.FirstOrDefault(g => g.Key == "Completed")?.ToList() ?? null;

            var nextUpQuantity = (nextUpTickets?.Count() ?? 0).ToString();
            var inProgressQuantity = (inProgressTickets?.Count() ?? 0).ToString();
            var completedQuantity = (completedTickets?.Count() ?? 0).ToString();


            LBNextUpQuantity.Text = nextUpQuantity;
            LBInProgressQuantity.Text = inProgressQuantity;
            LBCompletedQuantity.Text = completedQuantity;
            LBEmployeesQuantity.Text = Employees.Count().ToString();

        }



        #region Bar Chart


        private void InitializeBarChart()
        {
            if (Tickets.Any())
            {
                // Map priority strings to corresponding integer values
                Dictionary<string, int> priorityMap = new Dictionary<string, int>
                {
                    { "Low Priority", 1 },
                    { "Medium Priority", 2 },
                    { "High Priority", 3 }
                };

                // Group tickets by priority and count them
                var ticketCountsByPriority = Tickets.GroupBy(t => t.Priority)
                                                    .Select(g => new { Priority = g.Key, Count = g.Count() })
                                                    .OrderByDescending(x => priorityMap.ContainsKey(x.Priority) ? priorityMap[x.Priority] : int.MaxValue);

                // Clear existing series in the chart
                chart1.Series.Clear();

                // Iterate through each priority and add series if tickets exist
                foreach (var ticketCount in ticketCountsByPriority)
                {
                    // Check if the priority is in the map
                    if (priorityMap.ContainsKey(ticketCount.Priority))
                    {
                        // Create a new series
                        System.Windows.Forms.DataVisualization.Charting.Series series = new System.Windows.Forms.DataVisualization.Charting.Series();
                        series.ChartType = SeriesChartType.Bar;
                        series.LegendText = ticketCount.Priority;

                        // Add the series to the chart
                        chart1.Series.Add(series);

                        // Add a data point for each ticket with its title and priority level
                        foreach (var ticket in Tickets.Where(t => t.Priority == ticketCount.Priority))
                        {
                            // Set data point values
                            var dataPoint = new DataPoint();
                            dataPoint.SetValueY(priorityMap[ticket.Priority]);
                            dataPoint.AxisLabel = ticket.Title;

                            // Add data point to the series
                            series.Points.Add(dataPoint);
                        }
                    }
                }

                // Set chart properties
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
            else
            {
                // Clear existing series in the chart
                chart1.Series.Clear();

                // Generate dummy data
                Random random = new Random();
                int numberOfDummyDataPoints = 3; // You can adjust this as needed
                for (int i = 0; i < numberOfDummyDataPoints; i++)
                {
                    // Create a dummy series
                    System.Windows.Forms.DataVisualization.Charting.Series dummySeries = new System.Windows.Forms.DataVisualization.Charting.Series();
                    dummySeries.ChartType = SeriesChartType.Bar;
                    dummySeries.LegendText = $"Dummy Priority {i}";

                    // Add the dummy series to the chart
                    chart1.Series.Add(dummySeries);

                    // Generate dummy data points
                    for (int j = 0; j < 3; j++) // You can adjust the number of data points per series
                    {
                        // Set data point values
                        var dummyDataPoint = new DataPoint();
                        dummyDataPoint.SetValueY(random.Next(1, 4));
                        dummyDataPoint.AxisLabel = $"Ticket {j + 1}";

                        // Add data point to the series
                        dummySeries.Points.Add(dummyDataPoint);
                    }
                }

                // Set chart properties
                chart1.ChartAreas[0].AxisX.Interval = 1;
                chart1.ChartAreas[0].AxisX.MajorGrid.Enabled = false;
                chart1.ChartAreas[0].AxisY.MajorGrid.Enabled = false;
            }
        }


        private string GetPriorityName(int priority)
        {
            switch (priority)
            {
                case 1:
                    return "Low Priority";
                case 2:
                    return "Medium Priority";
                case 3:
                    return "High Priority";
                default:
                    return "Unknown Priority";
            }
        }


        #endregion

        #region Pie Chart

        private void InitializePieChart()
        {
            var completedTickets = Tickets.Where(t => t.TicketStatus == "Completed");

            var countsByAssignUserName = completedTickets.GroupBy(t => t.AssignUserName)
                .Select(g => new { AssignUserName = g.Key, Count = g.Count() });

            PopulatePieChart(countsByAssignUserName);
        }

        private void PopulatePieChart(IEnumerable<dynamic> countsByAssignUserName)
        {
            pieChart1.Series.Clear();

            if (!countsByAssignUserName.Any())
            {
                // Add an empty series to display an empty pie chart
                pieChart1.Series.Add(
                new PieSeries
                {
                    Title = "No Data",
                    Values = new ChartValues<int> { 10 },
                    DataLabels = true
                });

                pieChart1.Series.Add(
                new PieSeries
                {
                    Title = "No Data",
                    Values = new ChartValues<int> { 5 },
                    DataLabels = true
                });
                pieChart1.Series.Add(
                new PieSeries
                {
                    Title = "No Data",
                    Values = new ChartValues<int> { 8 },
                    DataLabels = true
                });
                pieChart1.Series.Add(
                new PieSeries
                {
                    Title = "No Data",
                    Values = new ChartValues<int> { 3 },
                    DataLabels = true
                });
            }
            else
            {
                foreach (var item in countsByAssignUserName)
                {
                    var series = new PieSeries
                    {
                        Title = item.AssignUserName,
                        Values = new ChartValues<int> { item.Count },
                        DataLabels = true
                    };

                    pieChart1.Series.Add(series);
                }
            }

            pieChart1.LegendLocation = LegendLocation.Bottom;
        }

        #endregion

        #region Daily Carteisan

        private void InitializeCartesianChart()
        {
            InitializeDaysPerWeek();

            // Add X-axis with labels
            cartesianChart1.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Day",
                Labels = InitializeDaysPerWeek()
            });

            // Set Y-axis minimum value to 0
            cartesianChart1.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Number of Tickets",
                MinValue = 0
            });

            // Set legend location
            cartesianChart1.LegendLocation = LegendLocation.Bottom;

            if (Tickets.Any())
            {
                // Create series for each status
                AddSeries("Next Up", Tickets);
                AddSeries("In Progress", Tickets);
                AddSeries("Completed", Tickets);
            }
            else
            {
                AddDailyDummySeries("No Data");
                AddDailyDummySeries("Dummy");
                AddDailyDummySeries("Dummies");
            }
            
        }
        private string[] InitializeDaysPerWeek()
        {
            // Initialize X-axis labels
            XAxisLabels = new string[7];
            DateTime previousDay = DateTime.Now; // Initialize previousDay outside the loop

            for (int i = 0; i < 7; i++)
            {
                XAxisLabels[i] = previousDay.ToString("MMM d");

                if (i == 6)
                    previousDay = previousDay.AddDays(1); // Update previousDay after every 6 days
                //else
                //    previousDay = previousDay.AddDays(1); // Increment previousDay by 1 day
            }

            return XAxisLabels;
        }
        private void AddSeries(string status, IEnumerable<TicketInfo> tickets)
        {
            var series = new LineSeries
            {
                Title = status,
                Values = new ChartValues<int>(GetTicketCountByStatus(tickets, status)),
            };

            // Add series to the chart
            cartesianChart1.Series.Add(series);
        }
        private IEnumerable<int> GetTicketCountByStatus(IEnumerable<TicketInfo> tickets, string status)
        {
            return Enumerable.Range(0, XAxisLabels.Length)
                             .Select(i => tickets.Count(t => t.TicketStatus == status && t.DateCreated.Date == DateTime.Now.AddDays(-i).Date));
        }

        private void AddDailyDummySeries(string status)
        {
            int[] dummyData;

            if (status == "No Data")
                dummyData = new int[] { 7, 10, 2, 11, 4, 7, 3 };
            else if (status == "Dummy")
                dummyData = new int[] { 10, 2, 1, 5, 3, 2, 8 };
            else if (status == "Dummies")
                dummyData = new int[] { 5, 6, 0, 5, 4, 10, 5 };
            else
                dummyData = new int[0]; // Default case (empty array)

            var series = new LineSeries
            {
                Title = "No Data",
                Values = new ChartValues<int>(dummyData)
            };

            cartesianChart1.Series.Add(series);
        }

        #endregion

        #region Division Carteisan

        private async void InitializeDivisionCartesianChart()
        {
            // Group tickets by division
            var groupByDivision = Tickets.GroupBy(t => t.Division);

            // Add X-axis with division labels
            cartesianChart2.AxisX.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Day",
                Labels = InitializeDaysPerWeek()
            });

            // Set Y-axis minimum value to 0
            cartesianChart2.AxisY.Add(new LiveCharts.Wpf.Axis
            {
                Title = "Number of Tickets",
                MinValue = 0
            });

            // Set legend location
            cartesianChart2.LegendLocation = LegendLocation.Bottom;

            if (Tickets.Any())
            {
                // Create series for each division
                foreach (var divisionGroup in groupByDivision)
                {
                    AddDivisionSeries(divisionGroup.Key, divisionGroup);
                }
            }
            else
            {
                AddDummySeries("No Data");
                AddDummySeries("Dummy");
                AddDummySeries("Dummies");
            }
        }


        private void AddDivisionSeries(string division, IEnumerable<TicketInfo> tickets)
        {
            var series = new LineSeries
            {
                Title = division,
                Values = new ChartValues<int>(GetTicketCountByDivision(tickets, division)),
            };

            // Add series to the chart
            cartesianChart2.Series.Add(series);
        }

        private IEnumerable<int> GetTicketCountByDivision(IEnumerable<TicketInfo> tickets, string division)
        {
            return Enumerable.Range(0, XAxisLabels.Length)
                             .Select(i => tickets.Count(t => t.Division == division && t.DateCreated.Date == DateTime.Now.AddDays(-i).Date));
        }

        private void AddDummySeries(string status)
        {
            int[] dummyData;

            if (status == "No Data")
                dummyData = new int[] { 7, 10, 2, 11, 4, 7, 3 };
            else if (status == "Dummy")
                dummyData = new int[] { 10, 2, 1, 5, 3, 2, 8 };
            else if (status == "Dummies")
                dummyData = new int[] { 5, 6, 0, 5, 4, 10, 5 };
            else
                dummyData = new int[0]; // Default case (empty array)

            var series = new LineSeries
            {
                Title = "No Data",
                Values = new ChartValues<int>(dummyData)
            };

            cartesianChart2.Series.Add(series);
        }


        #endregion
    }
}
