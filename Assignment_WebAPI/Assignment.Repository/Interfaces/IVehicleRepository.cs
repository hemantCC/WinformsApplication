using Assignment.Entity.Entities.BusinessEntities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Repository.Interfaces
{
    public interface IVehicleRepository
    {
        Task<IEnumerable<VehicleViewModel>> GetVehiclesAsync(string searchString);
        Task<bool> AddOrEditVehicleAsync(VehicleViewModel vehicle);
        Task<IEnumerable<string>> GetVehicleTypes();
        Task<IEnumerable<string>> GetTransmissionTypes();
        Task<IEnumerable<string>> GetFuelTypes();
        Task<bool> DeleteVehicle(int Id);
    }
}
