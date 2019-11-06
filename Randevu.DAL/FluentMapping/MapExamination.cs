using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities.FluentMapping
{
    public class MapExamination:EntityTypeConfiguration<Examination>
    {
        public MapExamination()
        {
            HasKey(x => x.ExaminationId);
            Property(x => x.DiagnosisId).IsRequired();
            Property(x => x.AppointmentId).IsRequired();

        }
    }
}
