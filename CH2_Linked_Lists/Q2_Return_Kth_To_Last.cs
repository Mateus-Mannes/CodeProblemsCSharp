using System.Collections.Generic;
using System.Linq;

namespace LikedLists;

public static class ReturnKthToLast {
    // runs in O(N) time, 2N
    public static void Run(LinkedList<int> list, int lastIndex){
        var count = list.Count();
        var index = count - lastIndex + 1;
        int interation = 1;
        foreach (var item in list)
        {
            if(interation == index) {
                Console.WriteLine(item);
                return;
            } 
            interation++;
        }
    }

    // runs in O(N) time, better
    public static void Run2(LinkedList<int> list, int lastIndex){
        GetByLastIndex(list.First, ref lastIndex);
    }

    public static void GetByLastIndex(LinkedListNode<int> node, ref int lastIndex) {
        if(node.Next != null) {
            GetByLastIndex(node.Next, ref lastIndex);
        }
        lastIndex--;
        if(lastIndex == 0) Console.WriteLine(node.Value);
    }

}