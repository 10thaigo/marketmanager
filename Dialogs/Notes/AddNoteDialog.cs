﻿using MarketManager.Model;
using System;
using System.Windows.Forms;

namespace MarketManager.Dialogs.Notes
{
    public partial class AddNoteDialog : Form
    {

        public event Action Exit;
        public event Action<Note> Insert;

        public AddNoteDialog()
        {
            InitializeComponent();

            button_exit.Click += (_, e) => Exit?.Invoke();
            button_addnote.Click += (_, e) =>
            {
                bool validTitle = false;
                bool validDescription = false;

                if(string.IsNullOrEmpty(textbox_title.Text) || string.IsNullOrWhiteSpace(textbox_title.Text))
                {
                    label_error_title.Show();
                    validTitle = false;
                }
                else
                {
                    if(label_error_title.Visible)
                    {
                        label_error_title.Hide();
                    }

                    validTitle = true;
                }

                if (string.IsNullOrEmpty(textbox_description.Text) || string.IsNullOrWhiteSpace(textbox_description.Text))
                {
                    label_error_description.Show();
                    validDescription = false;
                }
                else
                {
                    if (label_error_description.Visible)
                    {
                        label_error_description.Hide();
                    }

                    validDescription = true;
                }

                if(validTitle && validDescription)
                {
                    Insert?.Invoke(new Note(textbox_title.Text, textbox_description.Text, DateTime.Now));
                }
            };
        }
    }
}
