using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForms
{
    public class NavigationControl
    {
        List<UserControl> UserControlList = new();
        Panel Panel;

        public NavigationControl(List<UserControl> userControls, Panel panel)
        {
            UserControlList = userControls;
            Panel = panel;
            AddUserControls();
        }

        private void AddUserControls()
        {
            foreach(UserControl userControl in UserControlList)
            {
                // set every UseerControl's dock style to fill so that will occupy the space inside the panel
                userControl.Dock = DockStyle.Fill;

                // add all the UserControl inside the panel
                Panel.Controls.Add(userControl);
            }
        }

        public void Display(int index)
        {
            // display the selected UserControl using index
            UserControlList[index].BringToFront();
        }
    }
}
