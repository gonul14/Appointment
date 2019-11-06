using Randevu.Entities;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Randevu.DAL.Manager
{
    public class UserManager:BaseManager<User>
    {
        AppointmentContext context = new AppointmentContext();
        public List<User> DoctorList(int hospitalId, int departmentId)
        {
            List<User> doctor = (from u in context.Users
                                 join hd in context.HospitalDepartments
                                 on u.DepartmentId equals hd.DepartmentId
                                 where u.HospitalId == hospitalId & u.DepartmentId == departmentId & u.UserRole == User.UserType.Doctor
                                 select u).ToList();

            return doctor;
            
        }
        
    }
}
