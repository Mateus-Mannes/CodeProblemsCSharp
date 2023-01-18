using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Manipulation
{
    public static class Parwise_Swap
    {
        public static void Run(int number)
        {
            PrintBits.Print(number);
            int even = 178956970;
            int odd = 89478485;
            int left = (number & odd) << 1;
            int right = (number & even) >> 1;
            PrintBits.Print(left | right);
        }
    }
}
