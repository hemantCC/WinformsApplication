using System;
using System.Collections.Generic;

#nullable disable

namespace Assignment.Entity.Entities.DataEntities
{
    public partial class TblTransmissionType
    {
        public TblTransmissionType()
        {
            TblVehicles = new HashSet<TblVehicle>();
        }

        public int Id { get; set; }
        public string TransmissionName { get; set; }

        public virtual ICollection<TblVehicle> TblVehicles { get; set; }
    }
}
