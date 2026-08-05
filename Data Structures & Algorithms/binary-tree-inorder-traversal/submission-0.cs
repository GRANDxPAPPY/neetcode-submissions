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
    List<int> returnList = new List<int>();
    public List<int> InorderTraversal(TreeNode root) {
        if(root == null) return returnList;
        InorderTraversal(root.left);
        returnList.Add(root.val);
        InorderTraversal(root.right);
        
        return returnList;
    }
}