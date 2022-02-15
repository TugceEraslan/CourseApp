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


        public IActionResult Index2()
        {

            //return Content("Hello World!!!");
            //return NotFound();
            //return new EmptyResult();  Bomboş bir sayfa gelir.
            //return RedirectToAction("List");
            //return RedirectToAction("List","Course"); //Farklı bir Controller içindeki List metoduna gitmesi için 
                                                      //List ten sonra gitmesi istenilen controller ın adı yazılmalı
            return RedirectToAction("List", "Course",new {id=5,sortBy="name" });
            //Eğer parametrede vermek istersek. id si 5 olan ve isme göre sıralı listelemek istersek
            /*https://localhost:44334/Course/List/5?sortBy=name şeklinde*/

        }

        //localhost:44383/home/about  => home/about.cshtml
        public IActionResult About()
        {
            return View();
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
