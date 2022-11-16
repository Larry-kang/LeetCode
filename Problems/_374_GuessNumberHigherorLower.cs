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
            int count = 1;
            if (n < 2)
            {
                return 1;
            }
            int a = 2;
            int guessInt = guess(a);
            if (guessInt == 0)
                return a;
            int b = 1;
            if (n % 2 == 0)
            {
                a = n / 2;
            }
            else
            {
                a = ((n - 1) / 2) + 1;
            }

            while (guessInt != 0)
            {
                count++;
                guessInt = guess(a);
                switch (guessInt)
                {
                    case -1:

                        break;
                    case 1:
                        break;
                }

            }
            return a;
        }

    }
}
