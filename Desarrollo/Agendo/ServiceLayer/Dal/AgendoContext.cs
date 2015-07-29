using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using Syspan.Core.Models;
using Syspan.Core.Models.Generic;
using Erp.Dte.ServiceLayer.Model;
using Erp.Dte.ServiceLayer.Model.Clientes;

namespace Agendo.ServiceLayer.Dal
{
    public class AgendoContext : DbContext
    {
        public AgendoContext()
            : base("connectionString")
        {
        }

        public DbSet<ClienteInfo> Clientes { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
