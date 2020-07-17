using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class NoticeBoard
    {
        public int Id { get; set; }
        [Required,StringLength(100)]
        public string Date { get; set; }
        [StringLength(400)]
        public string Description { get; set; }
        [StringLength(200)]
        public string PostedBy { get; set; }
    }
}
