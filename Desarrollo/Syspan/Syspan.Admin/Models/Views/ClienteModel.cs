using System;
using System.ComponentModel.DataAnnotations;
using Syspan.Admin.Properties;
using Syspan.Core.Models;

namespace Syspan.Admin.Models.Views
{
    public class ClienteModel : EntidadModel
    {
      
        [Required(ErrorMessage = "Es Requerido")]
        [StringLength(100)]
        [Display(Name = "ClienteModel_NombreFantasia", ResourceType = typeof(Resources))]
        public string NombreFantasia { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "ClienteModel_CodSucursal", ResourceType = typeof(Resources))]
        public string CodSucursal { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "ClienteModel_Memotecnico", ResourceType = typeof(Resources))]
        public string Memotecnico { get; set; }

        [Required]
        //[Range(typeof(Int32), "0", "9999", ErrorMessage = "")]
        [Display(Name = "ClienteModel_SaldoMax", ResourceType = typeof(Resources))]
        public int SaldoMax { get; set; }

        [Required]
        [StringLength(1000)]
        [Display(Name = "ClienteModel_Observacion", ResourceType = typeof(Resources))]
        public string Observacion { get; set; }

        [Required]
        [Display(Name = "ClientModel_Giro", ResourceType = typeof(Resources))]
        public int IdGiro { get; set; }

        [Required]
        [Display(Name = "ClientModel_ZonaReparto", ResourceType = typeof(Resources))]
        public int IdReparto { get; set; }

        [Required]
        [Display(Name = "ClientModel_FormaPago", ResourceType = typeof(Resources))]
        public int IdFormaPago { get; set; }

        [Required]
        [Display(Name = "ClientModel_Estado", ResourceType = typeof(Resources))]
        public int IdEstado { get; set; }

        //navigation properties
        public virtual Giro Giro { get; set; }
        public virtual RepartoZona RepartoZona { get; set; }
        public virtual FormaDePago FormaDePago { get; set; }
        public virtual ClienteEstado ClienteEstado { get; set; }



    }
}