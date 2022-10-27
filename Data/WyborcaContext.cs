using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentManagement21A6.Models;

namespace StudentManagement21A6.Data
{
    public class WyborcaContext : DbContext
    {
        public WyborcaContext(DbContextOptions<StudentContext> options)
          : base(options)
        {
        }
        public DbSet<StudentManagement21A6.Models.Wyborca> Wyborca { get; set; }
        public DbSet<StudentManagement21A6.Models.Wojewodztwo> Wojewodztwo { get; set; }

    }
}
