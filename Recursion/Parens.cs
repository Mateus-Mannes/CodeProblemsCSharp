using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class Parens
    {
        public static List<string> GetParens(int count)
        {
            if (count == 1) return new List<string>() { "()" };
            var subCombinations = GetParens(count - 1);
            var combinations = new List<string>();
            foreach(var combination in subCombinations)
            {
                combinations.Add("(" + combination + ")");
                combinations.Add("()" + combination);
                if(!combination.HasNoIn()) combinations.Add(combination + "()");
            }
            return combinations;
        }

        public static bool HasNoIn(this string parensSequence)
        {
            for(int i = 0; i < parensSequence.Length; i++)
            {
                if (i % 2 == 0 && parensSequence[i] != '(') return false;
                if (i % 2 != 0 && parensSequence[i] != ')') return false;
            }
            return true;
        }
    }
}
