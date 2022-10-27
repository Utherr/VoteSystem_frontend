using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagement21A6.Models
{
    public class WyborcaView
    {
        [Key]
        public int WyborcaId { get; set; }
        public Wyborca wyborcasVm { get; set; }
        public Wojewodztwo wojewodztwoVm { get; set; }
    }
}
