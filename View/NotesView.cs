using MarketManager.Control.Notes;
using MarketManager.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MarketManager.View
{
    public partial class NotesView : Form
    {

        public event Action ShowAddNoteDialog;

        public event Action<Note> ViewNote;
        public event Action<Note> DeleteNote;
        public event Action<Note> EditNote;

        public NotesView()
        {
            InitializeComponent();

            //grid_notes.DataBindingComplete += (_, e) => grid_notes.ClearSelection();
            button_addnote.Click += (_, e) => ShowAddNoteDialog?.Invoke();
        }

        public void UpdateLabel(string text)
        {
            label_info.Visible = true;
            panel_notes.Visible = false;
            label_info.Text = text;
        }

        public void ShowNotes(List<Note> notes)
        {
            foreach(var note in notes)
            {
                ShowNote(note);
            }

            panel_notes.Visible = true;

            //grid_notes.Visible = true;
        }

        public void ShowNote(Note note)
        {
            var noteControl = new NoteUserControl(note);
            noteControl.ControlViewNote += (_) => ViewNote?.Invoke(_);
            noteControl.ControlDeleteNote += (_) => DeleteNote?.Invoke(_);
            noteControl.ControlEditNote += (_) => EditNote?.Invoke(_);
            panel_notes.Controls.Add(noteControl);

            if(!panel_notes.Visible)
            {
                panel_notes.Visible = true;
            }
            //grid_notes.Rows.Add(note.Title, note.CreationDate.ToString());
        }

        public void HideNote(Note note)
        {
            foreach(var control in panel_notes.Controls)
            {
                var noteControl = control as NoteUserControl;
                if(noteControl.Note == note)
                {
                    noteControl.Dispose();
                    panel_notes.Controls.Remove(noteControl);
                }
            }
        }

        public void UpdateNote(Note note)
        {
            foreach (var control in panel_notes.Controls)
            {
                var noteControl = control as NoteUserControl;
                if (noteControl.Note == note)
                {
                    noteControl.Reload();
                }
            }
        }


    }
}
