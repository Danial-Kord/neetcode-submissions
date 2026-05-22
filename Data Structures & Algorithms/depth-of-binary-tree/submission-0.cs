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
    public int MaxDepth(TreeNode root) {
        Stack<(TreeNode t, int depth)> stack = new Stack<(TreeNode t, int depth)>();
        int maxDepth = 0;
        if(root == null)
            return maxDepth;
        stack.Push((root, 1));

        while(stack.Count != 0){
            (TreeNode t, int depth) pop = stack.Pop();
            int currentDepth = pop.depth;
            maxDepth = Math.Max(currentDepth, maxDepth);
            if(pop.t.left != null){
                stack.Push((pop.t.left, currentDepth+1));
            }
            if(pop.t.right != null){
                stack.Push((pop.t.right, currentDepth + 1));
            }
        } 
        return maxDepth;
    }
}
