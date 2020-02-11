using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Articles
    {
        public IList<Article> ArticleContainer;

        public Articles()
        {
            ArticleContainer = new List<Article>();

            for (int i = 1; i <= 30; i++)
                ArticleContainer.Add(new Article($"Article {i}", $"Some information about something {i}", DateTime.Now));
        }
    }
}