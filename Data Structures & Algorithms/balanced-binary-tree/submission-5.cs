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
    public bool IsBalanced(TreeNode root) {
        if(root == null)
            return true;

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);

        while(stack.Count != 0){
        TreeNode node = stack.Pop();
        int left = Dfs(node.left);
        int right = Dfs(node.right);
        if(Math.Abs(left-right) > 1)
            return false;
        if(node.left!=null)
            stack.Push(node.left);
        if(node.right != null)
            stack.Push(node.right);
        }
        return true;
    }


    public int Dfs(TreeNode node){
        if(node == null)
            return 0;
        if(node.left == null && node.right == null){
            return 1;
        }
        return Math.Max(Dfs(node.left) , Dfs(node.right)) + 1;
    }
}
