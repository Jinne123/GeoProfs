using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Extensions;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System.Web;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Data;
using ContosoUniversity.Models;


namespace ContosoUniversity.Controllers
{
    public class LoginController : Controller
    {
        private readonly SchoolContext _context;
        public LoginController(SchoolContext context)
        {
            _context = context;
        }
        // GET: UserController
        public ActionResult Index()
        {
            return View();
        }

        // GET: UserController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UserController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UserController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }


        public async Task<IActionResult> Login(string UserName, string password)

        {
            var login = await _context.Logins.FirstOrDefaultAsync(m => m.UserName == UserName && m.Password == password);
            return View(login);
        }

        [HttpPost]
        public ActionResult Autherize(ContosoUniversity.Models.Login loginmodel){
           
            if (loginmodel.UserName == "admin" && loginmodel.Password == "admin")
            {
               /* HttpContext.Session.SetString("UserName", loginmodel.UserName);*/
                TempData["admin"] = true;
                TempData["User_id"] = 0;
                return RedirectToAction("Index", "Absences");
                
            }
            else if(loginmodel.UserName == "user" && loginmodel.Password == "user")
            {
                TempData["admin"] = false;
                TempData["User_id"] = 1;
                return RedirectToAction("Index", "Absences");
            }
            else
            {
                /*HttpContext.Session.Set("UserName", loginmodel.UserName);*/

                return RedirectToAction("Index", "login");
            }



        }

        // GET: UserController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UserController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: UserController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UserController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
