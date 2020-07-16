using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewModels
{
    public class EventVM
    {
        public Background Background { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<EventSpeaker> EventSpeakers { get; set; }
        public IEnumerable<Speaker> Speakers { get; set; }
        public Event Event { get; set; }
        public IEnumerable<Course> Courses { get; set; }
        public IEnumerable<Blog> SideBlogs { get; set; }
        public Message Message { get; set; }
    }
}
