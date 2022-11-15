

using Microsoft.VisualBasic;

namespace LeetCode.Problems
{
    internal static class _222_CountCompleteTreeNodes
    {
        public static string[] strings = new string[0];
        #region v1
        //public static int CountNodes(TreeNode root)
        //{
        //    if(root == null)
        //    {
        //        return 0;
        //    }
        //    return CountNodes(root.left) + CountNodes(root.right) + 1;            
        //}
        #endregion
        #region v2
        public static int CountNodes(TreeNode root)
         {
            if (root == null)
            {
                return 0;
            }

            recursivePreorder(root);

            return strings.Length;
        }
        #endregion

        public static void recursivePreorder(TreeNode root)
        {
            //Console.Write(root.val.ToString());

            Array.Resize(ref strings, strings.Length + 1);

            strings[strings.Length - 1] = root.val.ToString();

            if (root.left != null)
            {
                recursivePreorder(root.left);
            }
            if (root.right != null)
            {   
                recursivePreorder(root.right);
            }
        }
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
