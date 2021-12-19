using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//using System.Web.Mvc;


namespace CourseApp.Controllers
{

    //localhost:44383/course
    public class CourseController : Controller
    {
        //localhost:44383/course/index  => course/index.cshtml
        public IActionResult Index()
        {
            return View();
        }

        public ActionResult Action()
        {
            return View();
        }


        //localhost:44383/course/apply

        [HttpGet]
        public IActionResult Apply()
        {
            return View();
        }

        //localhost:44383/course/apply  method:POST
        // Name=value & Email=value & Phone=value & Confirm=value aşağıdaki parametreler bu aldıkları value lara karşılık gelmiş olacak
        [HttpPost]
        public IActionResult Apply(string Name,string Email,string Phone,bool Confirm)
        {

            // database kaydı
            return View();
        }
        public IActionResult Details()
        {

            // name: "Core Mvc Kursu"
            // description: "Güzel bir kurs"
            // isPublished: true

            var course = new Course();

            course.Name = "Core Mvc Kursu";
            course.Description = "Güzel bir kurs";
            course.isPublished = true;

            return View(course);
        }

        //localhost:44383/course/list => course/list.cshtml

        public IActionResult List()
        {
            return View();
        }

    }
}
