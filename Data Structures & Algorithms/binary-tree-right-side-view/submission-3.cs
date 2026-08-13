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
    public List<int> RightSideView(TreeNode root) {
        List<int> returnList = new List<int>();
        DFS(root, 0, returnList);
        return returnList;
    }


    private void DFS(TreeNode node, int level, List<int> result) {
        if (node == null) return;
        if (level == result.Count) {
            result.Add(node.val);
        }
        DFS(node.right, level + 1, result);
        DFS(node.left, level + 1, result);
    }
}