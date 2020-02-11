using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Article
    {
        public string Name { get; set; }
        public DateTime PublishDate { get; private set; }
        public string Text { get; set; }

        public Article() { }
        public Article(string name, string text)
        {
            Name = name;
            Text = text;
        }
        public Article(string name, string text, DateTime date)
        {
            Name = name;
            Text = text;
            PublishDate = date;
        }
    }
}