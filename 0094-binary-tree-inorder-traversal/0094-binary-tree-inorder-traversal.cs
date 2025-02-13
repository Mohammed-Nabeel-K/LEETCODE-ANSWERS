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
    public IList<int> InorderTraversal(TreeNode root) {
        IList<int> li = new List<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();

        if(root == null){
            return li;
        }

        TreeNode current = root;
        while(current != null || st.Count > 0){
            while(current != null){
                st.Push(current);
                current = current.left;

            }
            
            TreeNode n = st.Pop();
            li.Add(n.val);
            current = n.right;
        }
        return li;
    }
}