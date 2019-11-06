using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Infrastructure.Annotations;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities.FluentMapping
{
    public class MapUser:EntityTypeConfiguration<User>
    {
        public MapUser()
        {
            HasKey(x => x.UserId);
            Property(x => x.IdentityNo).IsRequired().HasMaxLength(11);
            Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            Property(x => x.LastName).IsRequired().HasMaxLength(50);
            Property(x => x.Email).IsRequired().HasMaxLength(50);
            Property(x => x.Password).IsRequired().HasMaxLength(16);            
            Property(x => x.Gender).IsRequired().HasMaxLength(5);
            Property(x => x.BirthDate).IsRequired();
            Property(x => x.PhoneNumber).IsOptional();
            Property(x => x.DepartmentId).IsOptional();




        }


    }
}
