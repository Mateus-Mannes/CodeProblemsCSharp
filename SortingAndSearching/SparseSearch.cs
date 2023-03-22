using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAndSearching
{
    public static class SparseSearch
    {
        public static int SparceSearch(List<string> list, string find)
        {
            int ini = 0;
            int fin = list.Count - 1;

            while(ini <= fin)
            {
                int mid = (ini + fin) / 2;
                if (list[mid] == string.Empty)
                {
                    int left = mid;
                    int right = mid;
                    while (((mid != left && mid != right) || mid == left && mid == right) && (left >= 0 || right < list.Count))
                    {
                        left--;
                        right++;
                        if (left >= 0 && list[left] != string.Empty) mid = left;
                        if (right < list.Count && list[right] != string.Empty) mid = right;
                    }
                    if (list[mid] == string.Empty) return -1;
                }

                if (string.Compare(find, list[mid]) > 0)
                {
                    ini = mid + 1;
                } else if(string.Compare(find, list[mid]) < 0)
                {
                    fin = mid - 1;
                } else
                {
                    return mid;
                }
            }

            return -1;
        }
    }
}
