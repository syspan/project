using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Syspan.Core.Models
{
    public class Giro
    {
        [Key]
        public int Id { get; set; }
       
        /// <summary>
        /// Gets or sets the property name
        /// </summary>
        public string Nombre { get; set; }

        //Navigation property 
        public virtual ICollection<Cliente> Clientes { get; set; }
    }
}
