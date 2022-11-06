using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace avtoriz
{
    class Loggeduser
    {
        public static string surname;
        public static string Login;
        public static AccessLevel AccessLevel;
    }
    public enum AccessLevel
    {
        Granted = 1,
        Denied = 0
            
    }

}
