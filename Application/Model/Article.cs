using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Application
{
    public class Article
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime PublishDate { get; private set; }
        public string Text { get; set; }

        public Article() { }
        public Article(string name, string text)
        {
            Id = Guid.NewGuid();
            Name = name;
            Text = text;
            PublishDate = DateTime.Now;
        }
        public Article(string name, string text, DateTime date)
        {
            Id = Guid.NewGuid();
            Name = name;
            Text = text;
            PublishDate = date;
        }
    }
}