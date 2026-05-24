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
    public int KthSmallest(TreeNode root, int k) {
        int currentIndex = 0;
        if(root == null)
            return -1;
        
        Stack<TreeNode> stack = new Stack<TreeNode>();

        stack.Push(root);
        HashSet<TreeNode> explored = new ();

        while(stack.Count != 0){
            TreeNode pop = stack.Pop();
            if(explored.Contains(pop)){
                currentIndex++;
                if(currentIndex == k)
                    return pop.val;
            }
            else{
                if(pop.right != null)
                    stack.Push(pop.right);
                stack.Push(pop);
                if(pop.left != null)
                    stack.Push(pop.left);
                explored.Add(pop);
            }
        }
        return root.val;

    }
}
