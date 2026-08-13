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
    public List<List<int>> LevelOrder(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<List<int>> returnList = new List<List<int>>();
        if (root != null) q.Enqueue(root);
        

        while(q.Count > 0)
        {
            List<int> createList = new List<int>();
            int size = q.Count;
            for(int i =0; i < size; i++)
            {
                TreeNode temp = q.Dequeue();
                createList.Add(temp.val);
                if(temp.left != null) q.Enqueue(temp.left);
                if(temp.right != null) q.Enqueue(temp.right);
            }
            returnList.Add(createList);

        }
        return returnList;
        

    }
}
