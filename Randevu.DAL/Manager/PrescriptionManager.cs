using Randevu.Entities;
using System.Collections;
using System.Linq;

namespace Randevu.DAL.Manager
{
    public class PrescriptionManager:BaseManager<Prescription>
    {
        AppointmentContext context = new AppointmentContext();
        public IEnumerable BeforePrescriptionManager(string identityNo)
        {
            IEnumerable prescriptionDescription = (from u in context.Users
                                           join a in context.Appointments
                                           on u.UserId equals a.PatientId
                                           join ex in context.Examinations
                                           on a.AppointmentId equals ex.AppointmentId
                                           join p in context.Prescriptions
                                           on ex.ExaminationId equals p.ExaminationId
                                           where u.IdentityNo == identityNo
                                           select new { Ad = u.FirstName, Soyad = u.LastName, Reçete = p.Description }).ToList();
            return prescriptionDescription;
        }
    }
}
