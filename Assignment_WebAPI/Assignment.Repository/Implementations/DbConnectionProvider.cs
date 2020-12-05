using Assignment.Repository.Constants;
using Assignment.Repository.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Assignment.Repository.Implementations
{
    /// <summary>
    /// Provides Open Connection 
    /// </summary>
    /// <seealso cref="Assignment.Repository.Interfaces.IDbConnectionProvider" />
    public class DbConnectionProvider : IDbConnectionProvider
    {
        /// <summary>
        /// Gets the connection instance.
        /// </summary>
        /// <returns></returns>
        public IDbConnection GetConnectionInstance()
        {
            IDbConnection con = new SqlConnection(ConfigurationConstant.ConnectionString);
            if (con.State == ConnectionState.Closed)
                con.Open();
            return con;
        }
    }
}
