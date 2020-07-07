using ASPNetProject.DAL;
using ASPNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewComponents
{
    public class CoursesViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public CoursesViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var model = _db.Courses.Select(c => new Course
            {
                Id=c.Id,
                Name=c.Name,
                Image=c.Image,
                Description=c.Description
            }).Take(count);

            return View(await Task.FromResult(model));
        }
    }
}
