using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.Areas.Admin.ViewModels
{
    public class UserVM
    {
        public string Id { get; set; }
        [Required, StringLength(100)]
        public string Fullname { get; set; }
        [Required, StringLength(100)]
        public string Username { get; set; }
        [Required, EmailAddress, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required,DataType(DataType.Password)]
        public string  Password { get; set; }
        [Required, Compare(nameof(Password)), DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string Role { get; set; }
        public List<IdentityRole> Roles { get; set; }
    }
}
