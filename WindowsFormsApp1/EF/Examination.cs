using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
    public class Examination
    {
        public int ExaminationId { get; set; }
        public int AppointmentId { get; set; }
        public virtual Appointment Appointment { get; set; }
        public bool IsValid { get; set; }
        public int DiagnosisId { get; set; }
        public virtual Diagnosis Diagnosis { get; set; }
        public bool IsNeedTest { get; set; }


    }
}
