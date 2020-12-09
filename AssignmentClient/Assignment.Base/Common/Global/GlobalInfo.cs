using Assignment.Base.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Base.Common.Global
{
    public static class GlobalInfo
    {
        private static UserInfo currentUser;

        public static UserInfo CurrentUser
        {
            get { return currentUser; }
            set { currentUser = value; }
        }
    }
}
