using System;
using System.ComponentModel.DataAnnotations;
namespace Syspan.Core.Models
{
    public class Cliente
    {
        [Key]
        public string Rut { get; set; }
       
        /// <summary>
        /// Gets or sets the property nombrefantasia
        /// </summary>
        public string NombreFantasia { get; set; }

        /// <summary>
        /// Gets or sets the property CodSucursal
        /// </summary>
        public string CodSucursal { get; set; }

        /// <summary>
        /// Gets or sets the property Memotecnico
        /// </summary>
        public string Memotecnico { get; set; }

        /// <summary>
        /// Gets or sets the property SaldoMax
        /// </summary>
        public int SaldoMax { get; set; }

        /// <summary>
        /// Gets or sets the property Observacion
        /// </summary>
        public string Observacion { get; set; }

    }
}
