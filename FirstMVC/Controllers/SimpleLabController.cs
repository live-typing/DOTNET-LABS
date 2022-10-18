using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class SimpleLabController : Controller
    {
        [HttpGet("/Lab")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("/Name")]
        public IActionResult GetName(string Name)
        {
            ViewBag.Name = "RAM";
            return View("Index");
        }
        [HttpGet("/place")]
        public IActionResult Getplace(string place)
        {
            ViewBag.place = "JANANI HEART";
            return View("Index");
        }
        [HttpGet("/Thing")]
        public IActionResult GetThing(string Thing)
        {
            ViewBag.Thing = "AUDI";
            return View("Index");
        }
        [HttpGet("/Animal")]
        public IActionResult GetAnimal(string Animal)
        {
            ViewBag.Animal = "PUG";
            return View("Index");
        }
    }
}
