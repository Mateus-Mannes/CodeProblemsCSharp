using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit_Manipulation
{
    public static class Insertion
    {
        public static int Run(int N, int M, int j, int i)
        {
            PrintBits.Print(N);
            PrintBits.Print(M);
            int From_j_to_i_nuller = (~0 & ~0 << j + i) | (~0 ^ ~0 << i);
            PrintBits.Print(From_j_to_i_nuller);
            int N_Nulled = N & From_j_to_i_nuller;
            PrintBits.Print(N_Nulled);
            int result = N | (M << i);
            PrintBits.Print(result);
            return result;
        }


    }
}
