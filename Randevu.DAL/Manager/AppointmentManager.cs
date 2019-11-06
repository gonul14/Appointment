using Randevu.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Randevu.DAL.Manager
{
    public class AppointmentManager:BaseManager<Appointment>
    {
        AppointmentContext context = new AppointmentContext();
       public IEnumerable AppointmentList(int id)
       {
            IEnumerable appointmentList = (from u in context.Users
                                   join a in context.Appointments
                                   on u.UserId equals a.Patient.UserId
                                   join d in context.Users
                                   on a.DoctorId equals d.UserId
                                   join h in context.Hours
                                   on a.HourId equals h.HourId
                                   where a.Patient.UserId == id
                                   select new { RandevuNo = a.AppointmentId, DoktorAdi = d.FirstName, DoktorSoyadi = d.LastName, Saat = h.HourInfo, HastaAdi = u.FirstName, HastaSoyadi = u.LastName }).ToList();            
            return appointmentList;
       }

        public List<Department> Department(int hospitalId)
        {
            var departments = (from hd in context.HospitalDepartments
                              join h in context.Departments
                              on hd.DepartmentId equals h.DepartmentId
                              where hd.HospitalId == hospitalId
                              select h).ToList();
            return departments;
        }
        public List<Hour> Hours(List<Hour> hours,int doctorId, DateTime selectedDate,DateTime selectedDate2)
        {
            List<int> h = hours.Select(x => x.HourId).ToList();
            List<int> a = context.Appointments.Where(x => x.DoctorId == doctorId && x.AppointmentDate >= selectedDate && x.AppointmentDate < selectedDate2).Select(x => x.HourId).ToList();

            var emptyHours = h.Except(a);
            var listHour = context.Hours.Where(i => emptyHours.Contains(i.HourId)).ToList();

            return listHour;
        }
    }
}
