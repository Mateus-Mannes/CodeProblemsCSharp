using Trees_And_Graphs;

List<Node> nodes = new List<Node>();
for (int i = 1; i <= 15; i++)
{
    nodes.Add(new Node(i));
}

var arr = nodes.ToArray();

arr[0].AddChildren(arr[1]);
arr[0].AddChildren(arr[2]);


arr[1].AddChildren(arr[3]);
arr[1].AddChildren(arr[4]);

arr[2].AddChildren(arr[5]);
arr[2].AddChildren(arr[6]);

arr[3].AddChildren(arr[7]);
arr[3].AddChildren(arr[8]);

arr[4].AddChildren(arr[9]);
arr[4].AddChildren(arr[10]);

arr[5].AddChildren(arr[11]);
arr[5].AddChildren(arr[12]);

arr[6].AddChildren(arr[13]);
arr[6].AddChildren(arr[14]);
