using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Models
{
    public class User:IdentityUser
    {
        [Required, StringLength(200)]
        public string Fullname { get; set; }
        public bool Deleted { get; set; }
        public User()
        {
            Deleted = false;
        }
    }
}
