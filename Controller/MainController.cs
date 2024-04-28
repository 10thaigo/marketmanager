using MarketManager.View;
using System;
using System.Windows.Forms;
using Timer = System.Timers.Timer;

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
                if (_.CompareTo("Information") == 0)
                {
                    View.SwitchPanel(new InformationController(new InformationView()).View);
                }
                else if (_.CompareTo("Settings") == 0)
                {
                    View.SwitchPanel(new SettingsController(new SettingsView()).View);
                }
                else if (_.CompareTo("Notes") == 0)
                {
                    View.SwitchPanel(new NotesController(new NotesView()).View);
                }
                else if (_.CompareTo("Contacts") == 0)
                {
                    View.SwitchPanel(new ContactsController(new ContactsView()).View);
                }
                else if (_.CompareTo("Stock") == 0)
                {
                    View.SwitchPanel(new StockController(new StockView()).View);
                }
                else if (_.CompareTo("Sell") == 0)
                {
                    View.SwitchPanel(new SellController(new SellView()).View);
                }
            };

            View.ExitApplication += () => Application.Exit();

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