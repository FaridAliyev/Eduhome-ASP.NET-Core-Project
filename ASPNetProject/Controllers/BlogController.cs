using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.Models;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Controllers
{
    public class BlogController : Controller
    {
        private readonly AppDbContext _db;
        public BlogController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index(int cp=1)
        {
            ViewBag.CurrentPage = cp;
            ViewBag.BlogPageCount = Math.Ceiling((decimal)_db.Blogs.Count() / 6);
            IEnumerable<Blog> blogs = _db.Blogs.OrderByDescending(b => b.Id).Skip((cp - 1) * 6).Take(6);
            BlogVM model = new BlogVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                Courses = _db.Courses.Take(6),
                Blogs = blogs,
                SideBlogs=_db.Blogs.OrderByDescending(b=>b.Id).Take(3)
            };

            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Blog blog = await _db.Blogs.FindAsync(id);

            if (blog == null)
            {
                return NotFound();
            }

            BlogVM model = new BlogVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                SideBlogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3),
                Blog = _db.Blogs.FirstOrDefault(b => b.Id == id),
                Courses = _db.Courses.Take(6)
            };

            return View(model);
        }

        public IActionResult Search(string term)
        {
            var model = _db.Blogs.Where(b => b.Title.Contains(term)).Select(b => new Blog
            {
                Id = b.Id,
                Title = b.Title
            }).Take(8);
            return PartialView("_BlogSearch", model);
        }
    }
}