using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_And_Graphs
{
    public static class MinimalTree
    {
        
        public static void Run(int[] array)
        {
            Graph graph = new Graph();
            var queue = new Queue<Tuple<int, int, Node>>();
            queue.Enqueue(new Tuple<int, int, Node> ( 0, array.Length - 1, null));
            while(queue.Count != 0)
            {
                var interval = queue.Dequeue();
                int middle = interval.Item1 + ((interval.Item2 - interval.Item1) / 2);
                var node = new Node(array[middle]);
                if ( interval.Item3 != null) interval.Item3.Children.Add(node);
                else graph.Nodes.Add(node);
                if (Math.Abs(interval.Item1 - interval.Item2) <= 1) continue;
                queue.Enqueue(new Tuple<int, int, Node>(interval.Item1, middle, node));
                queue.Enqueue(new Tuple<int, int, Node>(middle + 1, interval.Item2, node));
            }
            PrintTree(graph.Nodes.First());
        }

        public static void Run2(int[] array)
        {
            var head = BuildMinimalTree(0, array.Length - 1, array);
            PrintTree(head);
        }

        private static Node BuildMinimalTree(int ini, int fin, int[] array)
        {
            if (fin < ini) return null;
            int middle = ini + ((fin - ini) / 2);
            var node = new Node(array[middle]);
            var left = BuildMinimalTree(ini, middle - 1, array);
            if(left != null) node.Children.Add(left);
            var right = BuildMinimalTree(middle + 1, fin, array);
            if(right != null) node.Children.Add(right);
            return node;
        }

        private static void PrintTree(Node head)
        {
            var queue = new Queue<Node>();
            queue.Enqueue(head);
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                Console.WriteLine(node.Value);
                if (node.Children.FirstOrDefault() != null) queue.Enqueue(node.Children.FirstOrDefault());
                if(node.Children.Count == 2) queue.Enqueue(node.Children.LastOrDefault());
            }
        }

    }
}
