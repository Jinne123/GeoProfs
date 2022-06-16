using Microsoft.AspNetCore.Mvc;

namespace ContosoUniversity.Controllers
{
    public class registerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
