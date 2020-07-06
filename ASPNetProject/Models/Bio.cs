using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Bio
    {
        public int Id { get; set; }
        [StringLength(50)]
        public string Phone { get; set; }
        [Required, StringLength(100)]
        public string Logo { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(100)]
        public string Facebook { get; set; }
        [StringLength(100)]
        public string Pinterest { get; set; }
        [StringLength(100)]
        public string Vimeo { get; set; }
        [StringLength(100)]
        public string Twitter { get; set; }
        [StringLength(100)]
        public string Address { get; set; }
        [StringLength(100)]
        public string ContactMail { get; set; }
        [StringLength(100)]
        public string Website { get; set; }
    }
}
