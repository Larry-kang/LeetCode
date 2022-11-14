namespace LeetCode.Problems
{
    internal class _1047_RemoveAllAdjacentDuplicatesInString
    {
        public static string RemoveDuplicates(string s)
        {
            #region V1
            if (chklength(s))
            {
                goto returnLable;
            }

            if (s.Length % 2 == 0)
            {
                string strA = s.Substring(0, (s.Length / 2));
                string strB = s.Substring((s.Length / 2), (s.Length / 2));
                if (strA == Reverse(strB))
                {
                    s = "";
                    goto returnLable;
                }
            }

            int a = 0;

        ifLable:
            if (a + 1 < s.Length)
            {
                goto whileLable;
            }
            else
            {
                goto returnLable;
            }

        whileLable:
            if (chklength(s))
            {
                goto returnLable;
            }
            if (s[a].ToString() == s[a + 1].ToString())
            {
                goto cutLable;
            }
            goto goLable;

        goLable:
            a++;
            goto ifLable;
        cutLable:
            s = s.Remove(a, 2);
            a = 0;
            goto ifLable;
        returnLable:
            return s;
            #endregion
            #region V2



            #endregion
        }
        public static bool chklength(string s)
        {
            return string.IsNullOrWhiteSpace(s);
        }
        public static string Reverse(string text)
        {
            char[] charArray = text.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
