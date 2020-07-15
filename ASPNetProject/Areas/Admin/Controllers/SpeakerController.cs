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
    public class SpeakerController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly AppDbContext _db;
        public SpeakerController(AppDbContext db, IHostingEnvironment env)
        {
            _env = env;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Speakers);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Speaker speaker = await _db.Speakers.FindAsync(id);
            if (speaker == null)
            {
                return NotFound();
            }
            return View(speaker);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Speaker speaker)
        {
            if (!speaker.Photo.isImage())
            {
                ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                return View();
            }
            Speaker newSpeaker = speaker;
            newSpeaker.Image = await speaker.Photo.SaveImg(_env.WebRootPath, "img/event");
            _db.Speakers.Add(newSpeaker);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Speaker speaker = await _db.Speakers.FindAsync(id);
            if (speaker == null)
            {
                return NotFound();
            }
            return View(speaker);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,Speaker speaker, IFormFile File)
        {
            if (id == null)
            {
                return NotFound();
            }
            Speaker newSpeaker = await _db.Speakers.FindAsync(id);
            if (newSpeaker == null)
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
                Extensions.DeleteImg(_env.WebRootPath, "img/event", newSpeaker.Image);
                newSpeaker.Image = await File.SaveImg(_env.WebRootPath, "img/event");
            }
            newSpeaker.Fullname=speaker.Fullname;
            newSpeaker.Duty = speaker.Duty;
            newSpeaker.Company = speaker.Company;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Speaker speaker = await _db.Speakers.FindAsync(id);
            if (speaker == null)
            {
                return NotFound();
            }
            return View(speaker);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSpeaker(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Speaker speaker = await _db.Speakers.FindAsync(id);
            if (speaker == null)
            {
                return NotFound();
            }
            Extensions.DeleteImg(_env.WebRootPath, "img/event", speaker.Image);
            _db.Speakers.Remove(speaker);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}