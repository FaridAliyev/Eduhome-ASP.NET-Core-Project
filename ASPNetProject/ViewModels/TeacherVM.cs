using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.ViewModels
{
    public class TeacherVM
    {
        public int Id { get; set; }
        public string Fullname { get; set; }
        public string Image { get; set; }
        public virtual TeacherInfo TeacherInfo { get; set; }
    }
}
