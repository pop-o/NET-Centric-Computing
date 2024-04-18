using AuthenticationAuthorization.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;//to add authorization
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using System.Security.Claims;

namespace AuthenticationAuthorization.Controllers
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
        [Authorize(Roles ="Student")]
        public IActionResult Dashboard()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Login(string ReturnUrl)
        {
            //take return url to view for this use viewbag
            ViewData["returnURL"]= ReturnUrl;
            return View();
        }
        [HttpPost]
        public IActionResult Login(string username,string password,string ReturnUrl) 
        {
            if (username == "ram" && password == "ram")
            {
                //add authorization
                //claim: authorization detail
                //identity: which mechanism to be used for authorization:cookie
                //principle: to whom to authorize
                List<Claim> claims = new List<Claim>();
                claims.Add(new Claim(ClaimTypes.NameIdentifier,username));
                claims.Add(new Claim(ClaimTypes.Name,username));
                claims.Add(new Claim(ClaimTypes.Role, "Student"));
                //identity 
                ClaimsIdentity identity = new ClaimsIdentity(claims,CookieAuthenticationDefaults.AuthenticationScheme);
                //principle
                ClaimsPrincipal principal = new ClaimsPrincipal(identity);
                //executing 
                HttpContext.SignInAsync(principal);//execute
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
