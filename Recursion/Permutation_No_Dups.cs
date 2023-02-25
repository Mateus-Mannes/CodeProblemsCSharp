using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class Permutation_No_Dups
    {
        public static HashSet<char> chars = new HashSet<char>();

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

        public static List<string> GetPermutationsDups(string word)
        {
            if (word.Length == 1) return new List<string> { word };
            char lastChar = word.Last();
            var subPermutations = GetPermutationsDups(word.Substring(0, word.Length - 1));
            var permutations = new List<string>();
            foreach (var permutation in subPermutations)
            {
                for (int i = 0; i <= permutation.Length; i++)
                {
                    string newWord = permutation.Insert(i, lastChar.ToString());
                    if (permutations.Count > 0 && permutations.Last() == newWord) continue;
                    permutations.Add(newWord);
                }
            }
            return permutations;
        }
    }
}
