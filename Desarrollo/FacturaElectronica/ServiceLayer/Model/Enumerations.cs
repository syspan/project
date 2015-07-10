namespace Erp.Dte.ServiceLayer.Model
{
    /// <summary>
    /// Return values for the generic status
    /// </summary>
    public enum ClienteStatus
    {
        /// <summary>
        /// Deleted
        /// </summary>
        Deleted, 
        /// <summary>
        /// active.
        /// </summary>
        Active,
        /// <summary>
        /// inactive
        /// </summary>
        Inactive
    }

    /// <summary>
    /// return clientprovider type
    /// </summary>
    public enum ClienteProveedorType
    {
        /// <summary>
        /// Cliente
        /// </summary>
        Cliente = 0,
        /// <summary>
        /// Proveedor.
        /// </summary>
        Proveedor = 1,
   
    }
}
