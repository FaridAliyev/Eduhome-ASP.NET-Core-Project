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
    [Authorize(Roles ="Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _db;
        private readonly IDataProtector dataProtector;
        public DashboardController(AppDbContext db, IDataProtectionProvider provider)
        {
            _db = db;
            dataProtector = provider.CreateProtector("cry");
        }
        public IActionResult Index(string check)
        {
            int decrypt = 0;
            if (!string.IsNullOrEmpty(check))
            {
                if (int.TryParse(dataProtector.Unprotect(check), out decrypt) == false)
                {
                    throw new Exception("Invalid cypher text");
                }
            }
            ViewBag.Check = decrypt;
            return View();
        }

        public async Task<IActionResult> Undo()
        {
            NoticeBoard notice = _db.NoticeBoards.OrderByDescending(n => n.Id).FirstOrDefault(n => n.PostedBy == User.Identity.Name);
            string desc = notice.Description;
            _db.NoticeBoards.Remove(notice);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index", "Notice", new { nb = desc });
        }
    }
}