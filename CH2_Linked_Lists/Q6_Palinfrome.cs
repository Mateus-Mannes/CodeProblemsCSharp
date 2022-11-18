using System.Collections.Generic;
using System.Linq;

namespace LikedLists;

public static class Palindrome {
    // 
    public static bool Run(LinkedList<int> list){
      var ptr1 = list.First;

        var ptr2 = list.First;
        while(ptr2.Next != null) ptr2 = ptr2.Next;

        while(ptr1 != ptr2){
            if(ptr1.Value != ptr2.Value) return false;
            ptr1 = ptr1.Next;
            if(ptr1 != ptr2) ptr2 = ptr2.Previous;
        }
        return true;
    }

}