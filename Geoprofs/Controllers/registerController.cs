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
        public async Task<IActionResult> Create([Bind("ID,UserName,Password")] Login Login)
        {
            
            if (ModelState.IsValid)
            {
                _context.Add(Login);

                await _context.SaveChangesAsync();
                return RedirectToAction("Index", "Login");
            }
            return View(Login);
        }
    }
}
