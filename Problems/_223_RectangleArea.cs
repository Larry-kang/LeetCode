using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class _223_RectangleArea
    {
        public static int ComputeArea(int ax1, int ay1, int ax2, int ay2, int bx1, int by1, int bx2, int by2)
        {
            #region v1
            //int a; int b; int c;

            //a = (ax2 - ax1) * (ay2 - ay1);
            //b = (bx2 - bx1) * (by2 - by1);

            //int cx = Math.Max(Math.Min(ax2, bx2) - Math.Max(ax1, bx1),0);
            //int cy = Math.Max(Math.Min(ay2, by2) - Math.Max(ay1, by1),0);

            //c = cx * cy;

            //return a + b - c;
            #endregion
            #region v2
            return ((ax2 - ax1) * (ay2 - ay1)) + ((bx2 - bx1) * (by2 - by1)) - ((Math.Max(Math.Min(ax2, bx2) - Math.Max(ax1, bx1), 0)) * (Math.Max(Math.Min(ay2, by2) - Math.Max(ay1, by1), 0)));
            #endregion
        }
    }
}
