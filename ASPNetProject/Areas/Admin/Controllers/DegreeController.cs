using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DegreeController : Controller
    {
        private readonly AppDbContext _db;
        public DegreeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Degrees);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Degree degree)
        {
            _db.Degrees.Add(degree);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Degree degree = await _db.Degrees.FindAsync(id);
            if (degree == null)
            {
                return NotFound();
            }
            return View(degree);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteDegree(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Degree degree = await _db.Degrees.FindAsync(id);
            if (degree == null)
            {
                return NotFound();
            }
            _db.Degrees.Remove(degree);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Search(string term)
        {
            var model = _db.Degrees.Where(c => c.Name.Contains(term)).Take(4);
            return PartialView("_ApDegreeSearch", model);
        }
    }
}