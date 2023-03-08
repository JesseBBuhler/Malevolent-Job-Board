using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Malevolent_Job_Board.Models;

namespace Malevolent_Job_Board.Controllers
{
    public class HomeController : Controller
    {
        private JobBoardContext Context;
        public HomeController(JobBoardContext temp)
        {
            Context = temp;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult ViewPosts()
        {
            IQueryable<Post> Posts = Context.Posts;
            return View(Posts);
        }

        [HttpGet]
        public IActionResult AddPosts()
        {
            ViewBag.Types = Context.PositionTypes.ToList();
            var post = new Post();

            return View(post);
        }
    }
}
