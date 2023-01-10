using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_And_Graphs
{
    public static class Paths_With_Sum
    {

        public static int Run2(Node head, int value)
        {
            return countPathsWithSum(head, value, 0, new Dictionary<int, int>());
        }

        private static int countPathsWithSum(Node node, int value, int runningSum, Dictionary<int, int> pathCount)
        {
            if (node == null) return 0;

            runningSum += node.Value;
            int sum = runningSum - value;
            int paths = pathCount.ContainsKey(sum) ? pathCount[sum] : 0;
            if(runningSum == value)
            {
                paths++;
            }

            IncrementHashTable(pathCount, runningSum, 1);
            paths += countPathsWithSum(node.Children.FirstOrDefault(), value, runningSum, pathCount);
            paths += node.Children.Count > 1 ? countPathsWithSum(node.Children.LastOrDefault(), value, runningSum, pathCount) : 0;
            IncrementHashTable(pathCount, runningSum, -1);

            return paths;
        }

        private static void IncrementHashTable(Dictionary<int, int> pathCount, int key,int delta)
        {
            var newCount = pathCount.ContainsKey(key) ? pathCount[key] + delta : delta;
            if(newCount == 0)
            {
                pathCount.Remove(key);
            } else
            {
                if(pathCount.ContainsKey(key)) pathCount[key] += delta;
                else pathCount.Add(key, newCount);
            }
        }

        public static int Run(Node head, int value)
        {
            return NumberOfSumPathsUntilHead(head, value);
        }

        private static int NumberOfSumPathsUntilHead(Node node, int value)
        {
            if (node == null) return 0;
            int sumPaths = SumPathsUntilHead(node, value);
            sumPaths += NumberOfSumPathsUntilHead(node.Children.FirstOrDefault(), value);
            if(node.Children.Count > 1) sumPaths += NumberOfSumPathsUntilHead(node.Children.LastOrDefault(), value);
            return sumPaths;
        }

        private static int SumPathsUntilHead(Node node, int value)
        {
            if (node == null) return 0;
            int qtd = 0;
            int sum = 0;
            do
            {
                sum += node.Value;
                if(sum == value) qtd++;
                node = node.Parent;
            } while (node != null);
            return qtd;
        }
    }
}
