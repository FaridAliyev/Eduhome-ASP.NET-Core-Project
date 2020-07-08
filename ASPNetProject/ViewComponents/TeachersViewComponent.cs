using ASPNetProject.DAL;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewComponents
{
    public class TeachersViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public TeachersViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var model = _db.Teachers.Select(t => new TeacherVM
            {
                Id=t.Id,
                Fullname=t.Fullname,
                Image=t.Image,
                TeacherInfo=t.TeacherInfo
            }).Take(count);

            return View(await Task.FromResult(model));
        }
    }
}
