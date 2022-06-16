using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
