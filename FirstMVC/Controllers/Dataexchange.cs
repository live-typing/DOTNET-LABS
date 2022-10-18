using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class Dataexchange : Controller
    {
        [HttpGet("/dataex") ] 
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Username", "ram@kpmg.com");         
            return View("Index");
        }
        public IActionResult NextPage()
        {
            ViewBag.User = HttpContext.Session.GetString("username");
            return View("Index");
            
        }
    }
}
