using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diyet_Deneme_DaLL.Entities
{
    public  class UserManager
    {
        private static User_currentUse;
        public static UserManager CurrentUse
        {
            get { return_currentUser}
            set { _currentUser=value; } 

        }
    }
}
