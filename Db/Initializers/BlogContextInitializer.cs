﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Application;

namespace Db
{
    /// <summary>
    /// Base data installation
    /// </summary>
    public class BlogContextInitializer : DropCreateDatabaseAlways<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            var reviews = new List<Review>
            {
                new Review("First example review", "Adding some text"),
                new Review("Another review", "Continuing adding text")
            };

            reviews.ForEach(r => context.Reviews.Add(r));

            var articles = new List<Article>();

            for (int i = 1; i <= 30; i++)
            {
                Article article = new Article($"Artcle {i}", $"Some information about something {i}");
                articles.Add(article);
            }

            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();
            
            base.Seed(context);
        }
    }
}