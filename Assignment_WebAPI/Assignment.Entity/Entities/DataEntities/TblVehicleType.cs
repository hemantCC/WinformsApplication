using System;
using System.Collections.Generic;

#nullable disable

namespace Assignment.Entity.Entities.DataEntities
{
    public partial class TblVehicleType
    {
        public TblVehicleType()
        {
            TblVehicles = new HashSet<TblVehicle>();
        }

        public int Id { get; set; }
        public string VehicleTypeName { get; set; }

        public virtual ICollection<TblVehicle> TblVehicles { get; set; }
    }
}
