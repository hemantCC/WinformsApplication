using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Entity.Entities.BusinessEntities
{
    public class UserViewModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public DateTime? CreatedDate { get; set; } = DateTime.Today;
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
