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
   int count = 0;
    public int KthSmallest(TreeNode root, int k) {
        if(root == null) return 0;
        
        
        int left = Helper(root,k);
        
        return left;
        
    }
    public int Helper(TreeNode root,int k)
    {
        if(root == null) return 0;
        int r = Helper(root.left, k);
        if(r != 0) return r;
        else
        {
            count++;
            if(count == k) return root.val;
            return Helper(root.right,k);
        }

    }

   
}
