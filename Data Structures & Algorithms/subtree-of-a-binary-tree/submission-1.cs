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
    public bool IsSubtree(TreeNode root, TreeNode subRoot) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        if(root == null){
            return subRoot == null;
        }

        stack.Push(root);

        while(stack.Count != 0){
            TreeNode pop = stack.Pop();
            if(pop == null)
                continue;
            if(SameTree(pop, subRoot)){
                return true;
            }
            stack.Push(pop.left);
            stack.Push(pop.right);
        }
        return false;
    }

    public bool SameTree(TreeNode t1, TreeNode t2){
        if(t1 == null || t2 == null){
            if(t1 == null && t2 == null)
                return true;
            return false;
        }
        if(t1.val != t2.val)
            return false;
        return SameTree(t1.left, t2.left) && SameTree(t1.right, t2.right);
    }
}
