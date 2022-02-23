using CourseApp.Models;
using CourseApp.ViewModels;
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

            ViewBag.Greeting = saat > 12 ? "İyi Günler" : "Günaydın";
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
            //return RedirectToAction("List", "Course",new {id=5,sortBy="name" });
            //Eğer parametrede vermek istersek. id si 5 olan ve isme göre sıralı listelemek istersek
            /*https://localhost:44334/Course/List/5?sortBy=name şeklinde*/

            var categories = new List<Category>()   /*Burda oluşturduğumuz categories modelini view e göndermemiz gerekiyor. */
            {
                new Category(){Name="Kategori 1"},
                new Category(){Name="Kategori 2"},
                new Category(){Name="Kategori 3"}
            };

            var products = new List<Product>()
            {
                new Product(){ Name="Product 1"},
                new Product(){ Name="Product 2"},
                new Product(){ Name="Product 3"}
            };

            // ProductsCategoriesViewModel model = new ProductsCategoriesViewModel();
            var model = new ProductsCategoriesViewModel();  // Yukardaki satırı yalınlaştırdım

            model.Products = products;
            model.Categories = categories;

            return View(model);  // Index2 View ı artık ProductsCategoriesViewModel View ini beklemesi gerekiyor

            //return View(categories);  //önce sadece categorileri yollamıştım

        }

        //localhost:44383/home/about  => home/about.cshtml
        public IActionResult About()
        {
            var categories = new List<Category>()   /*Burda oluşturduğumuz categories modelini view e göndermemiz gerekiyor. */
            {
                new Category(){Name="Kategori 1"},
                new Category(){Name="Kategori 2"},
                new Category(){Name="Kategori 3"}
            };

            var products = new List<Product>()
            {
                new Product(){ Name="Product 1"},
                new Product(){ Name="Product 2"},
                new Product(){ Name="Product 3"}
            };

            // ProductsCategoriesViewModel model = new ProductsCategoriesViewModel();
            var model = new ProductsCategoriesViewModel();  // Yukardaki satırı yalınlaştırdım

            model.Products = products;
            model.Categories = categories;

            return View(model);  // Index2 View ı artık ProductsCategoriesViewModel View ini beklemesi gerekiyor

            //return View(categories);  //önce sadece categorileri yollamıştım
        }

        public IActionResult List()
        {
            return View();
        }
    }
}
