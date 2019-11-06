using Randevu.DAL.Manager;
using Randevu.Entities;
using System.Collections;
using System.Collections.Generic;

namespace Randevu.BLL
{
    public class UserController:BaseController<User>
    {
        UserManager userManager = new UserManager();
        public List<User> ListDoctor(int hospitalId, int departmentId)
        {
            return userManager.DoctorList(hospitalId, departmentId);
        }
    }
}
