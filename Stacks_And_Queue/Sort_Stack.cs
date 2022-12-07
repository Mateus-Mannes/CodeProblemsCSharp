namespace staks;

public static class SortStack {
    public static void Sort(Stack<int> stack) {
        var tempStack = new Stack<int>();

        int stackLen = stack.Count;
        for(int i = 0; i < stackLen; i++){
            if(i % 2 == 0){
                int biggest = MoveStack(stack, tempStack, (peek, bigest) => peek >= bigest);
                stack.Push(biggest);
            } 
            else{
                int smallest = MoveStack(tempStack, stack, (peek, smallest) => peek <= smallest);
                tempStack.Push(smallest);
            } 
        }

        while(tempStack.Count != 0){
            stack.Push(tempStack.Peek());
            tempStack.Pop();
        }

    }

    private static int MoveStack(Stack<int> from, Stack<int> to, Func<int, int, bool> comparision){
        int bound = 0;
        int until = to.Count == 0 ? 0 : to.Count - 1;
        bool first = true;
        while(from.Count != until){
            if(first){
                bound = from.Peek();
                first = false;
                from.Pop();
                continue;
            }
            if(comparision(from.Peek(), bound)) {
                to.Push(bound);
                bound = from.Peek();
            } else {
                to.Push(from.Peek());
            }
            from.Pop();
        }
        return bound;
    }
}