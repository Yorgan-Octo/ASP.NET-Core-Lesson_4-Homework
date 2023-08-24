using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Task_1.Models;

namespace Task_1.Controllers
{
    public class HomeController : Controller
    {
   
        public IActionResult Index()
        {

            DateTime dateTime = DateTime.Now;

            return View(dateTime);
        }

    }
}
