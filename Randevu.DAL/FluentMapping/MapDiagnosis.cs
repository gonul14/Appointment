using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities.FluentMapping
{
    public class MapDiagnosis:EntityTypeConfiguration<Diagnosis>
    {
        public MapDiagnosis()
        {
            HasKey(x => x.DiagnosisId);
            Property(x => x.DiagnosisName).IsRequired().HasMaxLength(100);
            Property(x => x.DepartmentId).IsRequired();
        }
    }
}
