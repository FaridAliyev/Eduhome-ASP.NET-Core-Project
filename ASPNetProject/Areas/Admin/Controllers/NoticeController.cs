using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class NoticeController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IDataProtector dataProtector;
        public NoticeController(AppDbContext db,IDataProtectionProvider provider)
        {
            _db = db;
            dataProtector = provider.CreateProtector("cry");
        }
        public IActionResult Index(string nb)
        {
            ViewBag.Desc = nb;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Index")]
        public async Task<IActionResult> Post(NoticeBoard notice)
        {
            NoticeBoard newNotice = notice;
            newNotice.Date = DateTime.Now.ToString("dd, MMMM yyyy");
            newNotice.PostedBy = User.Identity.Name;
            _db.NoticeBoards.Add(newNotice);
            await _db.SaveChangesAsync();
            int val = 7;
            string encrypted = dataProtector.Protect(val.ToString());
            return RedirectToAction("Index", "Dashboard", new { check = encrypted });
        }
    }
}