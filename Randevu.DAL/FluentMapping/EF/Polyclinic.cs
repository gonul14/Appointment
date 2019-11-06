using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
    public class Polyclinic
    {
        public int PolyclinicId { get; set; }
        public string PolyclinicName { get; set; }
        public int HospitalId { get; set; }
        public Hospital Hospital { get; set; }
    }
}
