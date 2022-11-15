using LikedLists;

var list = new LinkedList<int>(new List<int>(){ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 12, 22, 32 });
DeleteMiddleNode.Run(list.First.Next.Next);
foreach(var element in list) Console.Write(element + " ");
