using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagement.Utilities
{
    public class ButtonClickHandler
    {
        public event EventHandler ButtonClicked;

        protected virtual void OnButtonClicked(EventArgs e)
        {
            ButtonClicked?.Invoke(this, e);
        }

        public void HandleButtonClick(object sender, EventArgs e)
        {
            OnButtonClicked(e);
        }
    }
}
