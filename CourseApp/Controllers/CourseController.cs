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

        public ActionResult ByReleased(int year,int month)
        {
            return Content("year: " + year +" "+ "month: " +month);
        }


        //localhost:44383/course/index  => course/index.cshtml
        public IActionResult Index()
        {
            var kurs = new Course() {Id=1,Name="Komple Uygulamalı Web Geliştirme"};

            ViewData["course"] = kurs;
            ViewBag.course = kurs;
            ViewBag.count = 10;  // ViewBag in içerisine bir değişken daha oluşturalım

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
        // public IActionResult Apply(string Name,string Email,string Phone,bool Confirm)
        [HttpPost]
        public IActionResult Apply(Student student)  // Apply metodu içinde bilgiyi paketleyeceğimiz bir model yapısı var.
                                                     // Student tipinde bir bilgiyi form üzerinden direkt alabiliriz
        {

            if (ModelState.IsValid)  // ModelState bizim için gelen modeldeki yani student teki değere yani
                                     // ordaki kuralların geçip geçmemesine bakar
                                    // true ise ilk blok false ise else bloğu çalışır
            {
                // Model binding (request in body sinde geliyor bize bir model olarak(Name=value & Email=value & Phone=value & Confirm=value))
                // database kaydı
                Repository.AddStudent(student);
                return View("Thanks", student);   // Kayıt işlemi yapıldıktan sonra Thanks view ına yönlendirebiliriz.
                                                  // Gönderirkende student modelini Thanks view ı üzerine taşıyalım.
                                                  // Yani kullanıcının girdiği bilgilerden Thanks view ıda haberdar olsun
            }

            else   // eğer validationdan geçemediği bir durum varsa kuulanıcıya sayfayı tekrar yönlendiririz
            {
                return View(student);  // student ıda view e taşıyalım ki
                                       // kullanıcı yapmış olduğu hatayı view da görebilsin
            }

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
            var students = Repository.Students.Where(i => i.Confirm == true); // Student modeli içindeki Confirm alanı true olanları getirir 
            return View(students);
        }


        //Course/Details/2 : route
        //Course/Details?id=2 : Query string 
        //Query string in avantajı route şeması dışında istediğimiz kadare parametre oluşturup bunları gönderebiliriz
        /*https://localhost:44334/course/details2?id=5&sortby=name  yukardaki duruma örnek*/ 
        public ActionResult Details2(int id, string sortby)
        {
            return Content("id: "+ id +" "+"sortby: "+sortby);
        }

        public ActionResult CourseList(int? pageindex,string sortby)
        {
            if (!pageindex.HasValue)  // pageindex içinde herhangi bir değer yoksa 1 değerini ata
                pageindex = 1;

            if (string.IsNullOrWhiteSpace(sortby))
                sortby = "name";  // varsayılanın sortby içine  name i ata . https://localhost:44334/course/courselist

            /*Eğer kendimiz bir değer göndermek istersek  https://localhost:44334/course/courselist?pageindex=5 */

            /*Eğer sortby içinde yapavcak olursak  https://localhost:44334/course/courselist?pageindex=5&sortby=surname */
            return Content("pageindex: " + pageindex + " " + "sortby: " + sortby);
        }

    }
}
