using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{
    internal class _766_Toeplitz_Matrix
    {
        public bool IsToeplitzMatrix(int[][] matrix)
        {
            bool flag = true;

            for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            {
                if (!flag)
                    break;
                for (int j = 0; j <= matrix[i].GetLength(0); j++)
                {
                    if (!flag)
                        break;
                    if (check(i, j, matrix))
                    {
                        flag = true;
                    }
                    else
                    {
                        flag = false;
                    }
                }
            }
            #region 讀出全部的方法
            ////讀出全部
            //for (int i = 0; i <= matrix.GetLength(0) - 1; i++)
            //{
            //    for (int j = 0; j <= matrix[i].GetLength(0) - 1; j++)
            //    {
            //        Console.WriteLine(matrix[i][j].ToString());
            //    }
            //}
            #endregion

            return flag;
        }
        public bool check(int a, int b, int[][] matrix)
        {
            bool flag = true;

            int level = matrix.GetLength(0);

            if (a + 1 < level)
            {
                int levelLength = matrix[a].GetLength(0);
                if (b + 1 <= levelLength)
                {
                    int numA = matrix[a][b];
                    int numB;

                    if (a + 1 < matrix.GetLength(0))
                    {
                        if (b + 1 < matrix[a + 1].GetLength(0))
                        {
                            numB = matrix[a + 1][b + 1];
                            if (numA == numB)
                            {
                                if (check(a + 1, b + 1, matrix))
                                {
                                    flag = true;
                                }
                                else
                                {
                                    flag = false;
                                }
                            }
                            else
                            {
                                flag = false;
                            }
                        }
                    }
                }
            }
            return flag;
        }
    }
}
