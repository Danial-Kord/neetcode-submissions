/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */

public class Solution {
    public bool IsValidBST(TreeNode root) {
        if(root == null)
            return true;    

        int prev = int.MinValue;
        HashSet<TreeNode> explored = new HashSet<TreeNode>();
        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count != 0){
            TreeNode pop = stack.Pop();
            if(explored.Contains(pop)){
                Console.WriteLine(pop.val);
                if(prev < pop.val)
                    prev = pop.val;
                else
                    return false;
            }
            else{
                if(pop.right != null)
                    stack.Push(pop.right);
                stack.Push(pop);
                if(pop.left != null)
                    stack.Push(pop.left);
                explored.Add(pop);
            }
        }
        return true;
    }
}
