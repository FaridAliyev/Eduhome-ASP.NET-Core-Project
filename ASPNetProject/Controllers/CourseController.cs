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
                Courses=_db.Courses.Take(6)
            };
            return View(model);
        }
    }
}