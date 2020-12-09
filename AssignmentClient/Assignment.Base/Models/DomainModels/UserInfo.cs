using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Base.Models.ViewModels
{
    public class UserInfo
    {
        private string _role;

        public string Role
        {
            get { return _role; }
        }

        private string _userName;

        public string UserName
        {
            get { return _userName; }
        }

        public UserInfo(string role, string userName)
        {
            this._role = role;
            this._userName = userName;
        }
    }
}
