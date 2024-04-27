using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MarketManager
{
    public partial class MainView : Form
    {
        private Form activeView = null;
        private IconButton activeButton = null;

        public event Action<string> ChangeView;

        public MainView()
        {
            InitializeComponent();

            button_information.Click += (_, e) => SwitchButton("Notes", button_notes);
            button_settings.Click += (_, e) => SwitchButton("Notes", button_notes);
            button_notes.Click += (_, e) => SwitchButton("Notes", button_notes);
            button_contacts.Click += (_, e) => SwitchButton("Notes", button_notes);
            button_stock.Click += (_, e) => SwitchButton("Notes", button_notes);
            button_sell.Click += (_, e) => SwitchButton("Notes", button_notes);
        }

        public void SwitchPanel(Form newView)
        {
            if (activeView == newView)
                return;

            activeView?.Close();
            activeView = newView;
            activeView.FormBorderStyle = FormBorderStyle.None;
            activeView.TopLevel = false;
            activeView.Dock = DockStyle.Fill;
            panel_view.Controls.Add(newView);
            panel_view.Tag = activeView;
            activeView.Show();
        }

        public void SwitchButton(string view, IconButton clickedButton)
        {
            if(activeButton != null)
            {
                activeButton.BackColor = SystemColors.Control;
                activeButton.BackColor = Color.DimGray;
                activeButton.IconColor = Color.DimGray;
            }

            clickedButton.BackColor = SystemColors.Highlight;
            clickedButton.ForeColor = Color.White;
            clickedButton.IconColor = Color.White;
            activeButton = clickedButton;

            ChangeView?.Invoke(view);
        }

        public void UpdateClock(string clock)
        {
            label_clock.Text = clock;
        }
    }
}