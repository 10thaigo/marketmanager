using MarketManager.Dialogs.Notes;
using MarketManager.Model;
using MarketManager.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MarketManager.Controller
{
    public class NotesController
    {
        public NotesView View { get; }
        public AddNoteDialog _addNoteDialog;
        private List<Note> _notes;

        public NotesController(NotesView view)
        {
            View = view;

            LoadNotes($"{Application.StartupPath}/notes.json");

            View.ShowAddNoteDialog += () =>
            {
                if (_addNoteDialog != null)
                {
                    return;
                }

                _addNoteDialog = new AddNoteDialog();

                _addNoteDialog.Exit += () =>
                {
                    _addNoteDialog.Close();
                    _addNoteDialog = null;
                };

                _addNoteDialog.Insert += () =>
                {

                };

                _addNoteDialog.Show();
            };

            View.FormClosed += (_, e) => _addNoteDialog?.Close();
        }

        public void LoadNotes(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    _notes = new List<Note>();
                    var json = JsonConvert.SerializeObject(_notes);
                    File.WriteAllText(filePath, json);
                }
                else
                {
                    var json = File.ReadAllText(filePath);
                    _notes = JsonConvert.DeserializeObject<List<Note>>(json);

                    _notes.Add(new Note() { Title = "Test", Description = "This is a test", CreationDate = DateTime.Now });

                    View.ShowNotes(_notes);
                }
                if (_notes.Count == 0)
                {
                    View.UpdateLabel("No notes have been created.");
                }
            }
            catch (Exception ex)
            {
                View.UpdateLabel($"An error occurred while loading the notes: {ex.Message}");
            }
        }
    }
}
