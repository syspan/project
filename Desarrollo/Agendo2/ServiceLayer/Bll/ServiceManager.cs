using Agendo.ServiceLayer.Dal;
using Agendo.ServiceLayer.Model.Service;
using Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agendo.ServiceLayer.Bll
{
    public class ServiceManager
    {

        #region Dependencies

        /// <summary>
        /// Class to handle injectable dependencies.
        /// </summary>
        internal class Dependencies
        {
            private bool _construct;
            private Dependency<ServicePersistor> _dal;
            internal ServicePersistor Dal
            {
                get { return _dal.Get(_construct); }
                set { _dal.Set(value); }
            }

            /// <summary>
            /// Construct all dependencies.
            /// </summary>
            /// <param name="construct">Used to invoke this constructor instead of the default constructor.</param>
            internal Dependencies(bool construct)
            {
                _construct = construct;
            }
            /// <summary>
            /// Default constructor for mocking only.
            /// </summary>
            internal Dependencies()
            {
            }
        }
        private readonly Dependencies _dependencies;

        #endregion

        #region Mocking Constructors

        /// <summary>
        /// Default constructor.
        /// </summary>
        public ServiceManager()
            : this(new Dependencies(true))
        {
           
        }
        
        /// <summary>
        /// Initialize with mocked dependencies.
        /// </summary>
        /// <param name="d">The mocked dependencies.</param>
        internal ServiceManager(Dependencies d)
		{
            _dependencies = d;
		}

   	    #endregion

        #region Public methods

        /// <summary>
        ///  Get the service list based on the filter criteria.
        /// </summary>
        /// <param name="criteria">The search criteria</param>
        /// <returns>The service list</returns>
        public virtual IList<ServiceInfo> GetList(Criteria criteria)
        {
            return _dependencies.Dal.GetList(criteria);
        }

        /// <summary>
        /// Read a service based on a specific identifier.
        /// </summary>
        /// <param name="id">The indentifier</param>
        /// <returns></returns>
        internal ServiceInfo Read(int id)
        {
            return _dependencies.Dal.Read(id);
        }

        #endregion


    }
}
