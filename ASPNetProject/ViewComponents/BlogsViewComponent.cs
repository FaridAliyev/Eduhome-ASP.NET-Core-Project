using ASPNetProject.DAL;
using ASPNetProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewComponents
{
    public class BlogsViewComponent:ViewComponent
    {
        private readonly AppDbContext _db;
        public BlogsViewComponent(AppDbContext db)
        {
            _db = db;
        }

        public async Task<IViewComponentResult> InvokeAsync(int count)
        {
            var model = _db.Blogs.Select(b => new Blog
            {
                Id=b.Id,
                Title=b.Title,
                Image=b.Image,
                PostedBy=b.PostedBy,
                Date=b.Date,
                Description=b.Description,
                Quote=b.Quote
            }).OrderByDescending(b=>b.Id).Take(count);

            return View(await Task.FromResult(model));
        }
    }
}
