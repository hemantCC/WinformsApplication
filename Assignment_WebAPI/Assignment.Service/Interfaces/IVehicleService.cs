using Assignment.Entity.Entities.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Interfaces
{
    public interface IVehicleService
    {
        /// <summary>
        /// Gets the vehicles asynchronous.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns></returns>
        Task<IEnumerable<VehicleViewModel>> GetVehiclesAsync(string searchString);

        /// <summary>
        /// Adds the or edit vehicle asynchronous.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns></returns>
        Task<bool> AddOrEditVehicleAsync(VehicleViewModel vehicle);

        /// <summary>
        /// Gets the vehicle types.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<string>> GetVehicleTypes();
        /// <summary>
        /// Gets the transmission types.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<string>> GetTransmissionTypes();

        /// <summary>
        /// Gets the fuel types.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<string>> GetFuelTypes();

        /// <summary>
        /// Deletes the vehicle.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        Task<bool> DeleteVehicle(int Id);
    }
}
