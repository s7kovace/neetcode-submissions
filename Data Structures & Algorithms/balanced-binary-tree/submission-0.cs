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

        return Height(root)[0] == 1; //1 being true in this case.
        
    }

    public int[] Height(TreeNode root){ //Height will be calculated [0,0] first index true/false, second index height
        if (root == null) return new int[]{1, 0};

        var left = Height(root.left);
        var right = Height(root.right);

        var balanced = (left[0] == 1 && right[0] == 1) && 
        (Math.Abs(left[1] - right[1]) <= 1);
        var height = 1 + Math.Max(left[1], right[1]);

        return new int[]{balanced ? 1 : 0, height};

    }
}
