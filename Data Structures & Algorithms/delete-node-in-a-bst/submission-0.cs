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
    public TreeNode Min(TreeNode root)
    {
        TreeNode curr = root;
        while(curr != null && curr.left != null)
        {
            curr = curr.left;
            
        }
        return curr;
    }

    public TreeNode DeleteNode(TreeNode root, int key) {
        if(null == root) return null;

        if(root.val < key)
        {
            root.right = DeleteNode(root.right, key);
        }
        else if(root.val > key)
        {
            root.left = DeleteNode(root.left, key);
        }

        else
        {
            if(root.left == null) return root.right;
            else if (root.right == null) return root.left;
            else
            {
                TreeNode minNode = Min(root.right);
                root.val = minNode.val;
                root.right = DeleteNode(root.right, minNode.val);
            }
            
        }
        return root;
    }
}