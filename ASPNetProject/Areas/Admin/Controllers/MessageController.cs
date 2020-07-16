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
    public class MessageController : Controller
    {
        private readonly AppDbContext _db;
        public MessageController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Messages.OrderByDescending(m=>m.Id));
        }

        public async Task<IActionResult> Details(int? id,string returnUrl)
        {
            if (id==null)
            {
                return NotFound();
            }
            Message message = await _db.Messages.FindAsync(id);
            if (message==null)
            {
                return NotFound();
            }
            ViewBag.Return = returnUrl;
            message.Read = true;
            await _db.SaveChangesAsync();
            return View(message);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Details")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Message message = await _db.Messages.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }
            _db.Messages.Remove(message);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public IActionResult New()
        {
            return View(_db.Messages.Where(m => m.Read == false).OrderByDescending(m => m.Id));
        }

        public async Task<IActionResult> MarkAsRead(int? id,string returnUrl)
        {
            if (id == null)
            {
                return NotFound();
            }
            Message message = await _db.Messages.FindAsync(id);
            if (message == null)
            {
                return NotFound();
            }
            message.Read = true;
            await _db.SaveChangesAsync();
            return LocalRedirect(returnUrl);
        }

        public async Task<IActionResult> MarkAllAsRead(string returnUrl)
        {
            foreach (Message message in _db.Messages)
            {
                if (!message.Read)
                {
                    message.Read = true;
                }
            }
            await _db.SaveChangesAsync();
            return LocalRedirect(returnUrl);
        }
    }
}