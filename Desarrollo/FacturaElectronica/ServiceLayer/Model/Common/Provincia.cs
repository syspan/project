using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Dte.ServiceLayer.Model.Common
{
    public class Provincia
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
        [ForeignKey("Region")]
        public int IdRegion { get; set; }

        /// <summary>
        /// Gets or sets the region
        /// </summary>
        public Region Region { get; set; }

        /// <summary>
        /// Gets or sets the comunas
        /// </summary>
        public virtual ICollection<Comuna> Comunas { get; set; }

    }
}
