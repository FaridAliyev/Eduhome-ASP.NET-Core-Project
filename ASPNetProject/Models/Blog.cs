using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        [Required, StringLength(400)]
        public string Title { get; set; }
        [Required, StringLength(300)]
        public string Image { get; set; }
        [Required, StringLength(100)]
        public string PostedBy { get; set; }
        [StringLength(100)]
        public string Date { get; set; }
        [Required, StringLength(700)]
        public string Description { get; set; }
        [StringLength(500)]
        public string Quote { get; set; }
    }
}
