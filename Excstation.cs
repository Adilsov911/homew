using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp26
{
    public static class Excstation
    {
        public static bool ChekNotRobotCode(this string notRobotCode)
        {
            if (notRobotCode.Length == 4)
            {
                return true;
            }
            else
            {
                return false;
            }
        
          
        }

    }
}
