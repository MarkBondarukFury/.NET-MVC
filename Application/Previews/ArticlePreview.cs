using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Previews
{
    public class ArticlePreview
    {
        public string Name { get; set; }
        [Range(1, 200)]
        public string Text { get; set; }

        public ArticlePreview(Article article)
        {
            Name = article.Name;
            if (article.Text.Length > 200)
                Text = article.Text.Substring(0, 200);
            else Text = article.Text;
        }
    }
}
