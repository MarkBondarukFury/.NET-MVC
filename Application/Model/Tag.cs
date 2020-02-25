using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application
{
    public class Tag
    {
        public Guid Id { get; set; }
        public string TagString { get; set; }
        public List<Article> Articles { get; set; }

        public Tag() { }
        public Tag(string tag)
        {
            Id = Guid.NewGuid();
            TagString = tag;
            Articles = new List<Article>();
        }
    }
}
