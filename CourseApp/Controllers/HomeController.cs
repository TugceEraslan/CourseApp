using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Controllers
{
    public class HomeController : Controller
    {
        //localhost:44383/home/index  => home/index.cshtml

        public IActionResult Index()
        {
            int saat = DateTime.Now.Hour;

            ViewBag.Greeting= saat>12 ? "İyi Günler" : "Günaydın";
            ViewBag.UserName = "Tuğçe";


            return View();
        }


        //localhost:44383/home/about  => home/about.cshtml
        public IActionResult About()
        {
            return View();
        }
    }
}
