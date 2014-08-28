using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Syspan.Core.Models.Generic;

namespace Syspan.Core.Models
{
    [Table("Cliente")] 
    public class Cliente : Entidad
    {
        private ClienteStatus _estado = ClienteStatus.Active;
        //[Key]
        //public string Rut { get; set; }
       
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
        [ForeignKey("RepartoZona")]
        public int IdReparto { get; set; }

        /// <summary>
        /// Get or sets the status id
        /// </summary>
        [ForeignKey("ClienteEstado")]
        public int IdEstado { get; set; }

        /// <summary>
        /// Get or sets the forma pago id
        /// </summary>
        [ForeignKey("FormaPago")]
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
        public virtual RepartoZona ClienteEstado { get; set; }

        /// <summary>
        /// Gets or sets the property forma pago
        /// </summary>
        public virtual FormaDePago FormaPago { get; set; }

        public ClienteStatus Estado {
           get {return  _estado;}
            set { _estado = value; }
        }


    }


    public class ClientMap : EntityTypeConfiguration<Cliente>
    {
        public ClientMap()
        {
            this.ToTable("Cliente", "Cliente");

            // Primary Key
            this.HasKey(p => p.Rut);
           
        }
    }
}
