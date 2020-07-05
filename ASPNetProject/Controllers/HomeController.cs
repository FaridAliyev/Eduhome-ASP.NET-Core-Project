using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM model = new HomeVM()
            {
                Sliders = _db.Sliders,
                Content = _db.SliderContents.FirstOrDefault(),
                Services=_db.Services,
                About=_db.About.FirstOrDefault()
            };
            return View(model);
        }
    }
}