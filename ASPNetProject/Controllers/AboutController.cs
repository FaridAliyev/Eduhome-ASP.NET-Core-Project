using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.DAL;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Controllers
{
    public class AboutController : Controller
    {
        private readonly AppDbContext _db;
        public AboutController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            AboutVM model = new AboutVM()
            {
                Background = _db.Backgrounds.FirstOrDefault(),
                About = _db.About.FirstOrDefault(),
                Testimonials = _db.Testimonials,
                Video = _db.NoticeVideos.FirstOrDefault(),
                NoticeBoards = _db.NoticeBoards
            };

            return View(model);
        }
    }
}