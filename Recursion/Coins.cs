using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class Coins
    {
        public static int GetWays(int n,int sum = 0, int coin = 0)
        {
            sum = sum + coin;
            Console.WriteLine($"sum = {sum} coin {coin}");
            if (sum > n) return 0;
            if (sum == n) return 1;
            int ways = 0;
            if (coin <= 1) ways += GetWays(n, sum, 1);
            if (coin <= 5) ways += GetWays(n, sum, 5);
            if (coin <= 10) ways += GetWays(n, sum, 10);
            if (coin <= 25) ways += GetWays(n, sum, 25);
            return ways;
        }
    }
}
