using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class _263_UglyNumber
    {
        internal static bool isUgly(int n)
        {
            #region v1
            //if (n <= 0 || n >= int.MaxValue)
            //{
            //    return false;
            //}
            //if (n == 1)
            //{
            //    return true;
            //}
            //while (true)
            //{
            //    if (n % 2 == 0)
            //    {
            //        n = n / 2;
            //    }
            //    if (n % 3 == 0)
            //    {
            //        n = n / 3;
            //    }
            //    if (n % 5 == 0)
            //    {
            //        n = n / 5;
            //    }
            //    if (n == 1)
            //    {
            //        return true;
            //    }
            //    if (n % 2 != 0 && n % 3 != 0 && n % 5 != 0)
            //    {
            //        return false;
            //    }
            //}
            #endregion
            #region v2
            if (n == 0) return false;

            while (n % 2 == 0) n = n / 2;

            while (n % 3 == 0) n = n / 3;

            while (n % 5 == 0) n = n / 5;

            return n == 1;
            #endregion
        }
    }
}
