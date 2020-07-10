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
    public class TeacherController : Controller
    {
        private readonly AppDbContext _db;
        public TeacherController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            TeachersVM model = new TeachersVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
            };

            return View(model);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Teacher teacher = await _db.Teachers.FindAsync(id);

            if (teacher == null)
            {
                return NotFound();
            }

            TeachersVM model = new TeachersVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                Teacher = _db.Teachers.Include(t => t.TeacherInfo).Include(t=>t.Skill).Include(t=>t.Faculty).FirstOrDefault(t => t.Id == id),
                TeacherHobbies=_db.TeacherHobbies.Include(th=>th.Hobbie),
                TeacherDegrees=_db.TeacherDegrees.Include(td=>td.Degree)
            };

            return View(model);
        }

        public IActionResult Search(string term)
        {
            var model = _db.Teachers.Where(t => t.Fullname.Contains(term)).Select(t => new Teacher
            {
                Id = t.Id,
                Fullname = t.Fullname
            }).Take(8);
            return PartialView("_TeacherSearch", model);
        }
    }
}