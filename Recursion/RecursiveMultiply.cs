using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class RecursiveMultiply
    {
        public static int Run(int smaller, int bigger)
        {
            if(smaller == 0) return 0;
            if (smaller == 1) return bigger;

            int s = smaller >>1;
            int halfProd = Run(s, bigger);

            if(smaller % 2 == 0)
            {
                return halfProd + halfProd;
            }else
            {
                return halfProd + halfProd + bigger;
            }
        }
    }
}
