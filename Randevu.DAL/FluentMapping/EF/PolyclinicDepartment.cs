using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
   public class PolyclinicDepartment
    {
       
        public int PolyclinicId { get; set; }
        public Polyclinic Polyclinic { get; set; }

        public int DepartmentId { get; set; }
        public Department Department { get; set; }

    }
}
