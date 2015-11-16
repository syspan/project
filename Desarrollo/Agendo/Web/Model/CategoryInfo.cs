using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Agendo.Model
{
    public class Service
    {
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
        public double Price { get; set; }

    }
}