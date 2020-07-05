using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Fullname { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }
        public virtual TeacherInfo TeacherInfo { get; set; }
        public ICollection<TeacherSkill> TeacherSkills { get; set; }
        public ICollection<TeacherHobbie> TeacherHobbies { get; set; }
        public ICollection<TeacherFaculty> TeacherFaculties { get; set; }
        public ICollection<TeacherDegree> TeacherDegrees { get; set; }
    }
}
