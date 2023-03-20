using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearching
{
    public static class Sorted_Search
    {
        public static int SortedSearch(List<int> list, int x)
        {
            if (list.ElementAt2(0) == x) return 0;
            int len = 1;
            while(list.ElementAt2(len) > 0 && list.ElementAt2(len) < x) len *= 2;
            return BinarySerch(list, len / 2, len, x);
        }

        public static int BinarySerch(List<int> list, int ini, int fin, int x)
        {
            if (ini > fin) return -1;
            int mid = (ini + fin) / 2;
            if (list.ElementAt(mid) > x || list.ElementAt(mid) == -1) 
                return BinarySerch(list, ini, mid -1, x);
            else if(list.ElementAt(mid) < x) 
                return BinarySerch(list, mid + 1, fin, x);
            else return mid;
        }

        public static int ElementAt2(this List<int> list, int x)
        {
            try
            {
                return list.ElementAt(x);
            }
            catch
            {
                return -1;
            }
        }
    }
}
