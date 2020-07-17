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
    public class HobbyController : Controller
    {
        private readonly AppDbContext _db;
        public HobbyController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Hobbies);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Hobbie hobby)
        {
            _db.Hobbies.Add(hobby);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Hobbie hobby = await _db.Hobbies.FindAsync(id);
            if (hobby == null)
            {
                return NotFound();
            }
            return View(hobby);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteHobby(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Hobbie hobby = await _db.Hobbies.FindAsync(id);
            if (hobby == null)
            {
                return NotFound();
            }
            _db.Hobbies.Remove(hobby);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult Search(string term)
        {
            var model = _db.Hobbies.Where(c => c.Name.Contains(term)).Take(4);
            return PartialView("_ApHobbySearch", model);
        }
    }
}