using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Entity.Entities.BusinessEntities
{
    public class VehicleViewModel
    {
        public int Id { get; set; }
        public string Category { get; set; }
        public string TypeName { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public int? MaxPassangers { get; set; }
        public string Plate { get; set; }
        public bool? Available { get; set; }
        public string Vin { get; set; }
        public string Color { get; set; }
        public string TransmissionTypeName { get; set; }
        public decimal? EngineSize { get; set; }
        public string FuelTypeName { get; set; }
        public int? TankCapacity { get; set; }
        public int? Mileage { get; set; }

    }
}
