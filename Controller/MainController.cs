using MarketManager.View;
using System;
using System.Timers;

namespace MarketManager.Controller
{
    public class MainController
    {
        public MainView View { get; }

        public MainController(MainView view)
        {
            View = view;
            View.ChangeView += (_) =>
            {   
                if(_.CompareTo("Notes") == 0)
                {
                    View.SwitchPanel(new NotesController(new NotesView()).View);
                }
            };
            
            var dateAndTime = $"The current date and time is {DateTime.Now:ddd MMM dd HH: mm:ss yyyy}";
            var timer = new Timer(1000d);

            View.UpdateClock(dateAndTime);

            timer.Elapsed += (_, e) =>
            {
                dateAndTime = $"The current date and time is {DateTime.Now:ddd MMM dd HH: mm:ss yyyy}";

                if (View.InvokeRequired)
                {
                    View.Invoke(new Action(() => View.UpdateClock(dateAndTime)));
                }
                else
                {
                    View.UpdateClock(dateAndTime);
                }
            };

            timer.Start();
        }
    }
}