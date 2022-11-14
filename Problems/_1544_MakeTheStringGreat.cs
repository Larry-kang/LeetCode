namespace LeetCode.Problems
{
    internal class _1544_MakeTheStringGreat
    {
        public static string MakeGood(string s)
        {
            #region v1
            //int a = 0;
            //while (a + 1 < s.Length)
            //{
            //    if (s.Length == 1 || s == "")
            //    {
            //        return s;
            //    }
            //    string checkstr = s[a].ToString();
            //    if (checkstr != s[a + 1].ToString())
            //    {
            //        if (checkstr == s[a + 1].ToString().ToLower() || checkstr == s[a + 1].ToString().ToUpper())
            //        {
            //            s = s.Remove(a, 2);
            //            s = MakeGood(s);
            //        }
            //    }
            //    a++;
            //}
            //return s;
            #endregion
            #region v2
            //if (s.Length == 1 || s == "")
            //{
            //    return s;
            //}
            //int a = 0;
            //while (a + 1 < s.Length)
            //{
            //    if (s.Length == 1 || s == "")
            //    {
            //        return s;
            //    }
            //    bool cut = false;
            //    if (s[a].ToString() != s[a + 1].ToString() && s[a].ToString() == s[a + 1].ToString().ToLower())
            //    {
            //        cut = true;
            //    }
            //    if (s[a].ToString() != s[a + 1].ToString() && s[a].ToString() == s[a + 1].ToString().ToUpper())
            //    {
            //        cut = true;
            //    }
            //    if (cut)
            //    {
            //        s = s.Remove(a, 2);
            //        a = 0;
            //    }
            //    else
            //    {
            //        a++;
            //    }
            //}
            //return s;
            #endregion
            #region v3
            //if (s.Length == 1 || s == "")
            //{
            //    return s;
            //}
            //int a = 0;
            //while (a + 1 < s.Length)
            //{
            //    if (s.Length == 1 || s == "")
            //    {
            //        return s;
            //    }
            //    if(s[a].ToString() == s[a + 1].ToString())
            //    {
            //        goto golable;
            //    }
            //    if (s[a].ToString() != s[a + 1].ToString() && s[a].ToString() == s[a + 1].ToString().ToLower())
            //    {
            //        goto cutlable;
            //    }
            //    if (s[a].ToString() != s[a + 1].ToString() && s[a].ToString() == s[a + 1].ToString().ToUpper())
            //    {
            //        goto cutlable;
            //    }
            //    golable:
            //        a++;
            //        continue;
            //    cutlable:
            //        s = s.Remove(a, 2);
            //        a = 0;
            //}
            //return s;
            #endregion
            #region v4
            if (chklength(s))
            {
                goto returnLable;
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
                goto goLable;
            }
            if (s[a].ToString() != s[a + 1].ToString() && s[a].ToString() == s[a + 1].ToString().ToLower())
            {
                goto cutLable;
            }
            if (s[a].ToString() != s[a + 1].ToString() && s[a].ToString() == s[a + 1].ToString().ToUpper())
            {
                goto cutLable;
            }
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
        }
        public static bool chklength(string s)
        {           
            return string.IsNullOrWhiteSpace(s);
        }
    }
}
