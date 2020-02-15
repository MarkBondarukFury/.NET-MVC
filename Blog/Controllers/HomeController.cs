using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application;
using Db.Services;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ArticleService articleService = new ArticleService();
            ViewBag.Articles = articleService.GetArticles();
            return View();
        }

        public ActionResult Questionary()
        {
            return View();
        }

        public ActionResult Review()
        {
            ReviewService reviewService = new ReviewService();
            ViewBag.Reviews = reviewService.GetReviews();
            return View();
        }
        public ActionResult AddReview(Review review)
        {
            ReviewService reviewService = new ReviewService();
            reviewService.CreateReview(review.AuthorName, review.Text);
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