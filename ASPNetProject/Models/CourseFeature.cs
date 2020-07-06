using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class CourseFeature
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        [StringLength(200)]
        public string Duration { get; set; }
        public int ClassDuration { get; set; }
        [StringLength(200)]
        public string SkillLevel { get; set; }
        [StringLength(200)]
        public string Language { get; set; }
        public int StudentCount { get; set; }
        [StringLength(200)]
        public string Assesments { get; set; }
        public int Fee { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
