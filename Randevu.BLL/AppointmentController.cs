using Randevu.DAL.Manager;
using Randevu.Entities;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Randevu.BLL
{
    public class AppointmentController:BaseController<Appointment>
    {
        AppointmentManager manager = new AppointmentManager();
        public IEnumerable ListAppointment(int id)
        {            
            return manager.AppointmentList(id);
        }
        public List<Department> ListDepartment(int hospitalId)
        {
            return manager.Department(hospitalId);
        }
        public List<Hour> Hours(List<Hour> hours, int doctorId, DateTime selectedDate, DateTime selectedDate2)
        {
            return manager.Hours(hours, doctorId, selectedDate, selectedDate2);
        }

    }
}
