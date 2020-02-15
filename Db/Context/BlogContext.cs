using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Application;

namespace Db
{
    public class BlogContext : DbContext
    {
        static BlogContext()
        {
            Database.SetInitializer(new BlogContextInitializer());
        }
        public BlogContext() : 
            base() { }

        public DbSet<Review> Reviews { get; set; }
        public DbSet<Article> Articles { get; set; }
    }
}
