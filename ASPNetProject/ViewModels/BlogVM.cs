using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewModels
{
    public class BlogVM
    {
        public Background Background { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Blog> Blogs { get; set; }
        public IEnumerable<Blog> SideBlogs { get; set; }
        public Blog Blog { get; set; }
        public Message Message { get; set; }
    }
}
