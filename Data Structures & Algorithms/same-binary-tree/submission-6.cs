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
    public bool IsSameTree(TreeNode p, TreeNode q) {
        Stack<TreeNode> s1 = new Stack<TreeNode>();
        Stack<TreeNode> s2 = new Stack<TreeNode>();

        if(p == null && q == null)
            return true;

        if(p == null || q == null){
            if(p != null)
                return false;
            if(q != null)
                return false;
        }
        s1.Push(p);
        s2.Push(q);

        while(s1.Count != 0 && s2.Count != 0){
            TreeNode t1 = s1.Pop();
            TreeNode t2 = s2.Pop();
            if(t1 == null || t2 == null){
                    return false;
            }
            if(t1.val.Equals(t2.val)){
                if(t1.left != null || t2.left != null){
                    s1.Push(t1.left);
                    s2.Push(t2.left);
                }
                if(t1.right!=null || t2.right != null){
                    s1.Push(t1.right);
                    s2.Push(t2.right);
                }
            }
            else{
                return false;
            }
        }
        return s1.Count == s2.Count;
    }
}
