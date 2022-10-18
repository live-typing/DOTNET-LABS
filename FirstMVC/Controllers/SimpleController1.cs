using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class SimpleController1 : Controller
    {
        [HttpGet("/simple")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/names")]
        public IActionResult Displaynames()
        {
            return View("Namesview");
        }
        [HttpGet("/Onlogin")]
        public IActionResult Onlogin(string username, string password)
        {

            {
                if (username == "admin" && password == "nimda")
                {
                    ViewBag.Status = "LOGIN SUCCESSFUL";
                    return View("Index");
                }
                else
                {
                    ViewBag.Status = "LOGIN FAILED";

                    return View("Index");
                }
            }
        }
    }
}

