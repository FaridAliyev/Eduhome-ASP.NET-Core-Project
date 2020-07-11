using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Areas.Admin.ViewModels
{
    public class CourseVM
    {
        public Course Course { get; set; }
        public virtual CourseDetail CourseDetail { get; set; }
        public virtual CourseFeature CourseFeature { get; set; }
    }
}
