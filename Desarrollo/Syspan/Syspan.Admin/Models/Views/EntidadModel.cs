using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Syspan.Admin.Properties;
using Syspan.Core.Models.Generic;

namespace Syspan.Admin.Models.Views
{
    public class EntidadModel
    {
        [Key]
        [Required]
        public string Rut { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "EntidadModel_Nombre", ResourceType = typeof(Resources))]
        public string Nombre { get; set; }

        [Required]
        [StringLength(50)]
        [EmailAddress]
        [Display(Name = "EntidadModel_Email", ResourceType = typeof(Resources))]
        public string Email { get; set; }


        public virtual List<Direccion> Direcciones { get; set; }
    }
}