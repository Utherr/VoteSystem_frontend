using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement21A6.Models;

namespace StudentManagement21A6.Data
{
    public class StudentContext : DbContext
    {
        public StudentContext(DbContextOptions<StudentContext> options)
          : base(options)
        {
        }
        public DbSet<StudentManagement21A6.Models.Student> Student { get; set; }
        public DbSet<StudentManagement21A6.Models.Specialization> Specialization { get; set; }
        public DbSet<StudentManagement21A6.Models.Wyborca> Wyborca { get; set; }

    }
}
