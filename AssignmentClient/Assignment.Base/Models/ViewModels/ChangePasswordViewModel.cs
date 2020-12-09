using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Base.Models.ViewModels
{
    public class ChangePasswordViewModel
    {
        public string Username { get; set; }
        public string CurentPassword { get; set; }
        public string NewPassword { get; set; }
    }
}
