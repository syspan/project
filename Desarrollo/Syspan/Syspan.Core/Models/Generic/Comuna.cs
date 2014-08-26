using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syspan.Core.Models.Generic
{
    public class Ciudad
    {
        [Key]
        public string Codigo { get; set; }

        /// <summary>
        /// Gets or sets the description
        /// </summary>
        public string Descripcion { get; set; }
    }
}
