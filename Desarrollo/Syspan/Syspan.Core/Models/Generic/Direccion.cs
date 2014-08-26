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
        public string Descripcion { get; set; }

        /// <summary>
        /// gets or sets the comuna
        /// </summary>
        public string Comuna { get; set; }

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
