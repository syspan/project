using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syspan.Core.Models.Generic
{
    public class Direccion
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// gets or sets the descrition
        /// </summary>
        public int Descripcion { get; set; }

        /// <summary>
        /// gets or sets the descrition
        /// </summary>
        public int Numero { get; set; }

        ///// <summary>
        ///// gets or sets the type
        ///// </summary>
        //public AddressType Tipo { get; set; }

        /// <summary>
        /// gets or sets the comuna
        /// </summary>
        [ForeignKey("Comuna")]
        public int IdComuna { get; set; }

        ///// <summary>
        ///// Gets or sets the comuna
        ///// </summary>
        //public Comuna Comuna { get; set; }

        ///// <summary>
        ///// Gets or sets the status
        ///// </summary>
        //public GenericStatus Estado { get; set; }

        /// <summary>
        /// Gets or sets the rut
        /// </summary>
        public string Rut { get; set; }
    }
}
