using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity.Models
{
    public class RouteXStation
    {
        public long Id { get; set; }

        public long RouteId { get; set; }

        public Route Route { get; set; }

        public long StationId { get; set; }

        public Station Station { get; set; }
    }
}
