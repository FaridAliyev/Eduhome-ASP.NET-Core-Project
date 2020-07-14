using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
    public class TeacherController : Controller
    {
        private readonly IHostingEnvironment _env;
        private readonly AppDbContext _db;
        public TeacherController(AppDbContext db, IHostingEnvironment env)
        {
            _env = env;
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Teachers);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Teacher teacher = await _db.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            TeachersVM model = new TeachersVM()
            {
                Teacher = _db.Teachers.Include(t => t.TeacherInfo).Include(t => t.Skill).Include(t => t.Faculty).FirstOrDefault(t => t.Id == id),
                TeacherHobbies = _db.TeacherHobbies.Include(th => th.Hobbie),
                TeacherDegrees = _db.TeacherDegrees.Include(td => td.Degree)
            };
            return View(model);
        }

        public IActionResult Create()
        {
            TeachersVM model = new TeachersVM()
            {
                Hobbies = _db.Hobbies,
                Degrees = _db.Degrees,
                Faculties = _db.Faculties
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TeachersVM teacherVM)
        {
            if (!teacherVM.Teacher.Photo.isImage())
            {
                ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                return View(new TeachersVM
                {
                    Hobbies = _db.Hobbies,
                    Degrees = _db.Degrees,
                    Faculties = _db.Faculties
                });
            }
            string hobbies = Request.Form["hobbies[]"];
            string degrees = Request.Form["degrees[]"];
            string faculty = Request.Form["faculty"];
            if (hobbies == null)
            {
                ModelState.AddModelError(string.Empty, "Please pick at least one hobbie!!!");
                return View(new TeachersVM
                {
                    Hobbies = _db.Hobbies,
                    Degrees = _db.Degrees,
                    Faculties = _db.Faculties
                }); 
            }
            if (degrees == null)
            {
                ModelState.AddModelError(string.Empty, "Please pick at least one degree!!!");
                return View(new TeachersVM
                {
                    Hobbies = _db.Hobbies,
                    Degrees = _db.Degrees,
                    Faculties = _db.Faculties
                });
            }
            if (faculty == null)
            {
                ModelState.AddModelError(string.Empty, "Please pick a faculty!!!");
                return View(new TeachersVM
                {
                    Hobbies = _db.Hobbies,
                    Degrees = _db.Degrees,
                    Faculties = _db.Faculties
                });
            }
            string[] strhobbyIds = hobbies.Split(",");
            string[] strdegreeIds = degrees.Split(",");
            int facultyId = Int32.Parse(faculty);
            List<int> intHobbyIds = new List<int>();
            List<int> intDegreeIds = new List<int>();
            foreach (string id in strhobbyIds)
            {
                intHobbyIds.Add(Int32.Parse(id));
            }
            foreach (string id in strdegreeIds)
            {
                intDegreeIds.Add(Int32.Parse(id));
            }
            Teacher teacher = teacherVM.Teacher;
            teacher.Image = await teacherVM.Teacher.Photo.SaveImg(_env.WebRootPath, "img/teacher");
            teacher.TeacherInfo = teacherVM.TeacherInfo;
            teacher.Skill = teacherVM.Skill;
            List<TeacherHobbie> teacherHobbies = new List<TeacherHobbie>();
            List<TeacherDegree> teacherDegrees = new List<TeacherDegree>();
            foreach (int id in intHobbyIds)
            {
                teacherHobbies.Add(new TeacherHobbie
                {
                    TeacherId = teacher.Id,
                    HobbieId = id
                });
            }
            foreach (int id in intDegreeIds)
            {
                teacherDegrees.Add(new TeacherDegree
                {
                    TeacherId = teacher.Id,
                    DegreeId = id
                });
            }          
            teacher.TeacherHobbies = teacherHobbies;
            teacher.TeacherDegrees = teacherDegrees;
            teacher.Faculty = await _db.Faculties.FindAsync(facultyId);
            _db.Teachers.Add(teacher);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Teacher teacher = await _db.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            TeachersVM model = new TeachersVM()
            {
                Teacher = _db.Teachers.Include(t => t.TeacherInfo).Include(t => t.Skill).Include(t => t.Faculty).FirstOrDefault(t => t.Id == id),
                TeacherHobbies = _db.TeacherHobbies.Include(th => th.Hobbie),
                TeacherDegrees = _db.TeacherDegrees.Include(td => td.Degree),
                Hobbies = _db.Hobbies,
                Degrees = _db.Degrees,
                Faculties = _db.Faculties
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, TeachersVM teacherVM, IFormFile File)
        {
            if (id == null)
            {
                return NotFound();
            }
            Teacher teacher = await _db.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }    
            if (File != null)
            {
                if (!File.isImage())
                {
                    ModelState.AddModelError(string.Empty, "Please pick a file matching the format!");
                    return View(new TeachersVM
                    {
                        Teacher = _db.Teachers.Include(t => t.TeacherInfo).Include(t => t.Skill).Include(t => t.Faculty).FirstOrDefault(t => t.Id == id),
                        TeacherHobbies = _db.TeacherHobbies.Include(th => th.Hobbie),
                        TeacherDegrees = _db.TeacherDegrees.Include(td => td.Degree),
                        Hobbies = _db.Hobbies,
                        Degrees = _db.Degrees,
                        Faculties = _db.Faculties
                    });
                }
                Extensions.DeleteImg(_env.WebRootPath, "img/teacher", teacher.Image);
                teacher.Image = await File.SaveImg(_env.WebRootPath, "img/teacher");
            }
            List<TeacherHobbie> teacherHobbies = _db.TeacherHobbies.Where(th => th.TeacherId == teacher.Id).ToList();
            List<TeacherHobbie> currentTeacherHobbies = _db.TeacherHobbies.Where(th => th.TeacherId == teacher.Id).ToList();
            List<Hobbie> currentHobbies = new List<Hobbie>();
            List<TeacherHobbie> newTeacherHobbies = new List<TeacherHobbie>();
            List<TeacherDegree> teacherDegrees = _db.TeacherDegrees.Where(td => td.TeacherId == teacher.Id).ToList();
            List<TeacherDegree> currentTeacherDegrees = _db.TeacherDegrees.Where(td => td.TeacherId == teacher.Id).ToList();
            List<Degree> currentDegrees = new List<Degree>();
            List<TeacherDegree> newTeacherDegrees = new List<TeacherDegree>();
            foreach (TeacherHobbie th in currentTeacherHobbies)
            {
                currentHobbies.Add(_db.Hobbies.FirstOrDefault(h => h.Id == th.HobbieId));
            }
            foreach (TeacherDegree td in currentTeacherDegrees)
            {
                currentDegrees.Add(_db.Degrees.FirstOrDefault(d => d.Id == td.DegreeId));
            }
            string hobbies = Request.Form["hobbies[]"];
            string degrees = Request.Form["degrees[]"];
            string faculty = Request.Form["faculty"];
            if (hobbies!=null)
            {
                string[] strhobbyIds = hobbies.Split(",");
                List<int> intHobbyIds = new List<int>();
                foreach (string Id in strhobbyIds)
                {
                    intHobbyIds.Add(Int32.Parse(Id));
                }
                foreach (int Id in intHobbyIds)
                {
                    newTeacherHobbies.Add(new TeacherHobbie
                    {
                        TeacherId = teacher.Id,
                        HobbieId = Id
                    });
                }
                currentTeacherHobbies = newTeacherHobbies;
                foreach (TeacherHobbie th in teacherHobbies)
                {
                    _db.TeacherHobbies.Remove(th);
                }
                foreach (TeacherHobbie th in currentTeacherHobbies)
                {
                    _db.TeacherHobbies.Add(th);
                }
            }
            if (degrees!=null)
            {
                string[] strdegreeIds = degrees.Split(",");
                List<int> intDegreeIds = new List<int>();
                foreach (string Id in strdegreeIds)
                {
                    intDegreeIds.Add(Int32.Parse(Id));
                }
                foreach (int Id in intDegreeIds)
                {
                    newTeacherDegrees.Add(new TeacherDegree
                    {
                        TeacherId = teacher.Id,
                        DegreeId = Id
                    });
                }
                currentTeacherDegrees = newTeacherDegrees;
                foreach (TeacherDegree td in teacherDegrees)
                {
                    _db.TeacherDegrees.Remove(td);
                }
                foreach (TeacherDegree td in currentTeacherDegrees)
                {
                    _db.TeacherDegrees.Add(td);
                }
            }
            TeacherInfo info = _db.TeacherInfos.FirstOrDefault(ti => ti.TeacherId == teacher.Id);
            info.Qualification = teacherVM.Teacher.TeacherInfo.Qualification;
            info.About = teacherVM.Teacher.TeacherInfo.About;
            info.ExperienceYear = teacherVM.Teacher.TeacherInfo.ExperienceYear;
            info.Email = teacherVM.Teacher.TeacherInfo.Email;
            info.Phone = teacherVM.Teacher.TeacherInfo.Phone;
            info.Skype = teacherVM.Teacher.TeacherInfo.Skype;
            info.Facebook = teacherVM.Teacher.TeacherInfo.Facebook;
            info.Pinterest = teacherVM.Teacher.TeacherInfo.Pinterest;
            info.Vimeo = teacherVM.Teacher.TeacherInfo.Vimeo;
            info.Twitter = teacherVM.Teacher.TeacherInfo.Twitter;
            teacher.Skill = teacherVM.Teacher.Skill;
            teacher.Faculty = await _db.Faculties.FindAsync(Int32.Parse(faculty));
            teacher.Fullname = teacherVM.Teacher.Fullname;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Teacher teacher = await _db.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            TeachersVM model = new TeachersVM()
            {
                Teacher = _db.Teachers.Include(t => t.TeacherInfo).Include(t => t.Skill).Include(t => t.Faculty).FirstOrDefault(t => t.Id == id),
                TeacherHobbies = _db.TeacherHobbies.Include(th => th.Hobbie),
                TeacherDegrees = _db.TeacherDegrees.Include(td => td.Degree)
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteTeacher(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Teacher teacher = await _db.Teachers.FindAsync(id);
            if (teacher == null)
            {
                return NotFound();
            }
            Extensions.DeleteImg(_env.WebRootPath, "img/teacher", teacher.Image);
            _db.Teachers.Remove(teacher);
            Skill skill = _db.Skills.FirstOrDefault(s => s.Id == teacher.SkillId);
            _db.Skills.Remove(skill);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}