using ASPNetProject.Areas.Admin.ViewModels;
using ASPNetProject.DAL;
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
        public NavbarViewComponent(AppDbContext db)
        {
            _db=db;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            ViewBag.SubCount = _db.Subscribers.Where(s => s.Checked == false).Count();
            ViewBag.MessageCount = _db.Messages.Where(m => m.Read == false).Count();
            NavbarVM model = new NavbarVM()
            {
                Messages = _db.Messages.OrderByDescending(m => m.Id).Take(3)
            };
            return View(await Task.FromResult(model));
        }
    }
}
