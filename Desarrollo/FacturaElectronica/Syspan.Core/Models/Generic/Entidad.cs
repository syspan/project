using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syspan.Core.Models.Generic
{
    public class Entidad
    {

        [Key]
        public string Rut { get; set; }


        /// <summary>
        /// Gets or sets the property alias
        /// </summary>
        public string Nombre { get; set; }

        public string Email { get; set; }

    }
}
