using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public int SkillId { get; set; }
        public int FacultyId { get; set; }
        public virtual TeacherInfo TeacherInfo { get; set; }
        public virtual Skill Skill { get; set; }
        public virtual Faculty Faculty { get; set; }
        public ICollection<TeacherHobbie> TeacherHobbies { get; set; }
        public ICollection<TeacherDegree> TeacherDegrees { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
