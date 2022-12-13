using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class _907_SumofSubarrayMinimums
    {
        int[] ints;
        public int SumSubarrayMins(int[] arr)
        {
            int sum = 0;

            ints = arr;

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    sum += chkmin(i, j);
                }
            }

            return sum;
        }
        public int chkmin(int str, int end)
        {
            if(str == end)
            {
                return ints[str];
            }
            int minint = 30001;

            for (int i = str + 1; i <= end; i++)
            {
                if (ints[i] < minint)
                {
                    minint = ints[i];
                }
            }
            return minint;
        }
    }

}
