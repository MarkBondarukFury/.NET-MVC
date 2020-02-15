using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application
{
    public class Review
    {
        public Guid Id { get; set; }
        public string AuthorName { get; set; }
        public DateTime Date { get; private set; }
        public string Text { get; set; }

        public Review() { }
        public Review(string authorName, string text)
        {
            Id = Guid.NewGuid();
            AuthorName = authorName;
            Text = text;
            Date = DateTime.Now;
        }
    }
}