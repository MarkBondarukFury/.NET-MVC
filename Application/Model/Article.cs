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
        public List<Tag> Tags { get; set; }

        public Article() { }
        public Article(string name, string text)
        {
            Id = Guid.NewGuid();
            Name = name;
            Text = text;
            PublishDate = DateTime.Now;
            Tags = new List<Tag>();
        }
        public Article(string name, string text, params string[] tags)
        {
            Id = Guid.NewGuid();
            Name = name;
            Text = text;
            PublishDate = DateTime.Now;
            Tags = new List<Tag>();

            foreach (var tag in tags)
                Tags.Add(new Tag(tag));
        }
        public Article(string name, string text, DateTime date)
        {
            Id = Guid.NewGuid();
            Name = name;
            Text = text;
            PublishDate = date;
            Tags = new List<Tag>();
        }
    }
}