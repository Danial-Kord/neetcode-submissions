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
    public List<int> RightSideView(TreeNode root) {
        Queue<(TreeNode t, int level)> queue = new ();
        List<int> final = new ();
        if(root == null)
            return final;
        queue.Enqueue((root, 0));

        while(queue.Count != 0){
            var (t, curLevel) = queue.Dequeue();
            if(curLevel == final.Count){
                final.Add(t.val);
            }
            if(t.right != null){
                queue.Enqueue((t.right, curLevel + 1));
            }
            if(t.left != null){
                queue.Enqueue((t.left, curLevel + 1));
            }
        }
        return final;
    }
}
