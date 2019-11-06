using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Randevu.Entities
{
    public class Hospital
    {
        public int HospitalId { get; set; }
        public string HospitalName { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public int DistrictId { get; set; }
        public District District { get; set; }

    }
}
