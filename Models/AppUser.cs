using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identity.Models
{
    public class AppUser : IdentityUser
    {
        public long? RegionId { get; set; }

        public Region Region { get; set; }
    }
}
