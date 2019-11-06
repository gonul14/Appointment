using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
    public class Diagnosis
    {
        public int DiagnosisId { get; set; }
        public string DiagnosisName { get; set; }
        public int DepartmentId { get; set; }
        public Department Department { get; set; }
    }
}
