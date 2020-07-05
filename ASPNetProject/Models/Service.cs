using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Service
    {
        public int Id { get; set; }
        [Required, StringLength(200)]
        public string Name { get; set; }
        [Required, StringLength(500)]
        public string Description { get; set; }
    }
}
