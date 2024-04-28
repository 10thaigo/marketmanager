using MarketManager.Model;
using System;
using System.Windows.Forms;

namespace MarketManager.Control.Notes
{
    public partial class NoteUserControl : UserControl
    {
        public Note Note { get; }
        public event Action<Note> ControlViewNote;
        public event Action<Note> ControlEditNote;
        public event Action<Note> ControlDeleteNote;

        public NoteUserControl(Note note)
        {
            Note = note;
            InitializeComponent();

            label_title.Text = Note.Title;
            label_date.Text = Note.CreationDate.ToString();

            button_see.Click += (_, e) => ControlViewNote?.Invoke(Note);
            button_edit.Click += (_, e) => ControlEditNote?.Invoke(Note);
            button_delete.Click += (_, e) => ControlDeleteNote?.Invoke(Note);
        }

        public void Reload()
        {
            label_title.Text = Note.Title;
            label_date.Text = Note.CreationDate.ToString();
        }
    }
}
