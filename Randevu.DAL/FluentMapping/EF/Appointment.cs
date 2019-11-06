using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
    public class Appointment
    {
        public int AppoinmentId { get; set; }
        public User Patient { get; set; }
        public int PatientId { get; set; }
        public User Doctor { get; set; }
        public int DoctorId { get; set; }

        public Hour Hour { get; set; }
        public int HourId { get; set; }
        public DateTime AppoinmentDate { get; set; }
     



    }
}
