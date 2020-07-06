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
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<Hobbie> Hobbies { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Degree> Degrees { get; set; }
        public DbSet<TeacherInfo> TeacherInfos { get; set; }
        public DbSet<TeacherDegree> TeacherDegrees { get; set; }
        public DbSet<TeacherHobbie> TeacherHobbies { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<CourseDetail> CourseDetails { get; set; }
        public DbSet<CourseFeature> CourseFeatures { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Speaker> Speakers { get; set; }
        public DbSet<EventSpeaker> EventSpeakers { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Background> Backgrounds { get; set; }
    }
}
