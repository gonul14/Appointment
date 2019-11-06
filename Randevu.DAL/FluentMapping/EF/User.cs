using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
    public class User
    {
        public enum UserType
        {
            Patient,
            Doctor,
            Pharmacist

        }
        public int UserId { get; set; }
        public string IdentityNo { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Email { get; set; }
        public string Password { get; set; }
        
        public DateTime? BirthDate { get; set; }
        
        public DateTime CreatedDate { get; set; }

        public DateTime? UpdatedDate { get; set; }
        public string Gender { get; set; }
        public string PhoneNumber { get; set; }
        public UserType UserRole { get; set; }
        public int DepartmentId { get; set; }

        public Department Department { get; set; }
        //[NotMapped]
        //public int Age
        //{
        //    get
        //    {
        //        TimeSpan span = DateTime.Now - BirthDate.Value;
        //        return Convert.ToInt32(span);
        //    }
        //}
        public bool IsValid { get; set; } 

    }
}
