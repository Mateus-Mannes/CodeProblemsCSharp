namespace staks;
using System.Collections.Generic;

public class SetOfStacks {
    private readonly int Capacity;
    public Stack<Stack<int>> Set  { get; set; } = new Stack<Stack<int>>();
    public SetOfStacks(int capacity) {
        Capacity = capacity;
        Set.Push(new Stack<int>());
    }

    public void Pop() {
      if(Set.Peek().Count > 0) Set.Peek().Pop();
      if(Set.Peek().Count == 0 && Set.Count > 1){
        Set.Pop();
      }
    }

    public void Push(int value){
      if(Set.Peek().Count == Capacity){
        Set.Push(new Stack<int>());
      }
      Set.Peek().Push(value);
    }

    public void PopAt(int index) {
      Set.ElementAt(index).Pop();
    }
} 