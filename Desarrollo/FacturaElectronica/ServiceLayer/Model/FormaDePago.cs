using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syspan.Core.Models
{
    public class FormaDePago
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
