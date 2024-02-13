using Guna.UI.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaskManagement.Utilities
{
    public class ButtonColorChanger
    {
        private List<Button> listsButton = new List<Button>();
        private List<Image> listNewImages = new List<Image>();
        private List<Image> listDefaultImages = new List<Image>();
        // Default Fore Color and Back Color of the button
        private Color DefForeColor;
        private Color DefBackColor;
        // Selected Fore Color and Back Color of the button
        private Color NewForeColor;
        private Color NewBackColor;

        public ButtonColorChanger(
            List<Image> listNewImages, 
            List<Image> listDefaultImages,
            List<Button> listsButton, 
            Color DefForeColor, 
            Color DefBackColor, 
            Color NewForeColor, 
            Color NewBackColor
            )
        {
            this.listNewImages = listNewImages;
            this.listDefaultImages = listDefaultImages;
            this.listsButton = listsButton;
            this.DefForeColor = DefForeColor;
            this.DefBackColor = DefBackColor;
            this.NewForeColor = NewForeColor;
            this.NewBackColor = NewBackColor;

            BTNSetDefColor();
        }

        private void BTNSetDefColor()
        {
            foreach (Button button in listsButton)
            {
                button.BackColor = DefBackColor;
                button.ForeColor = DefForeColor;
                if (button.Image != null)
                {
                    button.Image = listDefaultImages[listsButton.IndexOf(button)];
                    button.MouseEnter += (s, e) => { button.Image = listNewImages[listsButton.IndexOf(button)]; };
                    button.MouseLeave += (s, e) => { button.Image = listDefaultImages[listsButton.IndexOf(button)]; };
                }
                else
                {
                    button.Image = null;
                }
                button.MouseEnter += (s, e) => {
                    button.ForeColor = NewForeColor;
                    button.BackColor = NewBackColor;
                };
                button.MouseLeave += (s, e) => {
                    button.ForeColor = DefForeColor;
                    button.BackColor = DefBackColor;
                };

            }
        }

        public void SelectedButton(Button _button)
        {
            foreach (Button button in listsButton)
            {
                int index = listsButton.IndexOf(button);
                bool isSelected = (button == _button);

                button.BackColor = isSelected ? NewBackColor : DefBackColor;
                button.ForeColor = isSelected ? NewForeColor : DefForeColor;

                if (button.Image != null)
                {
                    button.Image = isSelected ? listNewImages[index] : listDefaultImages[index];
                }
                else
                {
                    button.Image = null;
                }

                // Unsubscribe from events first to prevent duplicate subscriptions
                button.MouseEnter -= Button_MouseEnter;
                button.MouseClick -= Button_MouseClick;
                button.MouseLeave -= Button_MouseLeave;

                // Subscribe to events based on selection state
                if (isSelected)
                {
                    button.MouseEnter += Button_MouseEnter;
                    button.MouseClick += Button_MouseClick;
                    button.MouseLeave += Button_MouseLeave;
                }
            }
        }

        private void Button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = NewForeColor;
            button.BackColor = NewBackColor;
        }

        private void Button_MouseClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = NewForeColor;
            button.BackColor = NewBackColor;
        }

        private void Button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = DefForeColor;
            button.BackColor = DefBackColor;
        }
    }
}
