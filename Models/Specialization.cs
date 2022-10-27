using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement21A6.Models
{
    public class Specialization
    {
        [Key]
        [Display(Name = "Identyfikator")]
        [MaxLength(5, ErrorMessage = "Max 5 chars")]
        public string Id { get; set; }



        [Display(Name = "Opis")]
        [MaxLength(50, ErrorMessage = "Max 50 chars")]
        public string Description { get; set; }
    }
}
