using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Dte.ServiceLayer.Model.Common
{
    public class Region
    {
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// gets or sets the ordinal
        /// </summary>
        public string Ordinal { get; set; }

        /// <summary>
        /// Gets or sets the provincias
        /// </summary>
        public virtual ICollection<Provincia> Provincias { get; set; }

    }
}
