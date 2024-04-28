using MarketManager.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MarketManager.View
{
    public partial class NotesView : Form
    {

        public event Action ShowAddNoteDialog;

        public NotesView()
        {
            InitializeComponent();

            grid_notes.DataBindingComplete += (_, e) => grid_notes.ClearSelection();
            button_addnote.Click += (_, e) => ShowAddNoteDialog?.Invoke();
        }

        public void UpdateLabel(string text)
        {
            if(!label_info.Visible)
            {
                label_info.Visible = true;
            }
            
            label_info.Text = text;
        }

        public void ShowNotes(List<Note> notes)
        {
            foreach(var note in notes)
            {
                grid_notes.Rows.Add(note.Title, note.CreationDate.ToString());
            }

            grid_notes.Visible = true;
        }
    }
}
