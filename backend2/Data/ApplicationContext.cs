using backend2.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend2.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var ids = new Guid[] { Guid.NewGuid(), Guid.NewGuid(), Guid.NewGuid() };

            modelBuilder.ApplyConfiguration(new OfficeContext(ids));
        }

        public DbSet<Office> Offices { get; set; }
    }
}
