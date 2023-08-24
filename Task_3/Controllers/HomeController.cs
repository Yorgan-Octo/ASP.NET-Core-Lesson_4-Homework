using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Task_3.Controllers
{
    public class HomeController : Controller
    {
      
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult List1()
        {
            return View();
        }
        public IActionResult List2()
        {
            return View();
        }
    }
}
