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
    public TreeNode InvertTree(TreeNode root) {
        Queue<TreeNode> queue = new Queue<TreeNode>();

        if(root == null)
            return root;
        queue.Enqueue(root);

        while(queue.Count != 0){
            TreeNode dequeue = queue.Dequeue();
            TreeNode left = dequeue.left;
            TreeNode right = dequeue.right;
            if(left != null){
                queue.Enqueue(left);
            }
            if(right != null){
                queue.Enqueue(right);
            }
            dequeue.left = right;
            dequeue.right = left;
        }
        return root;
    }
}
