using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewModels
{
    public class AboutVM
    {
        public Background Background { get; set; }
        public About About { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public NoticeVideo Video { get; set; }
        public IEnumerable<NoticeBoard> NoticeBoards { get; set; }
    }
}
