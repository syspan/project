using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Agendo.ServiceLayer.Model.Category;
using Agendo.Service.Api.Properties;

namespace Agendo.Service.Api.Models.Views
{
    public class ServicioModel
    {
        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(100)]
        [Display(Name = "ServicioModel_Name", ResourceType = typeof(Resources))]
        public string Name { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(100)]
        [Display(Name = "ServicioModel_Tiempo", ResourceType = typeof(Resources))]
        public string AvgTime { get; set; }

        [Required(ErrorMessageResourceType = typeof(Resources), ErrorMessageResourceName = "View_Required")]
        [StringLength(100)]
        [Display(Name = "ServicioModel_Precio", ResourceType = typeof(Resources))]
        public string Price { get; set; }


        //navigation properties
        public virtual CategoryInfo Category { get; set; }





    }
}