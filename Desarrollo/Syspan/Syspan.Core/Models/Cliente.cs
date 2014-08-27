using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Syspan.Core.Models
{
    public class Cliente
    {
        [Key]
        public string Rut { get; set; }
       
        /// <summary>
        /// Gets or sets the property alias
        /// </summary>
        public string NombreFantasia { get; set; }

        /// <summary>
        /// Gets or sets the property branch name
        /// </summary>
        public string CodSucursal { get; set; }

        /// <summary>
        /// Gets or sets the property alias
        /// </summary>
        public string Memotecnico { get; set; }

        /// <summary>
        /// Gets or sets the property max 
        /// </summary>
        public int SaldoMax { get; set; }

        /// <summary>
        /// Gets or sets the property comments
        /// </summary>
        public string Observacion { get; set; }

        /// <summary>
        /// Get or sets the giro id
        /// </summary>
        public int IdGiro { get; set; }

        /// <summary>
        /// Get or sets the reparto id
        /// </summary>
        public int IdReparto { get; set; }

        /// <summary>
        /// Get or sets the status id
        /// </summary>
        public int IdEstado { get; set; }

        /// <summary>
        /// Get or sets the forma pago id
        /// </summary>
        public int IdFormaPago { get; set; }

        //Navigation property 
        /// <summary>
        /// Gets or sets the property Giro
        /// </summary>
        [ForeignKey("IdGiro")]
        public virtual Giro Giro { get; set; }

        /// <summary>
        /// Gets or sets the property reparto zona
        /// </summary>
        [ForeignKey("IdReparto")]
        public virtual RepartoZona RepartoZona { get; set; }

        /// <summary>
        /// Gets or sets the property cliente estado
        /// </summary>
        [ForeignKey("IdEstado")]
        public virtual RepartoZona ClienteEstado { get; set; }

        /// <summary>
        /// Gets or sets the property forma pago
        /// </summary>
        [ForeignKey("IdFormaPago")]
        public virtual FormaDePago FormaPago { get; set; }     


    }
}
