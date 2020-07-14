using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class TeacherInfo
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Qualification { get; set; }
        [Required, StringLength(800)]
        public string About { get; set; }
        public int ExperienceYear { get; set; }
        [Required, StringLength(200), EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, StringLength(200)]
        public string Phone { get; set; }
        [StringLength(200)]
        public string Skype { get; set; }
        [StringLength(200)]
        public string Facebook { get; set; }
        [StringLength(200)]
        public string Pinterest { get; set; }
        [StringLength(200)]
        public string Vimeo { get; set; }
        [StringLength(200)]
        public string Twitter { get; set; }
        public int TeacherId { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
