using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity.Models
{
    public class Itinerary
    {
        public long Id { get; set; }

        public DateTime Start { get; set; }

        public long BusXRouteId { get; set; }

        public BusXRoute BusXRoute { get; set; }
    }
}
