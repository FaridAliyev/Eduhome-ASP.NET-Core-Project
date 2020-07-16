using ASPNetProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Areas.Admin.ViewModels
{
    public class NavbarVM
    {
        public IEnumerable<Message> Messages { get; set; }
    }
}
