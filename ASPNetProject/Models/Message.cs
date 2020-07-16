using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class Message
    {
        public int Id { get; set; }
        [Required,StringLength(200)]
        public string Name { get; set; }
        [Required, StringLength(200), EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [StringLength(200)]
        public string Subject { get; set; }
        [Required,StringLength(500)]
        public string  Note { get; set; }
        public bool Read { get; set; }
        public Message()
        {
            Read = false;
        }
    }
}
