using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using TestAPI.Core.Entities;

namespace ConfigDemoAPI.Infrastructure.Context
{
    public class ClientPortalDbContext : DbContext
    {
        public virtual DbSet<Client> Clients { get; set; } = null!;

        public ClientPortalDbContext(DbContextOptions<ClientPortalDbContext> dbContextOptions) : base(dbContextOptions)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Entity<Client>().ToTable("Client");
        }

    }
}
