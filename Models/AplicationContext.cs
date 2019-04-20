using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

using System.Linq;
using System.Threading.Tasks;

namespace Election10.Models
{
    public class AplicationContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Citizens> Citizenses { get; set; }
        public DbSet<CharmanDC> CharmanDCs { get; set; }
        public DbSet <ChairmanCC> ChairmanCCs { get; set; }
        public DbSet <Voice> Voices { get; set; }
        public DbSet <Election> Elections { get; set; }
        public DbSet <VirtualCanton> VirtualCantons { get; set; }
        public DbSet <VirtualDistrict> VirtualDistricts{ get; set; }
        public DbSet <Candidate> Candidates { get; set; }
        public DbSet <Appeal> Appeals { get; set; }
        public DbSet <Watcher> Watchers { get; set; }
        public DbSet <Complaints> Complaintses { get; set; }






        public AplicationContext(DbContextOptions<AplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
