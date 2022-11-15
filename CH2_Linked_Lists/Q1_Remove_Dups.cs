using System.Collections.Generic;
using System.Linq;

namespace LikedLists;

public static class RemoveDups {
    // runs in O(n) using O(n) extra memory
    public static void Run(LinkedList<int> list){
        var buffer = new HashSet<int>();
        var node = list.First;
        while(node != null){
            var next = node.Next;
            if(buffer.Contains(node.Value)){
                list.Remove(node);
            } else {
                buffer.Add(node.Value);
            }
            node = next;
        }
        foreach(var element in list) Console.Write(element + " ");
    }

    // runs in O(n^2) without extra memory
    public static void Run2(LinkedList<int> list){
        var nodeInteration = list.First;
        var nodeSearch = list.First;
        while(nodeInteration != null){
            while(nodeSearch != null) {
                var nextSearch = nodeSearch.Next;
                if(nodeSearch != nodeInteration && nodeSearch.Value == nodeInteration.Value){
                    list.Remove(nodeSearch);
                }
                nodeSearch = nextSearch;
            }
            nodeInteration = nodeInteration.Next;
            nodeSearch = list.First;
        }
        foreach(var element in list) Console.Write(element + " ");
    }
}