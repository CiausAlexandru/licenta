using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity.Models
{
    public class BusXRoute
    {
        public long Id { get; set; }

        public long BusId { get; set; }

        public Bus Bus { get; set; }

        public long RouteId { get; set; }

        public Route Route { get; set; }

        public IEnumerable<Itinerary> Itineraries { get; set; }
    }
}
