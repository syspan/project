using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        /// <summary>
        /// gets or sets the type
        /// </summary>
        public int Tipo { get; set; }

        /// <summary>
        /// gets or sets the comuna
        /// </summary>
        public string IdComuna { get; set; }

        /// <summary>
        /// Gets or sets the ciudad
        /// </summary>
        public List<Ciudad> Ciudad { get; set; }

        /// <summary>
        /// Gets or sets the status
        /// </summary>
        public GenericStatus Status { get; set; }
    }
}
