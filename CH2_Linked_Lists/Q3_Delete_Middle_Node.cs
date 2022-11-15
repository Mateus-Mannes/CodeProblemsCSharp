using System.Collections.Generic;
using System.Linq;

namespace LikedLists;

public static class DeleteMiddleNode {
    // runs in O(N) time, 2N
    public static void Run(LinkedListNode<int> node){
      if(node == null || node.Next == null)
        throw new ArgumentException("Needs to be a middle node");

      var next = node.Next;
      node.Value = next.Value;
      node.Next = next.Next;
    }

}