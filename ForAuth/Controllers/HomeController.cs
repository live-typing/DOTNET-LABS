using ForAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ForAuth.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult Logout()
        {
            FormsAuthentication.SignOut();  
            return RedirectToAction("Index");   
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(User pUser)
        {
            //Get all users
             var userDb = ForAuth.Models.User.GetUsers();
            //search the user as per username & password
            User found = userDb.Where(u => u.Username == pUser.Username && u.Password == pUser.Password)
                .ToList()
                .FirstOrDefault();
            //Authenticate
            if (found != null)
            {
                FormsAuthentication.SetAuthCookie(found.Username, false);
                return RedirectToAction("Contact");
            }
            return View("Index");

        }
        [Authorize(Roles= "Admin, Customer")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }
        [Authorize()]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}