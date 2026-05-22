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
    public int DiameterOfBinaryTree(TreeNode root) {
        Stack<TreeNode> stack = new Stack<TreeNode>();
        Dictionary<TreeNode, TreeNode> parent = new Dictionary<TreeNode, TreeNode>();
        Dictionary<TreeNode, int> map = new Dictionary<TreeNode, int>();


        if(root == null)
            return 0;

        stack.Push(root);
        parent[root] = null;
        map[root] = 0;
        int maxDim = 0;
        while(stack.Count != 0){
            TreeNode pop = stack.Pop();
            if(pop.left == null && pop.right == null){
                TreeNode temp = pop;
                int depthFromDown = 0;
                while(temp != null){
                    map[temp] = Math.Max(map[temp], depthFromDown);
                    int dim = GetDim(temp, map);
                    maxDim = Math.Max(maxDim, dim);
                    temp = parent[temp];
                    depthFromDown++;
                }
            }
            else{
                if(pop.left != null){
                    stack.Push(pop.left);
                    map[pop.left] = 0; 
                    parent[pop.left] = pop;
                }
                if(pop.right != null){
                    stack.Push(pop.right);
                    map[pop.right] = 0;
                    parent[pop.right] = pop;
                }
            }
        }
        return maxDim;
    }

    public int GetDim(TreeNode node, Dictionary<TreeNode, int> map){
        int dim = 0;
        if(node.left != null){
            dim += map[node.left] + 1;
        }
        if(node.right != null){
            dim += map[node.right] + 1;
        }
        return dim;
    }

}
