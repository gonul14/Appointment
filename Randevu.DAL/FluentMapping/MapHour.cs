using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities.FluentMapping
{
    public class MapHour:EntityTypeConfiguration<Hour>
    {
        public MapHour()
        {
            HasKey(x => x.HourId);
            Property(x => x.HourInfo).IsRequired().HasMaxLength(5);
        }
    }
}
