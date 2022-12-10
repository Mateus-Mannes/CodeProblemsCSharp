using Trees_And_Graphs;

Graph graph = new Graph();

Node node0 = new Node(0);
Node node1 = new Node(1);
Node node2 = new Node(2);
Node node3 = new Node(3);
Node node4 = new Node(4);
Node node5 = new Node(5);

graph.Nodes = new List<Node>() { node0, node1, node2, node3, node4, node5 };


node0.Children.Add(node1);
node0.Children.Add(node4);
node0.Children.Add(node5);

node1.Children.Add(node3);
node1.Children.Add(node4);

node2.Children.Add(node1);

node3.Children.Add(node2);
node3.Children.Add(node4);

graph.BreadthFirstSearch(node0);