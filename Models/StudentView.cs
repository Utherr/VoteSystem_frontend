using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement21A6.Models
{
    public class StudentView
    {
        [Key]
        public int Id { get; set; }
        public Student studentsVm { get; set; }
        public Specialization specializationVm { get; set; }
    }
}
