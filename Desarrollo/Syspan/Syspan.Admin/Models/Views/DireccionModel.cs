using Syspan.Admin.Properties;
using Syspan.Core.Models.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Syspan.Admin.Models.Views
{
    public class DireccionModel
    {
        [Key]
        public int Id { get; set; }
      
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(100)]
        [Display(Name = "DireccionModel_Descripcion", ResourceType = typeof(Resources))]
        public string Descripcion { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(100)]
        [Display(Name = "DireccionModel_Numero", ResourceType = typeof(Resources))]
        public string Numero { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [Display(Name = "DireccionModel_Tipo", ResourceType = typeof(Resources))]
        public AddressType Tipo { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [Display(Name = "DireccionModel_Comuna", ResourceType = typeof(Resources))]
        public int IdComuna { get; set; }
      
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [Display(Name = "DireccionModel_Provincia", ResourceType = typeof(Resources))]
        public int IdProvincia { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [Display(Name = "DireccionModel_Region", ResourceType = typeof(Resources))]
        public int IdRegion { get; set; }

        //navigation properties
        public virtual Comuna Comuna { get; set; }
        public virtual Provincia Provincia { get; set; }
        public virtual Region Region { get; set; }

    }
}