using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Testimonial
    {
        public int Id { get; set; }
        [Required,StringLength(300)]
        public string Image { get; set; }
        [Required, StringLength(500)]
        public string Review { get; set; }
        [Required, StringLength(200)]
        public string Fullname { get; set; }
        [StringLength(200)]
        public string Duty { get; set; }
        [StringLength(200)]
        public string Qualification { get; set; }
    }
}
