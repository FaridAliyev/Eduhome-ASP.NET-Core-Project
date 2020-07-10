using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

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
    }
}