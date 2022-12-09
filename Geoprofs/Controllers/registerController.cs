using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Geoprofs.Data;
using Geoprofs.Models;

namespace Geoprofs.Controllers
{
    public class registerController : Controller
    {
        private readonly SchoolContext _context;

        public registerController(SchoolContext context)
        {
            _context = context;
        }



        public IActionResult Index()
        {
            return View();
        }
        /*        public IActionResult Create()
                {
                    return View();
                }*/



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(string Username, string Password, string Password2)
        {
            if (Password == Password2)
            {
                int Role = 0;
                Login Login = new Login(Username, Password);
                Console.WriteLine(Login);
                _context.Add(Login);
                await _context.SaveChangesAsync();
                /*                if (ModelState.IsValid)
                                {
                                    

                                    await _context.SaveChangesAsync();
                                    return RedirectToAction("Index", "Login");
                                }*/
                return RedirectToAction("Index", "Absences");
                /*return RedirectToAction("Index");*/
            }
            else
            {
                return RedirectToAction("Index");
            }

            
        }
    }
}
