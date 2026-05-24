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
    public int MaxPathSum(TreeNode root) {
        if(root == null)
            return 0;
        int maxVal = int.MinValue;
        Stack<TreeNode> stack = new();
        stack.Push(root);
        while(stack.Count != 0){
            TreeNode pop = stack.Pop();
            int lMax = Math.Max(MaxSubPath(pop.left), 0);
            int rMax = Math.Max(MaxSubPath(pop.right), 0);
            maxVal = Math.Max(maxVal, lMax + pop.val + rMax);
            if(pop.left != null)
                stack.Push(pop.left);
            if(pop.right != null)
                stack.Push(pop.right);
        }

        return maxVal;
    }

    public int MaxSubPath(TreeNode root){
        if(root == null)
            return 0;

        int r = MaxSubPath(root.right);
        int l = MaxSubPath(root.left);
        return Math.Max(Math.Max(r + root.val, l + root.val), root.val);
    }
}
