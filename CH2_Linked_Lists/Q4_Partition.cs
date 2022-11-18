
using System.Collections.Generic;
namespace LikedLists;

public static class Partition {
    //
    public static void Run(LinkedList<int> list, int value){
        var ptr1 = list.First;

        var ptr2 = list.First;
        while(ptr2.Next != null) ptr2 = ptr2.Next;

        while(ptr1 != ptr2){
            if(ptr1.Value >= value){
                BackToLower(ref ptr2, value, ptr1);
                ChangeValues(ptr1, ptr2);
            }
            if(ptr1 != ptr2) ptr1 = ptr1.Next;
        }
    }

    public static void BackToLower(ref LinkedListNode<int> ptr, int value, LinkedListNode<int> ptrLimit) {
        while(ptr.Value >= value && ptr.Previous != null && ptr != ptrLimit) {
            ptr = ptr.Previous;
        }
    }

    public static void ChangeValues(LinkedListNode<int> ptr1, LinkedListNode<int> ptr2){
        int temp = ptr1.Value;
        ptr1.Value = ptr2.Value;
        ptr2.Value = temp;
    }
}