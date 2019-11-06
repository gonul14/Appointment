using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities.FluentMapping
{
    public class MapAppointment : EntityTypeConfiguration<Appointment>
    {
        public MapAppointment()
        {
            HasKey(x => x.AppointmentId);
            Property(x => x.HourId).IsRequired();
            Property(x => x.AppointmentDate).IsRequired();
            HasRequired(x => x.Patient).WithMany().HasForeignKey(x => x.PatientId);
            HasOptional(x => x.Doctor).WithMany().HasForeignKey(x => x.DoctorId);
        }
    }
}
