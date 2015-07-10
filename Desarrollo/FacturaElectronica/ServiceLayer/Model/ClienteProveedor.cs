using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Syspan.Core.Models.Generic;
using Erp.Dte.ServiceLayer.Model.Common;

namespace Erp.Dte.ServiceLayer.Model
{
    [Table("ClienteProveedor")]
    public class ClienteProveedor
    {
        private ClienteProveedorType _tipo = ClienteProveedorType.Cliente;
     
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
        public ClienteProveedorType Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
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
        /// Gets or sets permite facturar
        /// </summary>
        public bool PermiteFacturar { get; set; }
        
        /// <summary>
        /// Gets or sets NoEsAgenteRetenedor
        /// </summary>
        public bool NoEsAgenteRetenedor { get; set; }

        /// <summary>
        /// Gets or sets EsRolPrivado
        /// </summary>
        public bool EsRolPrivado { get; set; }

        /// <summary>
        /// Gets or sets the correo
        /// </summary>
        public string Observacion { get; set; }

        /// <summary>
        /// Get or sets the comuna id
        /// </summary>
        [ForeignKey("Comuna")]
        public int ComunaId { get; set; }

        /// <summary>
        /// Gets or sets the comuna
        /// </summary>
        public Comuna Comuna { get; set; }

    }


    //public class ClientMap : EntityTypeConfiguration<Cliente>
    //{
    //    public ClientMap()
    //    {
    //        this.ToTable("Cliente", "Cliente");

    //        // Primary Key
    //        this.HasKey(p => p.Rut);
           
    //    }
    //}
}
