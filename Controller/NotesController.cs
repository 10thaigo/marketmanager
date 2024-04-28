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
        public ViewNoteDialog _viewNoteDialog;
        public EditNoteDialog _editNoteDialog;
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

                _addNoteDialog.Insert += (_) =>
                {
                    _notes.Add(_);
                    UpdateNotes($"{Application.StartupPath}/notes.json");
                    View.ShowNote(_);

                    _addNoteDialog.Close();
                    _addNoteDialog = null;
                };

                _addNoteDialog.Show();
            };

            View.ViewNote += (_) =>
            {
                _viewNoteDialog?.Close();
                _viewNoteDialog = new ViewNoteDialog(_);
                _viewNoteDialog.Show();

                _viewNoteDialog.Exit += () =>
                {
                    _viewNoteDialog.Close();
                    _viewNoteDialog = null;
                };
            };

            View.DeleteNote += (_) =>
            {
                var result = MessageBox.Show($"Are you sure you want to delete the note \"{_.Title}\"? The changes are irreversible.", "Confirmation required", MessageBoxButtons.YesNo);
                if(result == DialogResult.Yes)
                {
                    _notes.Remove(_);
                    UpdateNotes($"{Application.StartupPath}/notes.json");
                    View.HideNote(_);

                    if (_notes.Count == 0)
                    {
                        View.UpdateLabel("No notes have been created.");
                    }
                }
            };

            View.EditNote += (_) =>
            {
                _editNoteDialog?.Close();
                _editNoteDialog = new EditNoteDialog(_);
                _editNoteDialog.Show();

                _editNoteDialog.Edit += (title, description) =>
                {
                    _.Title = title;
                    _.Description = description;

                    UpdateNotes($"{Application.StartupPath}/notes.json");
                    View.UpdateNote(_);

                    _editNoteDialog.Close();
                    _editNoteDialog = null;
                };

                _editNoteDialog.Exit += () =>
                {
                    _editNoteDialog.Close();
                    _editNoteDialog = null;
                };
            };

            View.FormClosed += (_, e) =>
            {
                _addNoteDialog?.Close();
                _viewNoteDialog?.Close();
                _editNoteDialog?.Close();
            };
        }

        public void LoadNotes(string filePath)
        {
            try
            {
                string json = "";

                if (!File.Exists(filePath))
                {
                    _notes = new List<Note>();
                    json = JsonConvert.SerializeObject(_notes);
                    File.WriteAllText(filePath, json);
                }
                else
                {
                    json = File.ReadAllText(filePath);
                    _notes = JsonConvert.DeserializeObject<List<Note>>(json);
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

        public void UpdateNotes(string filePath)
        {
            try
            {
                var json = JsonConvert.SerializeObject(_notes);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                View.UpdateLabel($"An error occurred while saving the note: {ex.Message}");
            }
        }
    }
}
