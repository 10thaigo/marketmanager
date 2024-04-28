using System;
using System.Windows.Forms;

namespace MarketManager.Dialogs.Notes
{
    public partial class AddNoteDialog : Form
    {

        public event Action Exit;
        public event Action Insert;

        public AddNoteDialog()
        {
            InitializeComponent();

            button_exit.Click += (_, e) => Exit?.Invoke();
            button_addnote.Click += (_, e) => Insert?.Invoke();
        }
    }
}
