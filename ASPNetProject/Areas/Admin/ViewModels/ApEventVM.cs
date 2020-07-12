using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Areas.Admin.ViewModels
{
    public class ApEventVM
    {
        public Event Event { get; set; }
        public IEnumerable<EventSpeaker> EventSpeakers { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
    }
}
