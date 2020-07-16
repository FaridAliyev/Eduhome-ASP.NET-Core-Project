using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Subscriber
    {
        public int Id { get; set; }
        [Required,StringLength(200),EmailAddress,DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public bool Checked { get; set; }
        public Subscriber()
        {
            Checked = false;
        }
    }
}
