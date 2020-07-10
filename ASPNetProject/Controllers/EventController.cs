using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.Models;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNetProject.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDbContext _db;
        public EventController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            EventVM model = new EventVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                Events=_db.Events.OrderByDescending(e=>e.Id).Take(6),
                Courses = _db.Courses.Take(6),
                SideBlogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3)
            };

            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Event evt = await _db.Events.FindAsync(id);

            if (evt == null)
            {
                return NotFound();
            }

            EventVM model = new EventVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                Event = _db.Events.Include(e => e.EventSpeakers).FirstOrDefault(e => e.Id == id),
                EventSpeakers = _db.EventSpeakers.Include(es=>es.Speaker),
                Courses=_db.Courses.Take(6),
                SideBlogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3)
            };
            
            return View(model);
        }

        public IActionResult Search(string term)
        {
            var model = _db.Events.Where(e => e.Name.Contains(term)).Select(e => new Event
            {
                Id = e.Id,
                Name = e.Name
            }).Take(8);
            return PartialView("_EventSearch", model);
        }
    }
}