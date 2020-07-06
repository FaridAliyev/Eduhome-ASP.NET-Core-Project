using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Event
    {
        public int Id { get; set; }
        [Required, StringLength(400)]
        public string Name { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }
        [Required, StringLength(700)]
        public string Description { get; set; }
        [Required, StringLength(200)]
        public string Date { get; set; }
        [Required, StringLength(200)]
        public string Time { get; set; }
        [StringLength(300)]
        public string Venue { get; set; }
        public ICollection<EventSpeaker> EventSpeakers { get; set; }
    }
}
