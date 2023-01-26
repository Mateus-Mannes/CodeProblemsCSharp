using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class Triple_step
    {
        public static Dictionary<int, int> memo = new Dictionary<int, int>();
        public static int Run(int rest)
        {
            if (rest == 0) return 1;
            if(memo.ContainsKey(rest)) return memo[rest];
            memo.Add(rest, TryAddNewWay(1, rest) + TryAddNewWay(2, rest) + TryAddNewWay(3, rest));
            return memo[rest];
        }

        private static int TryAddNewWay(int steps, int rest)
        {
            if (rest - steps >= 0)
                return Run( rest - steps);
            else return 0;
        }
    }
}
