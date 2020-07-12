using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.Areas.Admin.ViewModels;
using ASPNetProject.DAL;
using ASPNetProject.Helpers;
using ASPNetProject.Models;
using ASPNetProject.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ASPNetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class CourseController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly AppDbContext _db;
        public CourseController(AppDbContext db, IHostingEnvironment env)
        {
            _env = env;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Courses);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null) 
            {
                return NotFound();
            } 
            Course course = await _db.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            CoursesVM model = new CoursesVM()
            {
                Course = _db.Courses.Include(c => c.CourseDetail).Include(c => c.CourseFeature).FirstOrDefault(c => c.Id == id)
            };
            return View(model);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseVM courseVM)
        {
            if (!courseVM.Course.Photo.isImage())
            {
                ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                return View(courseVM);
            }
            Course course = courseVM.Course;
            course.CourseFeature = courseVM.CourseFeature;
            course.CourseDetail = courseVM.CourseDetail;
            course.Image = await courseVM.Course.Photo.SaveImg(_env.WebRootPath, "img/course");
            _db.Courses.Add(course);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course course = await _db.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            CourseVM model = new CourseVM()
            {
                Course = course,
                CourseDetail=_db.CourseDetails.FirstOrDefault(cd=>cd.CourseId==course.Id),
                CourseFeature=_db.CourseFeatures.FirstOrDefault(cf=>cf.CourseId==course.Id)
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id,CourseVM courseVM,IFormFile File)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course course = await _db.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            if (File!=null)
            {
                if (!File.isImage())
                {
                    ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                    return View(courseVM);
                }
                Extensions.DeleteImg(_env.WebRootPath, "img/course", course.Image);
                course.Image = await File.SaveImg(_env.WebRootPath, "img/course");
            }
            CourseDetail detail = _db.CourseDetails.FirstOrDefault(cd => cd.CourseId == course.Id);
            CourseFeature feature = _db.CourseFeatures.FirstOrDefault(cf => cf.CourseId == course.Id);
            detail.About = courseVM.CourseDetail.About;
            detail.HowToApply = courseVM.CourseDetail.HowToApply;
            detail.Certification = courseVM.CourseDetail.Certification;
            feature.StartDate = courseVM.CourseFeature.StartDate;
            feature.Duration = courseVM.CourseFeature.Duration;
            feature.ClassDuration = courseVM.CourseFeature.ClassDuration;
            feature.SkillLevel = courseVM.CourseFeature.SkillLevel;
            feature.Language = courseVM.CourseFeature.Language;
            feature.StudentCount = courseVM.CourseFeature.StudentCount;
            feature.Assesments = courseVM.CourseFeature.Assesments;
            feature.Fee = courseVM.CourseFeature.Fee;
            course.Name = courseVM.Course.Name;
            course.Description = courseVM.Course.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course course = await _db.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            CourseVM model = new CourseVM()
            {
                Course = _db.Courses.Include(c => c.CourseDetail).Include(c => c.CourseFeature).FirstOrDefault(c => c.Id == id)
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteCourse(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Course course = await _db.Courses.FindAsync(id);
            if (course == null)
            {
                return NotFound();
            }
            Extensions.DeleteImg(_env.WebRootPath, "img/course", course.Image);
            _db.Courses.Remove(course);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}