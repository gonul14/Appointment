using Randevu.DAL.Manager;
using Randevu.Entities;
using System.Collections;

namespace Randevu.BLL
{
    public class PrescriptionController:BaseController<Prescription>
    {
        PrescriptionManager prescriptionManager = new PrescriptionManager();
        public IEnumerable BeforePrescription(string identityNo)
        {
            return prescriptionManager.BeforePrescriptionManager(identityNo);
        }
    }
}
