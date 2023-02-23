using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class Permutation_No_Dups
    {
        public static List<string> GetPermutations(string word)
        {
            if(word.Length == 1) return new List<string> { word };
            char lastChar = word.Last();
            var subPermutations = GetPermutations(word.Substring(0, word.Length - 1));
            var permutations = new List<string>();
            foreach(var permutation in subPermutations)
            {
                for(int i = 0; i <= permutation.Length; i++)
                {
                    permutations.Add(permutation.Insert(i, lastChar.ToString()));
                }
            }
            return permutations;
        }
    }
}
