using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewModels
{
    public class HomeVM
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderText Content { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public About About { get; set; }
        public NoticeVideo Video { get; set; }
        public IEnumerable<NoticeBoard> NoticeBoards { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
    }
}
