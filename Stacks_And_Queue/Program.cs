using staks;
// See https://aka.ms/new-console-template for more information
var s = new SetOfStacks(3);
s.Push(1);
s.Push(2);
s.Push(3);
s.Push(1);
s.Push(2);
s.Push(3);
s.Push(1);
s.Pop();
s.Pop();
s.Pop();
s.Pop();
s.Pop();
s.PopAt(0);