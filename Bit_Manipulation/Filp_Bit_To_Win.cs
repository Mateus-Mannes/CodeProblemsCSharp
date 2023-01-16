using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Manipulation
{
    public static class Filp_Bit_To_Win
    {
        public static int Run(int number)
        {
            int biggerSequence = 0;
            int left = 0;
            int sum = 0;
            for (int i = 1 << 30; i > 0; i /= 2)
            {
                if((number & i) > 0)
                {
                    sum++;
                }
                else
                {
                    if (left == 0) left = sum;
                    else
                    {
                        if((left + sum + 1) > biggerSequence) biggerSequence = (left + sum + 1);
                        left = sum;
                    }
                    sum = 0;
                }
                
            }
            if ((left + sum + 1) > biggerSequence) biggerSequence = (left + sum + 1);
            return biggerSequence;
        }
    }
}
