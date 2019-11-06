using Randevu.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Randevu.DAL.Manager
{
    public class ExaminationManager:BaseManager<Examination>
    {
        AppointmentContext context = new AppointmentContext();
        public List<Diagnosis> ExaminationDiagnosis(int userId)
        {

            List<Diagnosis> diagnosis = (from d in context.Diagnosis
                            join h in context.Departments
                            on d.DepartmentId equals h.DepartmentId
                            join u in context.Users
                            on h.DepartmentId equals u.DepartmentId
                            where u.UserId == userId
                                    select d).ToList();
            return diagnosis;
        }
        public List<int> PatientExaminationId(int appointmentId)
        {
            List<int> patientID = (from a in context.Appointments
                             where a.AppointmentId == appointmentId
                                     select a.PatientId).ToList();
            return patientID;
        }

        

    }
}
