using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Contexts
{
    public class AgricultureContext : DbContext
    {

        public AgricultureContext(DbContextOptions<AgricultureContext> options)
            : base(options)
        {
        }

        public DbSet<Address>? Addresses { get; set; }
        public DbSet<Contact>? Contacts { get; set; }

        public DbSet<Image>? Images { get; set; }

        public DbSet<Announcement>? Announcements { get; set; }

        public DbSet<Service>? Services { get; set; }

        public DbSet<Team>? Teams { get; set; }
    }
}
