// See https://aka.ms/new-console-template for more information
using Recursion;

Stack<int> stack = new Stack<int>();
for(int i = 1; i <= 10; i++)
{
    stack.Push(i);
}

Towers.MoveDisks(10, stack, new Stack<int>(), new Stack<int>());
