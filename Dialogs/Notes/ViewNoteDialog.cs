using MarketManager.Model;
using System;
using System.Windows.Forms;

namespace MarketManager.Dialogs.Notes
{
    public partial class ViewNoteDialog : Form
    {

        public event Action Exit;

        public ViewNoteDialog(Note note)
        {
            InitializeComponent();

            label_title.Text = $"Created on: {note.CreationDate}";
            textbox_title.Text = note.Title;
            textbox_description.Text = note.Description;
            button_exit.Click += (_, e) => Exit?.Invoke();
        }
    }
}
