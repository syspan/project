using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Erp.Dte.ServiceLayer.Model
{
    [Table("ClienteProveedor")]
    public class Cliente
    {
        /// <summary>
        /// Gets or sets the property rut
        /// </summary>
        [Key]
        public string Rut { get; set; }

        /// <summary>
        /// Gets or sets the razon social
        /// </summary>
        public string RazonSocial { get; set; }

        /// <summary>
        /// Gets or sets the nombre fantasia
        /// </summary>
        public string NombreFantasia { get; set; }

        /// <summary>
        /// Gets or sets the giro
        /// </summary>
        public string Giro { get; set; }

        /// <summary>
        /// Gets or sets the property contacto
        /// </summary>
        public Contacto Contacto { get; set; }
        
        /// <summary>
        /// Gets or sets the correo
        /// </summary>
        public string Observacion { get; set; }

        /// <summary>
        /// Gets or sets the estado
        /// </summary>
        public ClienteStatus Estado { get; set; }
    }
}
