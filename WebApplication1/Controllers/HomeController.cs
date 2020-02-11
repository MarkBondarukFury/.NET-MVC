using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using WebApplication1.Models;

namespace WebApplication4.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Articles = new Articles().ArticleContainer;
            return View();
        }

        public ActionResult Questionary()
        {
            return View();
        }

        public ActionResult Review()
        {
            ViewBag.Reviews = Reviews.ReviewContainer;
            return View();
        }
        public ActionResult AddReview(Review review)
        {
            Reviews.ReviewContainer.Add(new Review(review.AuthorName, review.Text));
            return Redirect("Review");
        }

        public ActionResult QuestionaryResult(string field1, string field2, string[] value, string choice)
        {
            ViewBag.Field1 = field1;
            ViewBag.Field2 = field2;
            ViewBag.Values = value;
            ViewBag.Choice = choice;
            return View();
        }
    }
}