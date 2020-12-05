using Assignment.Entity.Entities.BusinessEntities;
using Assignment.Repository.Constants;
using Assignment.Repository.Interfaces;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository.Implementations
{

    public class VehicleRepository : IVehicleRepository
    {
        #region Private Members

        /// <summary>
        /// The database connection provider
        /// </summary>
        private readonly IDbConnectionProvider _dbConnectionProvider;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleRepository"/> class.
        /// </summary>
        /// <param name="dbConnectionProvider">The database connection provider.</param>
        public VehicleRepository(IDbConnectionProvider dbConnectionProvider)
        {
            _dbConnectionProvider = dbConnectionProvider;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the vehicle types.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<string>> GetVehicleTypes()
        {
            using IDbConnection con = _dbConnectionProvider.GetConnectionInstance();
            IEnumerable<string> values = await con.QueryAsync<string>(StoredProcedureName.GetVehicleTypes);
            return values;
        }

        /// <summary>
        /// Gets the vehicles asynchronous.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns></returns>
        public async Task<IEnumerable<VehicleViewModel>> GetVehiclesAsync(string searchString)
        {
            using IDbConnection con = _dbConnectionProvider.GetConnectionInstance();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@SearchString", searchString);
            IEnumerable<VehicleViewModel> vehicles = await con.QueryAsync<VehicleViewModel>(StoredProcedureName.GetVehicles,
                parameters, commandType: CommandType.StoredProcedure);
            return vehicles;
        }

        /// <summary>
        /// Gets the transmission types.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<string>> GetTransmissionTypes()
        {
            using IDbConnection con = _dbConnectionProvider.GetConnectionInstance();
            IEnumerable<string> values = await con.QueryAsync<string>(StoredProcedureName.GetTransmissionTypes);
            return values;
        }

        /// <summary>
        /// Gets the fuel types.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<string>> GetFuelTypes()
        {
            using IDbConnection con = _dbConnectionProvider.GetConnectionInstance();
            IEnumerable<string> values = await con.QueryAsync<string>(StoredProcedureName.GetFuelTypes);
            return values;
        }

        /// <summary>
        /// Adds the or edit vehicle asynchronous.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns></returns>
        public async Task<bool> AddOrEditVehicleAsync(VehicleViewModel vehicle)
        {
            using IDbConnection con = _dbConnectionProvider.GetConnectionInstance();
            var result = await con.ExecuteAsync(StoredProcedureName.AddOrEditVehicle, SetVehicleParameter(vehicle), commandType: CommandType.StoredProcedure);
            if (result == -1)
            {
                return true;
            }
            return false;
        }

        /// <summary>
        /// Deletes the vehicle.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> DeleteVehicle(int Id)
        {
            using IDbConnection con = _dbConnectionProvider.GetConnectionInstance();
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", Id);
            var result = await con.ExecuteAsync(StoredProcedureName.DeleteVehicle, parameters, commandType: CommandType.StoredProcedure);
            if (result == -1)
            {
                return true;
            }
            return false;
        }

        #endregion

        #region Private Methods

        /// <summary>
        /// Sets the vehicle parameter.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns></returns>
        private DynamicParameters SetVehicleParameter(VehicleViewModel vehicle)
        {
            DynamicParameters parameters = new DynamicParameters();
            parameters.Add("@Id", vehicle.Id);
            parameters.Add("@Category", vehicle.Category);
            parameters.Add("@TypeName", vehicle.TypeName);
            parameters.Add("@Make", vehicle.Make);
            parameters.Add("@Model", vehicle.Model);
            parameters.Add("@Year", vehicle.Year);
            parameters.Add("@MaxPassangers", vehicle.MaxPassangers);
            parameters.Add("@Plate", vehicle.Plate);
            parameters.Add("@Available", vehicle.Available);
            parameters.Add("@VIN", vehicle.Vin);
            parameters.Add("@Color", vehicle.Color);
            parameters.Add("@TransmissionTypeName", vehicle.TransmissionTypeName);
            parameters.Add("@EngineSize", vehicle.EngineSize);
            parameters.Add("@FuelTypeName", vehicle.FuelTypeName);
            parameters.Add("@TankCapacity", vehicle.TankCapacity);
            parameters.Add("@Mileage", vehicle.Mileage);
            return parameters;
        }

        #endregion
    }
}
