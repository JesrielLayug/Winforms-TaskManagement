using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement.UserControls.Components
{
    public partial class TicketCard : UserControl
    {
        public string Title;
        public string Description;
        public string Date;


        public event EventHandler ViewClick;
        public event EventHandler EditClick;
        public event EventHandler DeleteClick;

        public TicketCard(string title, string description, string date)
        {
            this.Title = title;
            this.Description = description;
            this.Date = date;

            InitializeComponent();
            InitializeTexts();
        }

        private void InitializeTexts()
        {
            LBTitle.Text = Title;
            LBDescription.Text = Description;
            LBDate.Text = Date;
        }

        private void BTNView_Click(object sender, EventArgs e)
        {
            ViewClick?.Invoke(this, EventArgs.Empty);
        }

        private void BTNUpdate_Click(object sender, EventArgs e)
        {
            EditClick?.Invoke(this, EventArgs.Empty);
        }

        private void BTNDelete_Click(object sender, EventArgs e)
        {
            DeleteClick?.Invoke(this, EventArgs.Empty);
        }
    }
}
