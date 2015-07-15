using System;
using System.ComponentModel.DataAnnotations;
using Erp.Dte.UI.Properties;
using Erp.Dte.ServiceLayer.Model;

namespace Erp.Dte.UI.Models.Views
{
	public class ClienteProveedor
	{
        [Key]
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        //[RegularExpression(@"\b\d{1,8}\-[K|k|0-9]", ErrorMessageResourceType = typeof (Resources), ErrorMessageResourceName = "EntidadModel_Rut_InvalidFormat")]
        //[Remote("ClientExists", "Cliente", "RUT ya existe.")]
        public string Rut { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(200)]
        [Display(Name = "ClienteProveedor_RazonSocial", ResourceType = typeof(Resources))]
        public string RazonSocial { get; set; }

        //[Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        //[Display(Name = "ClienteProveedor_Tipo", ResourceType = typeof(Resources))]
        //public ClienteProveedorType Tipo { get; set; }

        [StringLength(200)]
        [Display(Name = "ClienteProveedor_NombreFantasia", ResourceType = typeof(Resources))]
        public string NombreFantasia { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(200)]
        [Display(Name = "ClienteProveedor_Giro", ResourceType = typeof(Resources))]
        public string Giro { get; set; }

        [StringLength(50)]
        [Display(Name = "ClienteProveedor_CodCliente", ResourceType = typeof(Resources))]
        public string CodCliente { get; set; }

        [Display(Name = "ClienteProveedor_Telefono", ResourceType = typeof(Resources))]
        public int Telefono { get; set; }

        [StringLength(200)]
        [Display(Name = "ClienteProveedor_Correo", ResourceType = typeof(Resources))]
        public string Correo { get; set; }

        [Display(Name = "ClienteProveedor_Fax", ResourceType = typeof(Resources))]
        public int Fax { get; set; }



	}
}