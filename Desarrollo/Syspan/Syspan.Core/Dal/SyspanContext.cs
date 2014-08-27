using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Syspan.Core.Models;

namespace Syspan.Core.Dal
{
    public class SyspanContext : DbContext
    {
        public SyspanContext()
            : base("connectionString")
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Giro> Giros { get; set; }

        public DbSet<FormaDePago> FormaDePagos { get; set; }

        public DbSet<RepartoZona> RepartoZonas { get; set; }

        public DbSet<ClienteEstado> ClienteEstados { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            //modelBuilder.Entity<Group>()
            //    .HasMany(u => u.Users).WithMany(g => g.Groups)
            //    .Map(t => t.MapLeftKey("GroupId")
            //        .MapRightKey("UserId")
            //        .ToTable("GroupPerUser"));
        }

    }
}
