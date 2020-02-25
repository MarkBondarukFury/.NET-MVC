using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Application;
using Application.Previews;
using Db.Services;

namespace Blog.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ArticleService articleService = new ArticleService();
            var articlePreviews = new List<ArticlePreview>();
            
            foreach (var article in articleService.GetArticles())
                articlePreviews.Add(new ArticlePreview(article));

            ViewBag.Articles = articleService.GetArticles();
            ViewBag.Previews = articlePreviews;

            return View();
        }
        public ActionResult DisplayFullArticle(Article article)
        {
            ArticleService articleService = new ArticleService();
            Article article1 = articleService.GetArticle(article.Name);
            return View(articleService.GetArticle(article.Name));
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