using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendo.ServiceLayer.Model.Service
{
    public class Criteria
    {
        private GeneralStatus _status = GeneralStatus.Active;

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the category
        /// </summary>
        public CategoryInfo Category { get; set; }

        /// <summary>
        /// Gets or sets the status
        /// </summary>
        public GeneralStatus Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
