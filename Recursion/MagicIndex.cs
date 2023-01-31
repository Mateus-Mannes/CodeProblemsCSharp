using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    public class MagicIndex
    {
        public static int Run(List<int> list, int ini, int end)
        {
            if (ini > end) return -1;
            int middle = (ini + end) / 2;

            if (middle == list[middle]) return middle;

            int leftIndex = Math.Min(list[middle], middle - 1);
            int left = Run(list, ini, leftIndex);
            if (left >= 0) return left;

            int rightIndex = Math.Max(list[middle], middle + 1);
            int right = Run(list, rightIndex, end);
            if (right >= 0) return right;

            return -1;
        }
    }
}
