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
    public List<List<int>> LevelOrder(TreeNode root) {
        List<List<int>> bfs = new List<List<int>>();

        Queue<(TreeNode t, int level)> queue = new Queue<(TreeNode t, int level)>();
        queue.Enqueue((root,0));

        while(queue.Count != 0){
            (TreeNode t, int level) deq = queue.Dequeue();
            if(deq.t == null)
                continue;
            if(bfs.Count < deq.level+1){
                bfs.Add(new List<int>());
            }
            bfs[deq.level].Add(deq.t.val);

            queue.Enqueue((deq.t.left, deq.level+1));
            queue.Enqueue((deq.t.right, deq.level+1));
        }
        return bfs;
    }
}
