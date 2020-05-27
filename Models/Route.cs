using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity.Models
{
    public class Route
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public Region Region { get; set; }

        public IEnumerable<RouteXStation> RouteXStations { get; set; }

        public IEnumerable<BusXRoute> BusXRoutes { get; set; }
    }
}
