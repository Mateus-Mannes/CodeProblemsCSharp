using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trees_And_Graphs
{
    public static class Build_Order
    {
        public static List<int> BuildOrder(List<KeyValuePair<Node, Node>> projects, List<Node> nodes) 
        {
            HashSet<Node> grapheds = new HashSet<Node>();
            var graph = new Graph();
            foreach(var x in projects)
            {
                if (!grapheds.Contains(x.Value))
                {
                    grapheds.Add(x.Value);
                    graph.Nodes.Add(x.Value);
                }
                if (!grapheds.Contains(x.Key))
                {
                    grapheds.Add(x.Key);
                    graph.Nodes.Add(x.Key);
                }
                x.Key.Children.Add(x.Value);
                x.Value.Dependencies++;
            }
            Queue<Node> buildQueue = new Queue<Node>();
            foreach(var node in graph.Nodes){
                if(node.Dependencies == 0)
                {
                    buildQueue.Enqueue(node);
                }
            }
            var buildOrder = new HashSet<int>();
            while(buildQueue.Count > 0)
            {
                var nodeToBuild = buildQueue.Dequeue();
                nodeToBuild.Visited = true;
                if (grapheds.Contains(nodeToBuild)) grapheds.Remove(nodeToBuild);
                if(!buildOrder.Contains(nodeToBuild.Value)) buildOrder.Add(nodeToBuild.Value);
                foreach(var nodeDependent in nodeToBuild.Children)
                {
                    nodeDependent.Dependencies--;
                    if(nodeDependent.Dependencies == 0)
                    {
                        buildQueue.Enqueue(nodeDependent);
                    }
                }
            }
            var order = buildOrder.ToList();
            foreach (var node in nodes)
            {
                if (!buildOrder.Contains(node.Value))
                {
                    order.Insert(0,node.Value);
                }
            }
            if (grapheds.Count > 0) throw new Exception("no possible build order");
            return order;
        }
    }
}
