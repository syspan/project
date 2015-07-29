using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Erp.Dte.ServiceLayer.Model.Clientes
{
    public class Criteria
    {
        private ClienteStatus _estado = ClienteStatus.Active;

        public string Rut { get; set; }

        /// <summary>
        /// Gets or sets the razon social
        /// </summary>
        public string RazonSocial { get; set; }

        /// <summary>
        /// Gets or sets the nombre fantasia
        /// </summary>
        public string NombreFantasia { get; set; }

        /// <summary>
        /// Gets or sets the giro
        /// </summary>
        public string Giro { get; set; }

        /// <summary>
        /// Gets or sets the estado
        /// </summary>
        public ClienteStatus Estado {
            get { return _estado;}
            set { _estado = value; }
        }
    }
}
