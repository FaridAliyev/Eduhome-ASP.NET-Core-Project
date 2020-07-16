using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.Models;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNetProject.Controllers
{
    public class ContactController : Controller
    {
        private readonly AppDbContext _db;
        public ContactController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            ContactVM model = new ContactVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                Bio = _db.Bios.FirstOrDefault()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Subscribe(FooterVM footerVM,string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            bool exists = _db.Subscribers.Any(s => s.Email == footerVM.Subscriber.Email);
            if (exists)
            {
                return NotFound();
            }
            Subscriber subscriber = footerVM.Subscriber;
            _db.Subscribers.Add(subscriber);
            await _db.SaveChangesAsync();
            return LocalRedirect(returnUrl);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Message(CoursesVM coursesVM, string returnUrl)
        {
            if (!ModelState.IsValid)
            {
                return NotFound();
            }
            Message message = coursesVM.Message;
            _db.Messages.Add(message);
            await _db.SaveChangesAsync();
            return LocalRedirect(returnUrl);
        }
    }
}