using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
    public class PolyclinicDepartment
    {
        public int PolyclinicDepartmentId { get; set; }
        [ForeignKey("Polyclinic")]
        public int PolyclinicId { get; set; }
        public Polyclinic Polyclinic { get; set; }
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
