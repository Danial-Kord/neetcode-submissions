public class MinStack {

    Stack<int> stack;
    Stack<int> minStack;
    public MinStack() {
        stack = new Stack<int>();
        minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        stack.Push(val);
        if(minStack.Count == 0){
            minStack.Push(val);
        }
        else{
            if(val <= minStack.Peek()){
                minStack.Push(val);
            }
        }
    }
    
    public void Pop() {
        if(stack.Peek() == minStack.Peek())
            minStack.Pop();
        stack.Pop();
    }
    
    public int Top() {
        return stack.Peek();
    }
    
    public int GetMin() {
            return minStack.Peek();
    }
}
