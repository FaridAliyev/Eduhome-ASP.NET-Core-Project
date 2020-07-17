using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.Helpers;
using ASPNetProject.Models;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class BlogController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly AppDbContext _db;
        public BlogController(AppDbContext db, IHostingEnvironment env)
        {
            _env = env;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Blogs);
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
            return View(blog);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Blog newBlog,DateTime date)
        {
            if (!newBlog.Photo.isImage())
            {
                ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                return View();
            }
            Blog blog = newBlog;
            blog.Image = await blog.Photo.SaveImg(_env.WebRootPath, "img/blog");
            blog.Date = date.ToString("MMMM dd, yyyy");
            _db.Blogs.Add(blog);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
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
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Blog newBlog, IFormFile File, DateTime dateTime)
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
            if (File != null)
            {
                if (!File.isImage())
                {
                    ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                    return View();
                }
                Extensions.DeleteImg(_env.WebRootPath, "img/blog", blog.Image);
                blog.Image = await File.SaveImg(_env.WebRootPath, "img/blog");
            }
            blog.Title = newBlog.Title;
            blog.PostedBy = newBlog.PostedBy;
            blog.Date = newBlog.Date;
            blog.Description = newBlog.Description;
            blog.Quote = newBlog.Quote;
            if (dateTime.ToString() != "1/1/0001 12:00:00 AM")
            {
                blog.Date = dateTime.ToString("MMMM dd, yyyy");
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
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
            return View(blog);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteBlog(int? id)
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
            Extensions.DeleteImg(_env.WebRootPath, "img/blog", blog.Image);
            _db.Blogs.Remove(blog);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Search(string term)
        {
            var model = _db.Blogs.Where(c => c.Title.Contains(term)).Take(4);
            return PartialView("_ApBlogSearch", model);
        }
    }
}