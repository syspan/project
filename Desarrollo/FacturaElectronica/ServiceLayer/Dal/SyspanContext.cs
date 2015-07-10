﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Syspan.Core.Models;
using Syspan.Core.Models.Generic;
using Erp.Dte.ServiceLayer.Model.Common;

namespace Erp.Dte.ServiceLayer.Dal
{
    public class DTEContext : DbContext
    {
        public DTEContext()
            : base("connectionString")
        {
        }


        public DbSet<Entidad> Entidades { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Giro> Giros { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }

        public DbSet<Comuna> Comunas { get; set; }
        public DbSet<Provincia> Provincias { get; set; }
        public DbSet<Region> Regiones { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
           
            //modelBuilder.Entity<RepartoZona>()
            //.HasMany(o => o.Clientes)
            //.WithOptional()
            //.HasForeignKey(c => c.IdReparto);

            //modelBuilder.Entity<ClienteEstado>()
            //.HasMany(o => o.Clientes)
            //.WithOptional()
            //.HasForeignKey(c => c.IdEstado);

            //modelBuilder.Entity<Giro>()
            // .HasMany(o => o.Clientes)
            // .WithOptional()
            // .HasForeignKey(c => c.IdGiro);

            modelBuilder.Entity<FormaDePago>()
             .HasMany(o => o.Clientes)
             .WithOptional()
             .HasForeignKey(c => c.IdFormaPago);

            //modelBuilder.Entity<Comuna>()
            //.HasMany(o => o.)
            //.WithOptional()
            //.HasForeignKey(c => c.IdReparto);

        }

    }
}
