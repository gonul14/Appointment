using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
    public class Appointment
    {
        public int AppointmentId { get; set; }
        public int PatientId { get; set; }
        public virtual User Patient { get; set; }
        public int? DoctorId { get; set; }
        public virtual User Doctor { get; set; }        

        public virtual Hour Hour { get; set; }
        public int HourId { get; set; }
        public DateTime AppointmentDate { get; set; } 
    }
}
