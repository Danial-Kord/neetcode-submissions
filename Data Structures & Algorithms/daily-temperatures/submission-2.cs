public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        Stack<(int value, int index, int counter)> stack = new Stack<(int value, int index, int counter)>();

        int[] result = new int[temperatures.Length];

        (int value, int index, int counter) top = (temperatures[0], 0, 0);
        stack.Push(top);
        int index = 1;
        while(stack.Count != 0 && index < temperatures.Length){
            top = stack.Peek();
            int counter = 0;
            int deletedTillNow = top.counter;
            while(stack.Count != 0 && top.value < temperatures[index]){
                counter++;
                stack.Pop();
                result[top.index] = deletedTillNow - top.counter + counter;
                if(stack.Count != 0)
                    top = stack.Peek();
                }
            stack.Push((temperatures[index], index, deletedTillNow + counter));
            index += 1;
        }
        return result;
    }
}
