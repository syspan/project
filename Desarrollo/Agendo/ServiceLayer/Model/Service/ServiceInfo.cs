using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Agendo.ServiceLayer.Model.Category;

namespace Agendo.ServiceLayer.Model.Service
{
    [Table("Service")]
    public class ServiceInfo
    {
        /// <summary>
        /// Gets or sets the id
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the average time
        /// </summary>
        public string AvgTime { get; set; }

        /// <summary>
        /// Gets or sets the price
        /// </summary>
        public string Price { get; set; }

        /// <summary>
        /// Gets or sets the property category
        /// </summary>
        public CategoryInfo Category { get; set; }
    
        /// <summary>
        /// Gets or sets the status
        /// </summary>
        public GeneralStatus Status { get; set; }
    }
}
