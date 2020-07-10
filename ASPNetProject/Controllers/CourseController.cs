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
    public class CourseController : Controller
    {
        private readonly AppDbContext _db;
        public CourseController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            CoursesVM model = new CoursesVM()
            {
                Background = _db.Backgrounds.FirstOrDefault()
            };

            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Course course = await _db.Courses.FindAsync(id);

            if (course==null)
            {
                return NotFound();
            }

            CoursesVM model = new CoursesVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                Course=_db.Courses.Include(c=>c.CourseDetail).Include(c=>c.CourseFeature).FirstOrDefault(c=>c.Id==id),
                Courses=_db.Courses.Take(6),
                SideBlogs = _db.Blogs.OrderByDescending(b => b.Id).Take(3)
            };
            return View(model);
        }

        public IActionResult Search(string term)
        {
            var model = _db.Courses.Where(c => c.Name.Contains(term)).Select(c => new Course
            {
                Id = c.Id,
                Name = c.Name
            }).Take(8);
            return PartialView("_CourseSearch", model);
        }

        public IActionResult Filter(string search)
        {
            if (search==null)
            {
                return RedirectToAction("Index");
            }
            IEnumerable<Course> courses;
            bool check = _db.Courses.Any(c => c.Name.Contains(search));
            if (check)
            {
                courses = _db.Courses.Where(c => c.Name.Contains(search)).Take(9);
            }
            else
            {
                courses = null;
            }
            CoursesVM model = new CoursesVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                Courses = courses
            };

            return View(model);
        }
    }
}