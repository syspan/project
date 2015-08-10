using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace Agendo.ServiceLayer.Dal
{
    public class AgendoContext : DbContext
    {
        public AgendoContext()
            : base("connectionString")
        {
        }

        public DbSet<Agendo.ServiceLayer.Model.Clientes.ClienteInfo> Clientes { get; set; }
        public DbSet<Agendo.ServiceLayer.Model.Service.ServiceInfo> Services { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}
