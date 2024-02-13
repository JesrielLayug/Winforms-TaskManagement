using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement.Views
{
    public partial class CalendarView : Form
    {
        public DateTime SelectedDate { get; private set; }

        public CalendarView()
        {
            InitializeComponent();
        }

        private void BTNSubmit_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Calendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelectedDate = Calendar.SelectionStart;
        }
    }
}
