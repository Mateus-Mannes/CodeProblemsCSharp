using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public static class Towers
    {
        public static void MoveDisks(int n, Stack<int> origin, Stack<int> buffer, Stack<int> dest)
        {
            if (n == 0) return;

            MoveDisks(n - 1, origin, dest, buffer);

            var top = origin.Pop();
            dest.Push(top);

            MoveDisks(n - 1, buffer, origin, dest);
        }
    }
}
