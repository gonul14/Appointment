using Randevu.DAL.Manager;
using Randevu.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Randevu.BLL
{
    public class ExaminationController:BaseController<Examination>
    {
        ExaminationManager examinationManager = new ExaminationManager();

        public IEnumerable Examination(int userId)
        {
            return examinationManager.ExaminationDiagnosis(userId);
        }

        public List<int> ExaminationPatientId(int appointmentId)
        {
            return examinationManager.PatientExaminationId(appointmentId);
        }
    }
}
