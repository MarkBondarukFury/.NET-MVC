using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Review
    {
        public string AuthorName { get; set; }
        public DateTime Date { get; private set; }
        public string Text { get; set; }

        public Review() { }
        public Review(string authorName, string text)
        {
            AuthorName = authorName;
            Text = text;
            Date = DateTime.Now;
        }
    }
}