

namespace LeetCode.Problems
{
    internal static class _222_CountCompleteTreeNodes
    {
        #region v1
        public static int CountNodes(TreeNode root)
        {
            int val = 0;

            if (root != null)
            {
                val = root.val;
                
                root.left
            }
            return val;
        }
        public static void readval(TreeNode root, ref int val)
        {
            if (root == null)
            {
                return;
            }
            if(root.left != null)
            {
                val = root.val;
                readval(root.left, ref val);
            }
            
        }
        #endregion
    }
    internal class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
