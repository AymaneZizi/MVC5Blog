using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using MVC5Blog.Models.MvcMovie.Models;

namespace MVC5Blog.Controllers
{
    public class HomeController : Controller
    {
        private PostDBContext db = new PostDBContext();

        public ActionResult Index(int page = 1)
        {
            int length = db.Posts.Count();
            List<Post> Post_List = db.Posts.OrderBy(i => i.Post_Time).Take(length).ToList();
            return View(Post_List.OrderByDescending(x => x.Post_Time).ToPagedList(page, 10));

        }

        public ActionResult Post_Detail(int post_Id)
        {
            Post post = (from i in db.Posts where i.ID == post_Id select i).SingleOrDefault();
            return View(post);
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your About page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}