using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public static class Reviews
    {
        public static IList<Review> ReviewContainer = new List<Review>() { new Review("Reviewer 1", "Some feedback"), new Review("Reviewer 2", "Some feedback 2") };
    }
}