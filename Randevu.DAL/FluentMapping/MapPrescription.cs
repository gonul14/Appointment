using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities.FluentMapping
{
    public class MapPrescription:EntityTypeConfiguration<Prescription>
    {
        public MapPrescription()
        {
            HasKey(x => x.PrescriptionId);
            Property(x => x.ExaminationId).IsRequired();
            Property(x => x.Description).IsRequired().HasMaxLength(500); 
        }
    }
}
