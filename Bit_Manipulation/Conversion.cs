using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Manipulation
{
    public static class Conversion
    {
        public static int Run(int n1, int n2)
        {
            int flips = 0;
            for(int i = 1 << 30; i > 0; i /= 2)
            {
                if( ((n1 & i) == 0) && ((n2 & i) > 0) || ((n1 & i) > 0) && ((n2 & i) == 0))
                    flips++;
            }
            return flips;
        }
    }
}
