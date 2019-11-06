using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities.FluentMapping
{
    public class MapDepartment:EntityTypeConfiguration<Department>
    {
        public MapDepartment()
        {
            HasKey(x => x.DepartmentId);
            Property(x => x.DepartmentName).IsRequired().HasMaxLength(100);
        }
    }
}
