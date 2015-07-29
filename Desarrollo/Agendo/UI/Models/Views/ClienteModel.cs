using System;
using System.ComponentModel.DataAnnotations;
using Agendo.UI.Properties;
using Syspan.Core.Models;

namespace Syspan.Admin.Models.Views
{
    public class ClienteModel : EntidadModel
    {

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(100)]
        [Display(Name = "ClienteModel_NombreFantasia", ResourceType = typeof(Resources))]
        public string NombreFantasia { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(100)]
        [Display(Name = "ClienteModel_CodSucursal", ResourceType = typeof(Resources))]
        public string CodSucursal { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(100)]
        [Display(Name = "ClienteModel_Memotecnico", ResourceType = typeof(Resources))]
        public string Memotecnico { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        //[Range(typeof(Int32), "0", "9999", ErrorMessage = "")]
        [Display(Name = "ClienteModel_SaldoMax", ResourceType = typeof(Resources))]
        public int SaldoMax { get; set; }

        [StringLength(1000)]
        [Display(Name = "ClienteModel_Observacion", ResourceType = typeof(Resources))]
        public string Observacion { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [Display(Name = "ClientModel_Giro", ResourceType = typeof(Resources))]
        public int IdGiro { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [Display(Name = "ClientModel_ZonaReparto", ResourceType = typeof(Resources))]
        public int IdReparto { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [Display(Name = "ClientModel_FormaPago", ResourceType = typeof(Resources))]
        public int IdFormaPago { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [Display(Name = "ClientModel_Estado", ResourceType = typeof(Resources))]
        public int IdEstado { get; set; }

        //navigation properties
        //public virtual Giro Giro { get; set; }
        //public virtual RepartoZona RepartoZona { get; set; }
        //public virtual FormaDePago FormaDePago { get; set; }
        //public virtual ClienteEstado ClienteEstado { get; set; }



    }
}