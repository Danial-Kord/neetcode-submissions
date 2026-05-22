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
    public TreeNode LowestCommonAncestor(TreeNode root, TreeNode p, TreeNode q) {
        Dictionary<TreeNode, TreeNode> toParent = new Dictionary<TreeNode, TreeNode>();
        Dictionary<TreeNode, int> pValues = new Dictionary<TreeNode, int>();
        Dictionary<TreeNode, int> qValues = new Dictionary<TreeNode, int>();

        Stack<TreeNode> stack = new Stack<TreeNode>();
        stack.Push(root);
        toParent[root] = null;
        bool foundP = false;
        bool foundQ = false;
        while(!foundP || !foundQ){
            TreeNode pop = stack.Pop();
            if(pop.Equals(p)){
                foundP = true;
            }
            if(pop.Equals(q)){
                foundQ = true;
            }
            if(pop.left != null){
                stack.Push(pop.left);
                toParent[pop.left] = pop;
            }
            if(pop.right != null){
                stack.Push(pop.right);
                toParent[pop.right] = pop;
            }
        }
        TreeNode temp = p;
        int counter = 0;
        while(temp != null){
            pValues[temp] = counter;
            temp = toParent[temp];
            counter++;
        }

        temp = q;
        counter = 0;
        while(temp != null){
            qValues[temp] = counter;
            temp = toParent[temp];
            counter++;
        }
        int minVal = int.MaxValue;
        TreeNode found = null;
        foreach(var t in pValues.Keys){
            if(qValues.ContainsKey(t)){
                int val = qValues[t] + pValues[t];
                if(val < minVal){
                    minVal = val;
                    found = t;
                }
            }    
        }

        return found;
    }
}
