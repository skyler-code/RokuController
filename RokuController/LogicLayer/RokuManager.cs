using System;
using System.Collections.Generic;
using RokuAccess;
using RokuDataObjects;
using System.Windows;
using System.Threading.Tasks;

namespace ControllerLogic
{
    public class RokuManager
    {
        private List<Roku> rokus = null;

        public List<Roku> RokuList
        { 
            get
            {
                if(rokus == null)
                {
                    RefreshRokus();
                }
                return rokus;
            }
        }

        public Roku SelectedRoku { get; set; } = null;

        public void RefreshRokus()
        {
            rokus = RokuAccessor.GetRokuList();
            if (rokus.Count > 0)
            {
                SelectedRoku = rokus[0];
            }
        }

        public void PressButton(KeyCode keyCode)
        {
            if(SelectedRoku == null)
            {
                MessageBox.Show("No Roku Selected!");
                return;
            }
            RokuAccessor.SendRokuButton(SelectedRoku, keyCode);
        }

        public void LaunchApp(RokuApp app)
        {
            if (SelectedRoku == null)
            {
                MessageBox.Show("No Roku Selected!");
                return;
            }
            RokuAccessor.LaunchRokuApp(SelectedRoku, app);
        }
    }
}
