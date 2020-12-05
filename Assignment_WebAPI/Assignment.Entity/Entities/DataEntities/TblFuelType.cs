using System;
using System.Collections.Generic;

#nullable disable

namespace Assignment.Entity.Entities.DataEntities
{
    public partial class TblFuelType
    {
        public TblFuelType()
        {
            TblVehicles = new HashSet<TblVehicle>();
        }

        public int Id { get; set; }
        public string FuelTypeName { get; set; }

        public virtual ICollection<TblVehicle> TblVehicles { get; set; }
    }
}
