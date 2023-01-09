using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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
        
        public Queue<Node> VisitLevel(Queue<Node> queue, int marker = 0)
        {
            Queue<Node> nextVisits = new Queue<Node>();

            while (queue.Count > 0)
            {
                Node node = queue.Dequeue();
                node.Visited = true;
                Console.WriteLine("Node " + node.Value);
                foreach (var child in node.Children)
                {
                    if (child.MarkedBy != null && child.MarkedBy != marker)
                    {
                        return null;
                    }
                    if (!child.Marked)
                    {
                        child.Marked = true;
                        child.MarkedBy = marker;
                        nextVisits.Enqueue(child);
                    }
                }
            }

            return nextVisits;
        }
    }

    public class Node : IEquatable<Node>
    {
        public int Value { get; set; }
        public List<Node> Children { get; set; } = new List<Node>();
        public bool Visited { get; set; }
        public int Dependencies { get; set; }
        public Node Parent { get; set; }
        public bool Marked { get; set; }
        public int? MarkedBy { get; set; } = null;
        public bool Intersection { get; set; }
        public void AddChildren(Node n)
        {
            Children.Add(n);
            n.Parent = this;
        }

        public Node(int value, List<Node> children)
        {
            Value = value;
            Children = children;
        }

        public Node(int value)
        {
            Value = value;
        }

        public bool Equals(Node? other)
        {
            return RuntimeHelpers.GetHashCode(this) == RuntimeHelpers.GetHashCode(other);
        }

        public override int GetHashCode()
        {
            return RuntimeHelpers.GetHashCode(this);
        }
    }
}
