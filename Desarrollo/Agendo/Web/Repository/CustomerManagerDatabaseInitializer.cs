using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace Agendo.Repository
{
    ////DropCreateDatabaseIfModelChanges<TodosContext>
    public class CustomerManagerDatabaseInitializer : DropCreateDatabaseAlways<AgendoManagerContext> // re-creates every time the server starts
    {
        protected override void Seed(AgendoManagerContext context)
        {
           // DataInitializer.Initialize(context);
            base.Seed(context);
        }
    }
}
