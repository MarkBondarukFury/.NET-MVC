using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Application;

namespace Db.Services
{
    public class ReviewService
    {
        public void CreateReview(string authorName, string text)
        {
            using (var ctx = new BlogContext())
            {
                var reviews = ctx.Reviews;

                reviews.Add(new Review(authorName, text));
                ctx.SaveChanges();
            }
        }
        public IEnumerable<Review> GetReviews()
        {
            using (var ctx = new BlogContext())
            {
                var reviews = ctx.Reviews;
                return reviews.ToList();
            }
        }
    }
}
