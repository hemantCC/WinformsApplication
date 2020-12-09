using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment.Entity.Entities.BusinessEntities
{
    public class ChangePasswordViewModel
    {
        public string Username { get; set; }
        public string CurentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
