using MarketManager.Model;
using MarketManager.View;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MarketManager.Controller
{
    public class ContactsController
    {
        public ContactsView View { get; }
        private List<Contact> _contacts;

        public ContactsController(ContactsView view)
        {
            View = view;

            LoadContacts($"{Application.StartupPath}/contacts.json");
        }

        public void LoadContacts(string filePath)
        {
            try
            {
                string json = "";

                if (!File.Exists(filePath))
                {
                    _contacts = new List<Contact>();
                    json = JsonConvert.SerializeObject(_contacts);
                    File.WriteAllText(filePath, json);
                }
                else
                {
                    json = File.ReadAllText(filePath);
                    _contacts = JsonConvert.DeserializeObject<List<Contact>>(json);
                    //View.ShowNotes(_notes);
                }
                if (_contacts.Count == 0)
                {
                    View.UpdateLabel("No contacts have been created.");
                }
            }
            catch (Exception ex)
            {
                View.UpdateLabel($"An error occurred while loading contacts: {ex.Message}");
            }
        }

        public void UpdateContacts(string filePath)
        {
            try
            {
                var json = JsonConvert.SerializeObject(_contacts);
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                View.UpdateLabel($"An error occurred while saving the contact: {ex.Message}");
            }
        }

    }
}
