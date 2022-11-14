namespace LeetCode.Problems
{
    internal class _1_Two_Sum{
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] ans = new int[2];

            for (int i = 0; i < nums.Length; i++)
            {
                ans[0] = i;
                for (int k = i + 1; k < nums.Length; k++)
                {
                    if ((nums[i] + nums[k]) == target)
                    {
                        ans[1] = k;
                        return ans;
                    }
                }
            }
            ans[0] = 0;
            ans[1] = 0;
            return ans;
        }
    }
}
