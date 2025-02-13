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
    public IList<int> PreorderTraversal(TreeNode root) {
        IList<int> li = new List<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();
        if(root == null ){
            return li;
        }
        st.Push(root);
        while( st.Count > 0 ){
            TreeNode current = st.Pop();
            li.Add(current.val);

            
            if(current.right != null){
                st.Push(current.right);
            }
            if(current.left != null){
                st.Push(current.left);

            }
            
        }
        return li;
    }
}