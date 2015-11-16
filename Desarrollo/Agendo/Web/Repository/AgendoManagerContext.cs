using Agendo.Model;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Agendo.Repository
{
    public class AgendoManagerContext : DbContext
    {
        public AgendoManagerContext()
            : base("connectionString")
        {
            Database.SetInitializer<AgendoManagerContext>(null);
            //Configuration.ProxyCreationEnabled = false;
            //Configuration.LazyLoadingEnabled = false;
        }

        // DEVELOPMENT ONLY: initialize the database
        //static AgendoManagerContext()
        //{
        //   // Database.SetInitializer(new CustomerManagerDatabaseInitializer());
        //}


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }



        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<State> States { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}