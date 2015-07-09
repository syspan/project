using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syspan.Core.Models.Generic
{
    public class Comuna
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// gets or sets the provincia
        /// </summary>
        [ForeignKey("Provincia")]
        public int IdProvincia { get; set; }

        /// <summary>
        /// Gets or sets the provincia
        /// </summary>
        public Provincia Provincia { get; set; }

        /// <summary>
        /// Gets or sets the address
        /// </summary>
        public virtual ICollection<Direccion> Direcciones { get; set; }

    }
}
