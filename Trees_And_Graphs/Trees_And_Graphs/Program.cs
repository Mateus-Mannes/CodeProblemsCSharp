using Trees_And_Graphs;

//Graph graph = new Graph();

//Node node0 = new Node(0);
//Node node1 = new Node(1);
//Node node2 = new Node(2);
//Node node3 = new Node(3);
//Node node4 = new Node(4);
//Node node5 = new Node(5);

//graph.Nodes = new List<Node>() { node0, node1, node2, node3, node4, node5 };


//node0.Children.Add(node1);
//node0.Children.Add(node4);
//node0.Children.Add(node5);

//node1.Children.Add(node3);
//node1.Children.Add(node4);

//node2.Children.Add(node1);

//node3.Children.Add(node2);
//node3.Children.Add(node4);

//Console.WriteLine(Route_Between_Nodes.Run(graph, node4, node3));

List<Node> nodes = new List<Node>();
for(int i = 0; i < 15; i++)
{
    nodes.Add(new Node(i));
}

var arr = nodes.ToArray();

arr[0].Children.AddRange(new List<Node>{ arr[1], arr[2]});
arr[1].Children.AddRange(new List<Node> { arr[3], arr[4] });
arr[2].Children.AddRange(new List<Node> { arr[5], arr[6] });
arr[3].Children.AddRange(new List<Node> { arr[7], arr[8] });
arr[4].Children.AddRange(new List<Node> { arr[9], arr[10] });
arr[5].Children.AddRange(new List<Node> { arr[11], arr[12] });
arr[6].Children.AddRange(new List<Node> { arr[13], arr[14] });

var depths = ListOfDepths.Run(arr[0]);