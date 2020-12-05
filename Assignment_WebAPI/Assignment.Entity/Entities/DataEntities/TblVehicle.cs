using System;
using System.Collections.Generic;

#nullable disable

namespace Assignment.Entity.Entities.DataEntities
{
    public partial class TblVehicle
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public int? TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int? MaxPassangers { get; set; }
        public string Plate { get; set; }
        public bool? Available { get; set; }
        public string Vin { get; set; }
        public string Color { get; set; }
        public int? TransmissionTypeId { get; set; }
        public decimal? EngineSize { get; set; }
        public int? FuelTypeId { get; set; }
        public int? TankCapacity { get; set; }
        public int? Mileage { get; set; }

        public virtual TblFuelType FuelType { get; set; }
        public virtual TblTransmissionType TransmissionType { get; set; }
        public virtual TblVehicleType Type { get; set; }
    }
}
