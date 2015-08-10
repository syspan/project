using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace Agendo.ServiceLayer.Model.Category
{
    [Table("Service")]
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
    }
}
