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
        Stack<TreeNode> nodes = new Stack<TreeNode>();
        nodes.Push(root);
        while(nodes.Count != 0){
            TreeNode node = nodes.Pop();
            if(node == null)
                continue;
            TreeNode temp = node.left;
            TreeNode right = node.right;
            node.left = right;
            node.right = temp;
            if(temp != null)
                nodes.Push(temp);
            if(right != null)
                nodes.Push(right);
        }
        return root;
    }
}
