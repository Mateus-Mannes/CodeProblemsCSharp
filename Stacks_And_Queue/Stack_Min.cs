namespace staks;

public struct StackNode {
    public int Value;
    public int MinOfSubStack;
}

// first
public class StackMin : Stack<StackNode> {

    private int? Minimum = null;

    public void MinPop() {
        if(Count == 0) return;
        Pop();
        if(Count == 0){
            Minimum = null; 
            return;
        }
        Minimum = Peek().MinOfSubStack;
    }

    public void MinPush(int value) {
        if(Minimum == null) {
            Minimum = value;
            Push(new StackNode() { Value = value, MinOfSubStack = value });
            return;
        }
        if(value < Minimum){
            Minimum = value;
            Push(new StackNode() { Value = value, MinOfSubStack = value });
            return;
        }
        int minOfSubStack = value < Peek().MinOfSubStack ? value : Peek().MinOfSubStack;
        Push(new StackNode() { Value = value, MinOfSubStack = minOfSubStack });
    }

    public int? Min() {
        if(Count == 0) return null;
        return Minimum;
    }
    
}

// second implementation, uses just the necessary memory
public class StackMin2 : Stack<int> {

    private Stack<int> MinimumHist = new Stack<int>();

    public void MinPop() {
        if(Count == 0) return;
        int poped = Peek();
        Pop();
        if(MinimumHist.Count != 0 && MinimumHist.Peek() == poped){
            MinimumHist.Pop();
        }
    }

    public void MinPush(int value) {
        if(MinimumHist.Count == 0 || value < MinimumHist.Peek()){
            MinimumHist.Push(value);
        }
        Push(value);
    }

    public int? Min() {
        if(MinimumHist.Count == 0) return null;
        return MinimumHist.Peek();
    }
    
}