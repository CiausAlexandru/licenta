using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity.Models
{
    public class Bus
    {
        public long Id { get; set; }

        public string LicencePlate { get; set; }

        public long? RegionId { get; set; }

        public Region Region { get; set; }

        public IEnumerable<BusXRoute> BusXRoutes { get; set; }
    }
}
