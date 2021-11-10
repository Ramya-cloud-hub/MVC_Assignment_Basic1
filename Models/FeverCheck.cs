using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC_Assignment_Basic.Models
{
    public static class FeverCheck
    {
        static int minFeverTemp = 37;

        public static string CheckForFever(int input)
        {
            string returnMsg = "Good you don't have fever!!!!!!";

            if (input >= minFeverTemp)
            {
                returnMsg = "HOOO You have fever please have more care!!!!!!!";
            }

            return returnMsg;
        }
    }
}
