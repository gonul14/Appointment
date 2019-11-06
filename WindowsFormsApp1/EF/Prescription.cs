using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
    public class Prescription
    {
        public int PrescriptionId { get; set; }
        public virtual Examination Examination { get; set; }
        public int ExaminationId { get; set; }
        public string Description { get; set; }
    }
}
