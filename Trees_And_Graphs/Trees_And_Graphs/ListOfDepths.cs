using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_And_Graphs
{
    public static class ListOfDepths
    {
        public static List<List<Node>> Run(Node head)
        {
            var queue = new Queue<Tuple<int, Node>>();
            List<List<Node>> list = new List<List<Node>>();
            queue.Enqueue(new Tuple<int, Node>(0, head));
            while (queue.Count != 0)
            {
                var node = queue.Dequeue();
                if (list.ElementAtOrDefault(node.Item1) == null) list.Add(new List<Node>());
                list.ElementAtOrDefault(node.Item1).Add(node.Item2);
                if (node.Item2.Children.FirstOrDefault() != null) queue.Enqueue(new Tuple<int, Node>(node.Item1+1,node.Item2.Children.FirstOrDefault()));
                if (node.Item2.Children.Count == 2) queue.Enqueue(new Tuple<int, Node>(node.Item1+1 ,node.Item2.Children.LastOrDefault()));
            }
            return list;
        }
    }
}
