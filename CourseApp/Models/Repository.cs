using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public static class Repository  // Bu sınıftan bir tane olacak ve içerisinde nesne oluşturulmayacak. Database görevinde olacak
    {
        private static List<StudentResponse> _students = new List<StudentResponse>();  // List<Student>() dan örnek alacak


        // Repository.Students dediğimizde bize _student i geri döndürecek
        public static List<StudentResponse> Students
        {         
            get
            {
                return _students;
            }
        }

        // Repository.AddStudent(student)  student modeli de gönderirsek ekleme işlemi çalışır
        public static void AddStudent(StudentResponse student)  // Dışardan student paramametresi alacak ama void olacak ki değer dönmesin. 
        {           
            _students.Add(student);   // _students üzerine student ı eklemek
        }

    }
}
