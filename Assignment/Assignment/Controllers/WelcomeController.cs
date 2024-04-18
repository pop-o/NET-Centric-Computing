using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;

namespace Assignment.Controllers
{
    public class WelcomeController : Controller
    {
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Name", "John");
            return View();
        }
    }
}
