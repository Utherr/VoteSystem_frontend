using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement21A6.Models
{
    public class Student
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Proszę podac nazwisko")]
        [Display(Name = "Nazwisko")]
        [MaxLength(50, ErrorMessage = "Max 50 char")]

        public string Name { get; set; }


        [Display(Name = "Imie")]
        [Required]
        [MaxLength(50, ErrorMessage = "Max 50 char")]
        public string FirstName { get; set; }


        [Display(Name = "Student email")]
        [Required]
        [MaxLength(50, ErrorMessage = "Max 50 char")]

        [RegularExpression(@"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$",
        ErrorMessage = "Invalid email format")]
        public string Email { get; set; }

        [MaxLength(5, ErrorMessage = "Max 5 char")]
        [Display(Name = "Specializacja")]

        public string Spec { get; set; }
    }
}
