using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Speaker
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Fullname { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }
        [Required, StringLength(200)]
        public string Duty { get; set; }
        [Required, StringLength(300)]
        public string Company { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }
        [NotMapped]
        [Required]
        public IFormFile Photo { get; set; }
    }
}
