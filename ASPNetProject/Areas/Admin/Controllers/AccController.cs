using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetProject.Areas.Admin.ViewModels;
using ASPNetProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class AccController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        public AccController(UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }
        public async Task<IActionResult> Index()
        {
            List<User> users = _userManager.Users.Where(u=>u.Deleted==false).ToList();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (User user in users)
            {
                userVMs.Add(new UserVM
                {
                    Id=user.Id,
                    Fullname=user.Fullname,
                    Username=user.UserName,
                    Email=user.Email,
                    Role=(await _userManager.GetRolesAsync(user))[0]
                });
            }
            return View(userVMs);
        }

        public IActionResult Create()
        {
            UserVM model = new UserVM()
            {
                Roles = _roleManager.Roles.ToList()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(UserVM userVM)
        {
            if (!ModelState.IsValid)
            {
                return View(new UserVM
                {
                    Roles = _roleManager.Roles.ToList()
                });
            }
            string role = Request.Form["role"];
            User user = new User
            {
                Fullname = userVM.Fullname,
                UserName = userVM.Username,
                Email = userVM.Email
            };
            IdentityResult identityResult = await _userManager.CreateAsync(user, userVM.Password);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(new UserVM
                {
                    Roles = _roleManager.Roles.ToList()
                });
            }
            await _userManager.AddToRoleAsync(user, role);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            User user = await _userManager.FindByIdAsync(id);
            if (user==null||user.Deleted)
            {
                return NotFound();
            }
            ApUserVM model = new ApUserVM()
            {
                Fullname = user.Fullname,
                Username = user.UserName,
                Email = user.Email,
                Role = (await _userManager.GetRolesAsync(user))[0],
                Roles = _roleManager.Roles.ToList()
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id,ApUserVM apUserVM)
        {
            if (!ModelState.IsValid)
            {
                return View(new ApUserVM
                {
                    Roles = _roleManager.Roles.ToList()
                });
            }
            if (id == null)
            {
                return NotFound();
            }
            User user = await _userManager.FindByIdAsync(id);
            if (user == null)
            {
                return NotFound();
            }
            user.Fullname = apUserVM.Fullname;
            user.UserName = apUserVM.Username;
            user.Email = apUserVM.Email;
            string role = (await _userManager.GetRolesAsync(user))[0];
            string newRole = Request.Form["role"];
            IdentityResult identityResult = await _userManager.UpdateAsync(user);
            if (!identityResult.Succeeded)
            {
                foreach (var error in identityResult.Errors)
                {
                    ModelState.AddModelError(string.Empty, error.Description);
                }
                return View(new ApUserVM
                {
                    Fullname = user.Fullname,
                    Username = user.UserName,
                    Email = user.Email,
                    Role = (await _userManager.GetRolesAsync(user))[0],
                    Roles = _roleManager.Roles.ToList()
                });
            }
            if (role!=newRole)
            {
                await _userManager.RemoveFromRoleAsync(user, role);
                await _userManager.AddToRoleAsync(user, newRole);
            }
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            User user = await _userManager.FindByIdAsync(id);
            if (user == null||user.Deleted)
            {
                return NotFound();
            }
            if (user == await _userManager.GetUserAsync(User))
            {
                return NotFound();
            }
            ApUserVM model = new ApUserVM()
            {
                Fullname = user.Fullname,
                Username = user.UserName,
                Email = user.Email,
                Role = (await _userManager.GetRolesAsync(user))[0]
            };
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteUser(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            User user = await _userManager.FindByIdAsync(id);
            if (user == null || user.Deleted)
            {
                return NotFound();
            }
            user.Deleted = true;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> Blocked()
        {
            List<User> users = _userManager.Users.Where(u => u.Deleted == true).ToList();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (User user in users)
            {
                userVMs.Add(new UserVM
                {
                    Id = user.Id,
                    Fullname = user.Fullname,
                    Username = user.UserName,
                    Email = user.Email,
                    Role = (await _userManager.GetRolesAsync(user))[0]
                });
            }
            return View(userVMs);
        }

        public async Task<IActionResult> Activate(string id)
        {
            if (id == null)
            {
                return NotFound();
            }
            User user = await _userManager.FindByIdAsync(id);
            if (user == null || !user.Deleted)
            {
                return NotFound();
            }
            user.Deleted = false;
            await _userManager.UpdateAsync(user);
            return RedirectToAction("Blocked");
        }

        public async Task<IActionResult> AdminUsers()
        {
            List<User> users = _userManager.Users.Where(u => u.Deleted == false).ToList();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (User user in users)
            {
                if((await _userManager.GetRolesAsync(user))[0] == "Admin")
                {
                    userVMs.Add(new UserVM
                    {
                        Id = user.Id,
                        Fullname = user.Fullname,
                        Username = user.UserName,
                        Email = user.Email,
                        Role = (await _userManager.GetRolesAsync(user))[0]
                    });
                }
            }
            return View(userVMs);
        }

        public async Task<IActionResult> NormalUsers()
        {
            List<User> users = _userManager.Users.Where(u => u.Deleted == false).ToList();
            List<UserVM> userVMs = new List<UserVM>();
            foreach (User user in users)
            {
                if ((await _userManager.GetRolesAsync(user))[0] == "User")
                {
                    userVMs.Add(new UserVM
                    {
                        Id = user.Id,
                        Fullname = user.Fullname,
                        Username = user.UserName,
                        Email = user.Email,
                        Role = (await _userManager.GetRolesAsync(user))[0]
                    });
                }
            }
            return View(userVMs);
        }
    }
}