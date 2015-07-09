using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Syspan.Core.Models.Generic;

namespace Syspan.Core.Models
{
    [Table("Cliente")]
    public class ClienteProveedor : Entidad
    {
        private ClienteProveedorType _clienteProveedorType = ClienteProveedorType.Cliente;
        //[Key]
        //public string Rut { get; set; }
       
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
        /// Gets or sets the cliente proveedor type
        /// </summary>
        public ClienteProveedorType ClienteProveedorType
        {
            get { return _clienteProveedorType; }
            set { _clienteProveedorType = value; }
        }

        /// <summary>
        /// Gets or sets the nombre fantasia
        /// </summary>
        public string NombreFantasia { get; set; }

        /// <summary>
        /// Gets or sets the giro
        /// </summary>
        public string Giro { get; set; }

        /// <summary>
        /// Gets or sets the cod cliente
        /// </summary>
        public string CodCliente { get; set; }

        /// <summary>
        /// Gets or sets the property telefono
        /// </summary>
        public int Telefono { get; set; }
        
        /// <summary>
        /// Gets or sets the correo
        /// </summary>
        public string Correo { get; set; }



        /// <summary>
        /// Gets or sets the correo
        /// </summary>
        public string Fax { get; set; }




        /// <summary>
        /// Get or sets the giro id
        /// </summary>
        [ForeignKey("Giro")]
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
        [ForeignKey("FormaDePago")]
        public int IdFormaPago { get; set; }

    
        /// <summary>
        /// Gets or sets the property reparto zona
        /// </summary>
        public virtual RepartoZona RepartoZona { get; set; }

        /// <summary>
        /// Gets or sets the property cliente estado
        /// </summary>
        public virtual ClienteEstado ClienteEstado { get; set; }

        /// <summary>
        /// Gets or sets the property forma pago
        /// </summary>
        public virtual FormaDePago FormaDePago { get; set; }

     
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
