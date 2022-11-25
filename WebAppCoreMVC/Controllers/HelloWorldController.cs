using Microsoft.AspNetCore.Mvc;

namespace WebAppCoreMVC.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string nome, int numTimes)
        {
            ViewBag.Nome = nome;
            ViewBag.NumTimes = numTimes;
            return View();
        }
    }
}
