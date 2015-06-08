using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using PagedList;

namespace MVC5Blog.Models
{
    using System;
    using System.Data.Entity;

    namespace MvcMovie.Models
    {
        public class Post
        {
            public Post()
        {
            Post_Time = DateTime.Now;
        }
            public int ID { get; set; }
            public string Title { get; set; }
            public DateTime Post_Time { get; set; }
            public string Description { get; set; }
            [AllowHtml]
            public string Category { get; set; }
            public string Contents { get; set; }
            public string Image { get; set; }
        }

        public class PostDBContext : DbContext
        {
            public DbSet<Post> Posts { get; set; }
        }
    }
}