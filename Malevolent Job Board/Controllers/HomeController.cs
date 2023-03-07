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
            return View();
        }

        public IActionResult AddPosts()
        {
            List<string> PostTypes = new List<string>(){ "Full Time", "Part Time", "Internship", "Contract" };
            ViewBag.PostTypes = PostTypes;
            var post = new Post();
            return View(post);
        }
    }
}
