using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class TeacherSkill
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public int SkillId { get; set; }
        public int Value { get; set; }
        public virtual Teacher Teacher { get; set; }
        public virtual Skill Skill { get; set; }
    }
}
