using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseApp.Models
{
    public class StudentResponse
    {
        [Required(ErrorMessage ="İsminizi giriniz!")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Email adresinizi giriniz!")]
        [EmailAddress(ErrorMessage ="E-mailiniz için geçerli bir adres giriniz!")]
        public string  Email { get; set; }
        [Required(ErrorMessage ="Telefon numaranızı giriniz!")]
        public string Phone { get; set; }
        [Required(ErrorMessage ="Katılma durumunuz nedir?")]
        public bool? Confirm { get; set; }  // true,false,null
    }
}
