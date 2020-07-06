using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class CourseDetail
    {
        public int Id { get; set; }
        [StringLength(700)]
        public string About { get; set; }
        [StringLength(700)]
        public string HowToApply { get; set; }
        [StringLength(700)]
        public string Certification { get; set; }
        public int CourseId { get; set; }
        public virtual Course Course { get; set; }
    }
}
