using ASPNetProject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetProject.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Bio> Bios { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SliderText> SliderContents { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<About> About { get; set; }
    }
}
