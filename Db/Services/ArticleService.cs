using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace Db.Services
{
    public class ArticleService
    {
        public void CreateArticle(string articleName, string text)
        {
            using (var ctx = new BlogContext())
            {
                var articles = ctx.Articles;

                if (articles.Any(a => a.Name != articleName))
                {
                    articles.Add(new Article(articleName, text));
                }
                ctx.SaveChanges();
            }
        }
        public IEnumerable<Article> GetArticles()
        {
            using (var ctx = new BlogContext())
            {
                var articles = ctx.Articles;

                return articles.ToList();
            }
        }
    }
}
