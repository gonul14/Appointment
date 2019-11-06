using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities.FluentMapping
{
    public class MapHospital: EntityTypeConfiguration<Hospital>
    {
        public MapHospital()
        {
            HasKey(x => x.HospitalId);
            Property(x => x.HospitalName).IsRequired().HasMaxLength(250);
        }
    }
}
