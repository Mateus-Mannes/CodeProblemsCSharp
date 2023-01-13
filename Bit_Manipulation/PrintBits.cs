using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Manipulation
{
    public static class PrintBits
    {
        public static void Print(int number)
        {
            for (int i = (1 << 30); i > 0; i /= 2)
            {
                Console.Write((number & i) > 0 ? "1" : "0");
            }
            Console.WriteLine();
        }

        
    }
}
