using Assignment.Entity.Entities.BusinessEntities;
using Assignment.Service.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VehicleController : ControllerBase
    {
        #region Private Members     
        
        /// <summary>
        /// The vehicle service
        /// </summary>
        private readonly IVehicleService _vehicleService;

        #endregion

        #region Constructor


        /// <summary>
        /// Initializes a new instance of the <see cref="VehicleController"/> class.
        /// </summary>
        /// <param name="vehicleService">The vehicle service.</param>
        public VehicleController(IVehicleService vehicleService)
        {
            _vehicleService = vehicleService;
        }

        #endregion
       

        /// <summary>
        /// Gets the vehicles.
        /// </summary>
        /// <param name="searchString">The search string.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("GetVehicles")]
        public async Task<IActionResult> GetVehicles(string searchString = null)
        {
            IEnumerable<VehicleViewModel> vehicles = await _vehicleService.GetVehiclesAsync(searchString);
            if (vehicles == null)
            {
                return BadRequest("No vehicles Found!");
            }
            return Ok(vehicles);
        }

        /// <summary>
        /// Adds the or edit vehicle asynchronous.
        /// </summary>
        /// <param name="vehicle">The vehicle.</param>
        /// <returns></returns>
        [HttpPost]
        [Route("AddOrEditVehicle")]
        public async Task<IActionResult> AddOrEditVehicleAsync(VehicleViewModel vehicle)
        {
            bool result = await _vehicleService.AddOrEditVehicleAsync(vehicle);
            if (result == false)
            {
                return BadRequest("Operation Failed!");
            }
            return Ok("Operation Successful.");
        }

        /// <summary>
        /// Gets the vehicle types.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetVehicleTypes")]
        public async Task<IActionResult> GetVehicleTypes()
        {
            var values = await _vehicleService.GetVehicleTypes();
            if (values == null)
            {
                return BadRequest("No vehicles Types Found!");
            }
            return Ok(values);
        }

        /// <summary>
        /// Gets the fuel types.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetFuelTypes")]
        public async Task<IActionResult> GetFuelTypes()
        {
            var values = await _vehicleService.GetFuelTypes();
            if (values == null)
            {
                return BadRequest("No Fuel Types Found!");
            }
            return Ok(values);
        }

        /// <summary>
        /// Gets the transmission types.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetTransmissionTypes")]
        public async Task<IActionResult> GetTransmissionTypes()
        {
            var values = await _vehicleService.GetTransmissionTypes();
            if (values == null)
            {
                return BadRequest("No Transmission Types Found!");
            }
            return Ok(values);
        }

        /// <summary>
        /// Deletes the vehicle.
        /// </summary>
        /// <param name="id">The identifier.</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("DeleteVehicle")]
        public async Task<IActionResult> DeleteVehicle(int id)
        {
            bool result = await _vehicleService.DeleteVehicle(id);
            if (result == false)
            {
                return BadRequest("Delete Operation Failed!");
            }
            return Ok("Record Deleted Successfully.");
        }
    }
}
