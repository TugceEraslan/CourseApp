using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class Course
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool isPublished { get; set; }
        public int Id { get; set; }
    }
}
