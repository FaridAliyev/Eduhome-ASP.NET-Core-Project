using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewModels
{
    public class TeachersVM
    {
        public Background Background { get; set; }
        public Teacher Teacher { get; set; }
        public IEnumerable<TeacherHobbie> TeacherHobbies { get; set; }
        public IEnumerable<TeacherDegree> TeacherDegrees { get; set; }
    }
}
