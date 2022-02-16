using CourseApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.ViewModels
{
    public class CourseStudentsViewModel
    {

        /* Ayrı ayrı yapımızı taşıyacak olan view modelimiz. Biri kurs tipinde bir obje diğeri öğrenviler listesi*/
        public Course Course { get; set; }
        public List<Student> Students { get; set; }
    }
}
