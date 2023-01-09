using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_And_Graphs
{
    public static class BTSSequence
    {
        public static List<List<int>> GetSequence(Node head)
        {
            if (head.Children.Count == 0) return new List<List<int>> { new List<int> { head.Value } };
            var left = head.Children.Count > 0 ? GetSequence(head.Children.First()) : null;
            var right = head.Children.Count > 1 ? GetSequence(head.Children.Last()) : null;
            List<List<int>> result = new List<List<int>>();
            foreach(var l in left)
            {
                foreach(var r in right)
                {
                    WaveLists(l, r, result, new List<int>() { head.Value });
                }
            }
            return result;
        }

        public static void WaveLists(List<int> first, List<int> second, List<List<int>> waved, List<int> prefix)
        {
            // if one of the lists if empty, append then to the prefix and add to result
            if(first.Count == 0 || second.Count == 0)
            {
                var result = prefix.ToList();
                result.AddRange(first);
                result.AddRange(second);
                waved.Add(result);
                return;
            }

            MoveItemFromFirstListToPrefixAndWave(first, second, waved, prefix);

            MoveItemFromFirstListToPrefixAndWave(second, first, waved, prefix);
        }

        public static void MoveItemFromFirstListToPrefixAndWave(List<int> first, List<int> second, List<List<int>> waved, List<int> prefix)
        {
            var firstListHead = first[0];
            first.RemoveAt(0);
            prefix.Add(firstListHead);
            WaveLists(first, second, waved, prefix);
            prefix.RemoveAt(prefix.Count - 1);
            first.Insert(0, firstListHead);
        }
    }
}
