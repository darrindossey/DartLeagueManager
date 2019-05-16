using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DartLeagueManager.Data;
using DartLeagueManager.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using DartLeagueManager.Controllers.Filters;

namespace DartLeagueManager.Controllers
{
    public class AdminController : Controller
    {
        private readonly ApplicationDbContext _context;

        [ClaimRequirement(ClaimTypes.Permission, "Admin")]
        public IActionResult Index(string option)
        {
            if (option != null)
            {
                if (option == "reset-admin")
                {
                    return RedirectToAction("ResetAdmin");
                }
            }

            User user = HttpContext.Session.Get<User>(Resources.SessionUser);
            List<Role> roles = HttpContext.Session.Get<List<Role>>(Resources.SessionRoles);
            Role adminRole = null;
            if (roles != null)
            {
                adminRole = roles.FirstOrDefault(r => r.Name == "admin");
            }
            


            if (user == null || adminRole == null)
            {
                return RedirectToAction("Error", "Home", new { exception = new Exception("Not Authorized!") });
            }



            return View();
        }

        public IActionResult ResetAdmin()
        {
            return View();
        }

    }
}