using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.Helpers;
using ASPNetProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class TestimonialController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly AppDbContext _db;
        public TestimonialController(AppDbContext db, IHostingEnvironment env)
        {
            _env = env;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Testimonials);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Testimonial testimonial = await _db.Testimonials.FindAsync(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return View(testimonial);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Testimonial testimonial)
        {
            if (!testimonial.Photo.isImage())
            {
                ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                return View();
            }
            Testimonial newTestimonial = testimonial;
            newTestimonial.Image = await testimonial.Photo.SaveImg(_env.WebRootPath, "img/testimonial");
            _db.Testimonials.Add(newTestimonial);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Testimonial testimonial = await _db.Testimonials.FindAsync(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return View(testimonial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Testimonial testimonial, IFormFile File)
        {
            if (id == null)
            {
                return NotFound();
            }
            Testimonial newTestimonial = await _db.Testimonials.FindAsync(id);
            if (newTestimonial == null)
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
                Extensions.DeleteImg(_env.WebRootPath, "img/testimonial", newTestimonial.Image);
                newTestimonial.Image = await File.SaveImg(_env.WebRootPath, "img/testimonial");
            }
            newTestimonial.Fullname = testimonial.Fullname;
            newTestimonial.Review = testimonial.Review;
            newTestimonial.Duty = testimonial.Duty;
            newTestimonial.Qualification = testimonial.Qualification;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (_db.Testimonials.Count()<=1)
            {
                return NotFound();
            }
            if (id == null)
            {
                return NotFound();
            }
            Testimonial testimonial = await _db.Testimonials.FindAsync(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            return View(testimonial);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteTestimonial(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Testimonial testimonial = await _db.Testimonials.FindAsync(id);
            if (testimonial == null)
            {
                return NotFound();
            }
            Extensions.DeleteImg(_env.WebRootPath, "img/testimonial", testimonial.Image);
            _db.Testimonials.Remove(testimonial);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Search(string term)
        {
            ViewBag.TestimonialCount = _db.Testimonials.Count();
            var model = _db.Testimonials.Where(c => c.Fullname.Contains(term)).Take(4);
            return PartialView("_ApTestimonialSearch", model);
        }
    }
}