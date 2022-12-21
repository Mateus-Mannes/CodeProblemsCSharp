

namespace Trees_And_Graphs
{
    public static class Route_Between_Nodes
    {
        public static bool Run(Graph graph, Node n1, Node n2)
        {
            var q1 = new Queue<Node>();
            q1.Enqueue(n1);

            var q2 = new Queue<Node>();
            q2.Enqueue(n2);

            while(q1.Count != 0 && q2.Count != 0)
            {
                q1 = graph.VisitLevel(q1, 1);
                q2 = graph.VisitLevel(q2, 2);

                if (q2 == null) return true;
                
            }

            return false;
        }
    }
}
