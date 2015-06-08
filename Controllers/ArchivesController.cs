using MVC5Blog.Models.MvcMovie.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBlogProject.Controllers
{
    public class ArchiveController : Controller
    {
        private PostDBContext db = new PostDBContext();

        public ActionResult Index()
        {
            int length = db.Posts.Count();
            List<Post> post_List = db.Posts.OrderBy(i => i.Post_Time).Take(length).ToList();
            return View(post_List);
        }

        public ActionResult Post_Detail(int post_Id)
        {

            Post post = (from i in db.Posts where i.ID == post_Id select i).SingleOrDefault();
            return View(post);
        }
     }
}