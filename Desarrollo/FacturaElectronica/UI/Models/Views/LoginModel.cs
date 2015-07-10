using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Erp.Dte.UI.Properties;

namespace Syspan.Admin.Models.Views
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "LoginModel_UserName", ResourceType = typeof(Resources))]
        [DataType(DataType.EmailAddress)]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "LoginModel_Password", ResourceType = typeof(Resources))]
        public string Password { get; set; }
    }

}