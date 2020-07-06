using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Course
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string Name { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }
        [Required, StringLength(700)]
        public string Description { get; set; }
        public virtual CourseDetail CourseDetail { get; set; }
        public virtual CourseFeature CourseFeature { get; set; }
    }
}
