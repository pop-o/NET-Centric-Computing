using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StateManagement.Controllers
{
    public class AuthController : Controller
    {
        // GET: Auth
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Log()
        {
            Session.Remove("user");
            return View("Index");
        }
        [HttpPost]
        public ActionResult Index(string userTxt,string passTxt)
        {
            if(userTxt == "Poem" && passTxt == "12345")
            {
                Session["user"] = "Poem";
                TempData["user"] = "Poem";
                /*HttpCookie kt1 = new HttpCookie("user", "Poem");//non persistent cookie
                kt1.Expires = DateTime.Now.AddSeconds(30);//to make persistent cookie add expires 
                Response.Cookies.Add(kt1);

                Response.Cookies["last"].Value="Popo";*/
                return RedirectToAction("Index","Home");
            }
            else
            {
                return View();
            }
            
        }
    }
}