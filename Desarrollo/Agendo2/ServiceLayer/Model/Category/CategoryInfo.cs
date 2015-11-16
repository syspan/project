using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Agendo.ServiceLayer.Model.Service;

namespace Agendo.ServiceLayer.Model.Category
{
    [Table("Category")]
    public class CategoryInfo
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [Key]
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }
    
        /// <summary>
        /// Gets or sets the status
        /// </summary>
        public GeneralStatus Status { get; set; }

        //Navigation property 
        public virtual ICollection<ServiceInfo> Services { get; set; }

    }
}
