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
    public bool IsBalanced(TreeNode root) {
        if(root == null) return true;

        int returnInt = Helper(root);
        if(returnInt == -1) return false;
        return true;
    }
    public int Helper(TreeNode root)
    {
        if (root == null) return 0;
        
        int lcount = Helper(root.left);
        if(lcount == -1) return -1;
        int rcount = Helper(root.right);
        if(rcount == -1) return -1;

        if(Math.Abs(lcount - rcount) > 1)
        {
            return -1;
        }
        return Math.Max(lcount,rcount) + 1;
    }
}
