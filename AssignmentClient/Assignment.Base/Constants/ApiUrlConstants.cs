using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Base.Constants
{
    /// <summary>
    /// API URL Constants for API Call 
    /// </summary>
    public class ApiUrlConstants
    {

        public const string RegisterBaseUrl = "User/PostUser";
        public const string LoginBaseUrl = "User/Login";
        public const string CheckIfUserExistisBaseUrl = "User/CheckIfUsernameExists";
        public const string GetAllRolesBaseUrl = "User/GetRoles";
        public const string ChangePasswordBaseUrl = "User/ChangePassword";


        public const string GetVehiclesBaseUrl = "Vehicle/GetVehicles";
        public const string GetVehicleTypesBaseUrl = "Vehicle/GetVehicleTypes";
        public const string GetTransmissionTypesBaseUrl = "Vehicle/GetTransmissionTypes";
        public const string GetFuelTypesBaseUrl = "Vehicle/GetFuelTypes";
        public const string AddOrEditVehicleBaseUrl = "Vehicle/AddOrEditVehicle";
        public const string DeleteVehicleBaseUrl = "Vehicle/DeleteVehicle";
    }
}
