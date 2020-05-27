using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity.Models
{
    public class Region
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public Guid AppUserId { get; set; }

        public AppUser AppUser { get; set; }

        public IEnumerable<Route> Routes { get; set; }

        public IEnumerable<Bus> Buses { get; set; }
    }
}
