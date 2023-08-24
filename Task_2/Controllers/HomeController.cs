using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Task_2.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LeftMenu()
        {
            return View();
        }

        public IActionResult SubMenu1()
        {
            return View();
        }

        public IActionResult SubMenu2()
        {
            return View();
        }

        public IActionResult SubMenu3()
        {
            return View();
        }

    }
}
