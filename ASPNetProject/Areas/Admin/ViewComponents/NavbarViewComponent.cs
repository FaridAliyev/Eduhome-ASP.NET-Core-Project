using ASPNetProject.Areas.Admin.ViewModels;
using ASPNetProject.DAL;
using ASPNetProject.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Areas.Admin.ViewComponents
{
    public class NavbarViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        private readonly UserManager<User> _userManager;
        public NavbarViewComponent(AppDbContext db, UserManager<User> userManager)
        {
            _db=db;
            _userManager = userManager;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SubCount = _db.Subscribers.Where(s => s.Checked == false).Count();
            ViewBag.MessageCount = _db.Messages.Where(m => m.Read == false).Count();
            User user = await _userManager.FindByNameAsync(User.Identity.Name);
            ViewBag.UserId = user.Id;
            NavbarVM model = new NavbarVM()
            {
                Messages = _db.Messages.OrderByDescending(m => m.Id).Take(3)
            };
            return View(await Task.FromResult(model));
        }
    }
}
