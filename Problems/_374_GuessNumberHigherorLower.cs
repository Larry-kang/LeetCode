using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class _374_GuessNumberHigherorLower
    {
        /** 
         * Forward declaration of guess API.
         * @param  num   your guess
         * @return 	     -1 if num is higher than the picked number
         *			      1 if num is lower than the picked number
         *               otherwise return 0
         * int guess(int num);
         */
        public static int guess(int num)
        {
            int pick = 6;
            int a = 0;
            if(num > pick)
            {
                a = -1;
            }
            if (num < pick)
            {
                a = 1;
            }
            if (num == pick)
            {
                a = 0;
            }
            return a;
        }
        public static int GuessNumber(int n)
        {
            #region v1
            //if (n < 2)
            //{
            //    return 1;
            //}
            //int a = n;
            //int b = 1;
            //int c;
            //int guessInt = guess(a);
            //if (guessInt != 0)
            //{
            //    guessInt = guess(b);
            //    if(guessInt == 0)
            //    {
            //        a = b;
            //    }
            //}

            //while (guessInt != 0)
            //{
            //    if ((a - b) % 2 == 0)
            //    {
            //        c = a - ((a - b) / 2);
            //    }
            //    else
            //    {
            //        c = a - (((a - b) + 1) / 2);
            //    }

            //    guessInt = guess(c);
            //    switch (guessInt)
            //    {
            //        case -1:
            //            a = c;
            //            break;
            //        case 1:
            //            b = c;
            //            break;
            //        case 0:
            //            a = c;
            //            break;
            //    }
            //}
            //return a;
            #endregion
            #region v2
            int low = 1;
            int high = n;
            int mid;
            int res;
            while (low <= high)
            {
                mid = low + (high - low) / 2;

                res = guess(mid);
                switch (res)
                {
                    case 0:
                        return mid;
                    case 1:
                        low = mid + 1;
                        break;
                    case -1:
                        high = mid - 1;
                        break;
                }
            }
            return -1;
            #endregion
        }

    }
}
