namespace Agendo.ServiceLayer.Model
{
    public class Contacto
    {
        /// <summary>
        /// Gets or sets the property name
        /// </summary>
        public int Telefono {get; set; }

        /// <summary>
        /// Gets or sets the property name
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the property name
        /// </summary>
        public int Fax { get; set; }

        /// <summary>
        /// Get or sets the comuna id
        /// </summary>
       public int ComunaId { get; set; }
    }
}
