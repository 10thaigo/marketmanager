using System;

namespace MarketManager.Model
{
    public class Note
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime CreationDate { get; set; }

        public Note(string title, string description, DateTime creationDate)
        {
            Title = title;
            Description = description;
            CreationDate = creationDate;
        }
    }
}
