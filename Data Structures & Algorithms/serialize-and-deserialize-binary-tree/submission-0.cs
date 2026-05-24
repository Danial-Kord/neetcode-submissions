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

public class Codec {

    // Encodes a tree to a single string.
    public string Serialize(TreeNode root) {
        StringBuilder s = new ();
        Queue<TreeNode> queue = new ();
        queue.Enqueue(root);

        while(queue.Count != 0){
            s.Append("-");
            TreeNode top = queue.Dequeue();
            if(top == null){
                s.Append("#");
                continue;
            }
            else
                s.Append($"{top.val}");
            queue.Enqueue(top.left);
            queue.Enqueue(top.right);
        }
        return s.ToString();
    }

    // Decodes your encoded data to tree.
    public TreeNode Deserialize(string data) {
        Console.WriteLine(data);
        string[] str = data.Split("-");

        if(str[1] == "#")
            return null;
        TreeNode root = new TreeNode(int.Parse(str[1]),null,null);
        Queue<TreeNode> queue = new ();
        queue.Enqueue(root);

        int index = 1;
        while(index < str.Length && queue.Count != 0){
            TreeNode top = queue.Dequeue();

            if(top == null)
                continue;
            Console.WriteLine(top.val);

            TreeNode left = null;
            TreeNode right = null;
            index++;

            if(index >= str.Length)
                break;
            Console.WriteLine(str[index]);
            
            if(str[index] != "#"){
                left = new TreeNode(int.Parse(str[index]), null, null);

            }

            index++;
            if(index >= str.Length)
                break;
            if(str[index] != "#"){
                right = new TreeNode(int.Parse(str[index]), null, null);
            }
            Console.WriteLine(str[index]);

            top.left = left;
            top.right = right;
            queue.Enqueue(left);
            queue.Enqueue(right);
        }
        return root;
    }
}
