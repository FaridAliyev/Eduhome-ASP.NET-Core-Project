using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class About
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; }
        [Required, StringLength(700)]
        public string Description { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }
    }
}
