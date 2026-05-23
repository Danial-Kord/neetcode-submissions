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
    public int GoodNodes(TreeNode root) {
        Stack<(TreeNode t, int max)> stack = new ();
        if(root == null)
            return 0;
        stack.Push((root, root.val));

        int res = 0;
        while(stack.Count != 0){
            var (t, curMax) = stack.Pop();
            if(t.val >= curMax){
                res++;
                curMax = t.val;
            }
            if(t.left != null){
                stack.Push((t.left, curMax));
            }
            if(t.right != null){
                stack.Push((t.right, curMax));
            }
        }

        return res;   

    }
}
