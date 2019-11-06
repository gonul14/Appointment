using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities.FluentMapping
{
    public class MapPolyclinic:EntityTypeConfiguration<Polyclinic>
    {
        public MapPolyclinic()
        {
            HasKey(x => x.PolyclinicId);
            Property(x => x.PolyclinicName).IsRequired().HasMaxLength(100);
            Property(x => x.HospitalId).IsRequired();
        }
    }
}
