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
    public List<int> InorderTraversal(TreeNode root) {
        
        List<int> trList = new List<int>();

        Traverse(trList, root);

        return trList;
        
    }

    public void Traverse(List<int> trList, TreeNode root){
        if (root == null){
            return;
        }

        Traverse(trList, root.left);
        trList.Add(root.val);
        Traverse(trList, root.right);

    }
}