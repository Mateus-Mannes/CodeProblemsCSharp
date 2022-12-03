using System;
using System.Collections.Generic;
using System.Linq;

namespace LikedLists;

public class llist : IEquatable<llist> {
    public int value {get; set;}
    public llist? next {get; set;}

    public bool Equals(llist? other)
    {
        this.
        throw new NotImplementedException();
    }
}

public static class Intersection {
    // 
    public static LinkedListNode<int> Run(llist list1, llist list2){
        var hashOfPointers = new HashSet<llist>();
        var ptr = list1.First;
        while(ptr != null) {
            hashOfPointers.Add(ptr);
            ptr = ptr.Next;
        }
        
        ptr = list2.First;
        while(ptr != null) {
            if(hashOfPointers.Contains(ptr)){
                return ptr;
            }
            ptr = ptr.Next;
        }

        return null;
    }

}