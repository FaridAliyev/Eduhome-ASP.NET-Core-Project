using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class TeacherFaculty
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int FacultyId { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Faculty Faculty { get; set; }
    }
}
