using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.Helpers;
using ASPNetProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class SliderController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly AppDbContext _db;
        public SliderController(AppDbContext db, IHostingEnvironment env)
        {
            _env = env;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!slider.Photo.isImage())
            {
                ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                return View();
            }
            Slider newSlider=slider;
            newSlider.Image = await slider.Photo.SaveImg(_env.WebRootPath, "img/slider");
            _db.Sliders.Add(newSlider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (_db.Sliders.Count()<2)
            {
                return NotFound();
            }
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider==null)
            {
                return NotFound();
            }
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Slider slider = await _db.Sliders.FindAsync(id);
            if (slider == null)
            {
                return NotFound();
            }
            Extensions.DeleteImg(_env.WebRootPath, "img/slider", slider.Image);
            _db.Sliders.Remove(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}