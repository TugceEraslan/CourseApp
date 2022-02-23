using CourseApp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CourseApp.ViewComponents
{
    public class MenuViewComponent:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var categories = new List<Category>()   /*Burda oluşturduğumuz categories modelini view e göndermemiz gerekiyor. */
            {
                new Category(){Name="Kategori 7"},
                new Category(){Name="Kategori 8"},
                new Category(){Name="Kategori 9"}
            };

            return View(categories);  /* Ekrana yazdığı bu alanadan gelen bilgiler. Çünkü artık Controller a bağlı oluyorum. 
                                       * Http talebi içersinde bir işlem yapmam gerekmiyor. ViewComponent esnek bir yapısı olan ve MVC Core
                                       * ile gelen yeni bir kavram. */
        }
    }
}
