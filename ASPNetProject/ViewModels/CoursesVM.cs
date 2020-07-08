using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewModels
{
    public class CoursesVM
    {
        public Background Background { get; set; }
        public Course Course { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
