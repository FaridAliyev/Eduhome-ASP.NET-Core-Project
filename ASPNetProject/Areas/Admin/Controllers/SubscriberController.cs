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
    public class SubscriberController : Controller
    {
        private readonly AppDbContext _db;
        public SubscriberController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Subscribers.OrderByDescending(s=>s.Id));
        }

        public IActionResult NotSeen()
        {
            return View(_db.Subscribers.Where(m => m.Checked == false).OrderByDescending(m => m.Id));
        }

        public async Task<IActionResult> MarkAsSeen(int? id, string returnUrl)
        {
            if (id == null)
            {
                return NotFound();
            }
            Subscriber subscriber = await _db.Subscribers.FindAsync(id);
            if (subscriber == null)
            {
                return NotFound();
            }
            subscriber.Checked = true;
            await _db.SaveChangesAsync();
            if (string.IsNullOrEmpty(returnUrl))
            {
                return RedirectToAction("Index");
            }
            return LocalRedirect(returnUrl);
        }

        public async Task<IActionResult> MarkAllAsSeen(string returnUrl)
        {
            foreach (Subscriber subscriber in _db.Subscribers)
            {
                if (!subscriber.Checked)
                {
                    subscriber.Checked = true;
                }
            }
            await _db.SaveChangesAsync();
            return LocalRedirect(returnUrl);
        }

        public IActionResult Search(string term)
        {
            var model = _db.Subscribers.Where(c => c.Email.Contains(term)).Take(4);
            return PartialView("_ApSubscriberSearch", model);
        }
    }
}