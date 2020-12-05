using Assignment.Entity.Entities.BusinessEntities;
using Assignment.Repository.Interfaces;
using Assignment.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Service.Implementations
{
    public class VehicleService : IVehicleService
    {
        #region Private Members

        /// <summary>
        /// The vehicle repository
        /// </summary>
        private readonly IVehicleRepository _vehicleRepository;

        #endregion

        #region Constructor


        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleService"/> class.
        /// </summary>
        /// <param name="vehicleRepository">The vehicle repository.</param>
        public VehicleService(IVehicleRepository vehicleRepository)
        {
            _vehicleRepository = vehicleRepository;
        }

        #endregion

        #region Public Methods


        /// <summary>
        /// Adds the or edit vehicle asynchronous.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns></returns>
        public async Task<bool> AddOrEditVehicleAsync(VehicleViewModel vehicle)
        {
            return await _vehicleRepository.AddOrEditVehicleAsync(vehicle);
        }

        /// <summary>
        /// Deletes the vehicle.
        /// </summary>
        /// <param name="Id">The identifier.</param>
        /// <returns></returns>
        public async Task<bool> DeleteVehicle(int Id)
        {
            return await _vehicleRepository.DeleteVehicle(Id);
        }

        /// <summary>
        /// Gets the fuel types.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<string>> GetFuelTypes()
        {
            return await _vehicleRepository.GetFuelTypes();
        }

        /// <summary>
        /// Gets the transmission types.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<string>> GetTransmissionTypes()
        {
            return await _vehicleRepository.GetTransmissionTypes();
        }

        /// <summary>
        /// Gets the vehicles asynchronous.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns></returns>
        public async Task<IEnumerable<VehicleViewModel>> GetVehiclesAsync(string searchString)
        {
            return await _vehicleRepository.GetVehiclesAsync(searchString);
        }

        /// <summary>
        /// Gets the vehicle types.
        /// </summary>
        /// <returns></returns>
        public async Task<IEnumerable<string>> GetVehicleTypes()
        {
            return await _vehicleRepository.GetVehicleTypes();
        }

        #endregion
    }
}
