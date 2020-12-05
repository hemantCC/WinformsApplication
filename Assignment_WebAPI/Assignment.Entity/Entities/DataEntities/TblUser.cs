using System;
using System.Collections.Generic;

#nullable disable

namespace Assignment.Entity.Entities.DataEntities
{
    public partial class TblUser
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string Password { get; set; }
        public int? RoleId { get; set; }

        public virtual TblRole Role { get; set; }
    }
}
