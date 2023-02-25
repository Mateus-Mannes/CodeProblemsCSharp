using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class Permutation_Dups
    {
        public static List<string> GetPerm(string word)
        {
            var result = new List<string>();
            var map = MakeMap(word);
            GetPerm(map, "", word.Length, result);
            return result;
        }

        public static void GetPerm(Dictionary<char, int> map, string prefix, int remaining, List<string> result)
        {
            if(remaining == 0)
            {
                result.Add(prefix);
                return;
            }
            foreach(var pair in map)
            {
                int count = pair.Value;
                if(count > 0)
                {
                    map[pair.Key]--;
                    GetPerm(map, prefix + pair.Key, remaining - 1, result);
                    map[pair.Key]++;

                }
            }
        }
        
        public static Dictionary<char, int> MakeMap(string word)
        {
            var map = new Dictionary<char, int>();
            foreach(var c in word)
            {
                if (map.ContainsKey(c)) map[c]++;
                else map.Add(c, 1);
            }
            return map;
        }
    }
}
