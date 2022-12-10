using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_And_Graphs
{
    public class Graph
    {
        public List<Node> Nodes { get; set; } = new List<Node>();

        public void BreadthFirstSearch(Node root)
        {
            Queue<Node> queue = new Queue<Node>();
            root.Marked = true;
            queue.Enqueue(root);

            while(queue.Count > 0)
                queue = VisitLevel(queue);
        }
        
        public Queue<Node> VisitLevel(Queue<Node> queue)
        {
            Queue<Node> nextVisits = new Queue<Node>();

            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                node.Visited = true;
                Console.WriteLine("Node " + node.Value);
                foreach (var child in node.Children)
                {
                    if (!child.Marked)
                    {
                        child.Marked = true;
                        nextVisits.Enqueue(child);
                    }
                }
            }

            return nextVisits;
        }
    }

    public class Node
    {
        public int Value { get; set; }
        public List<Node> Children { get; set; } = new List<Node>();
        public bool Visited { get; set; }
        public bool Marked { get; set; }

        public Node(int value, List<Node> children)
        {
            Value = value;
            Children = children;
        }

        public Node(int value)
        {
            Value = value;
        }
    }
}
