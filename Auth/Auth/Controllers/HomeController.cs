using Auth.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Globalization;
using System.Security.Claims;

namespace Auth.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [Authorize]

        public IActionResult Privacy()
        {
            return View();
        }
        [Authorize(Roles="Student")]
        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {
            ViewData["returnUrl"] = ReturnUrl;
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username,string password,string ReturnUrl)
        {
            if(username=="ram" && password == "123")
            {
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier, username));
                claims.Add(new Claim(ClaimTypes.Name, username));
                claims.Add(new Claim(ClaimTypes.Role, "Student"));
                //identiy
                ClaimsIdentity identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                //principle
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);

                HttpContext.SignInAsync(principal);
                return Redirect(ReturnUrl);


            }
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
