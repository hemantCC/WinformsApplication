using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Assignment.Repository.Interfaces
{
    /// <summary>
    /// Provides Db Connection with
    /// </summary>
    public interface IDbConnectionProvider
    {
        /// <summary>
        /// Gets the open connection instance.
        /// </summary>
        /// <returns></returns>
        IDbConnection GetConnectionInstance();
    }
}
