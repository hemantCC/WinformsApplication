using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Repository.Constants
{
    public class StoredProcedureName
    {
        #region Vehicles

        /// <summary>
        /// Stored Procedure for Getting all Vehicle types
        /// </summary>
        internal const string GetVehicleTypes = "[dbo].[usp_GetVehicleTypes]";

        /// <summary>
        /// Stored Procedure for Getting all Transmission types
        /// </summary>
        internal const string GetTransmissionTypes = "[dbo].[usp_GetTransmissionTypes]";

        /// <summary>
        /// Stored Procedure for Getting all Fuel types
        /// </summary>
        internal const string GetFuelTypes = "[dbo].[usp_GetFuelTypes]";

        /// <summary>
        /// Stored Procedure for Getting all Vehicles
        /// </summary>
        internal const string GetVehicles = "[dbo].[usp_GetVehicleDetails]";

        /// <summary>
        /// Stored Procedure for Add or Edit Vehicle
        /// </summary>
        internal const string AddOrEditVehicle = "[dbo].[usp_AddOrEditVehicle]";

        /// <summary>
        /// Stored Procedure for Deleting Vehicle
        /// </summary>
        internal const string DeleteVehicle = "[dbo].[usp_DeleteVehicle]";
        #endregion

        #region User

        /// <summary>
        /// Stored Procedure for Deleting Vehicle
        /// </summary>
        internal const string ChangePassword = "[dbo].[usp_ChangePassword]";

        #endregion
    }
}
