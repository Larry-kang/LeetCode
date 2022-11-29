using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode.Problems
{    
    internal class _2_AddTwoNumbers
    {
        public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            #region v1
            {
                //ListNode result = new ListNode();
                //string strL1 = "";
                //string strL2 = "";
                //string strL3 = "";
                //GetListNodeVal(l1, ref strL1);
                //GetListNodeVal(l2, ref strL2);
                //strL1 = ReverseByArray(strL1);
                //strL2 = ReverseByArray(strL2);
                //BigInteger L1 = 0;
                //BigInteger L2 = 0;
                //BigInteger L3 = 0;

                //BigInteger.TryParse(strL1, out L1);
                //BigInteger.TryParse(strL2, out L2);
                //L3 = L1 + L2;
                //strL3 = ReverseByArray(L3.ToString());

                //MakeListNode(ref result, strL3);

                //return result;
            }
            #endregion
            #region v2
            {
                ListNode resNode = new ListNode(0); //reslut
                ListNode temp = resNode;

                //兩節點相加
                int sum = 0;

                while (l1 != null || l2 != null)
                {
                    sum /= 10; //sum最多不超過10

                    if (l1 != null)
                    {
                        sum += l1.val;
                        l1 = l1.next; //換到下一個節點
                    }

                    if (l2 != null)
                    {
                        sum += l2.val;
                        l2 = l2.next;
                    }

                    temp.next = new ListNode(sum % 10); //判斷進位 0-9存進val
                    temp = temp.next;

                    //如果有進位就新增下一個節點 val=1
                    if (sum / 10 == 1)
                    {
                        temp.next = new ListNode(1);
                    }
                }

                return resNode.val == 0 ? resNode.next : resNode;
            }
            #endregion
        }

        public static void MakeListNode(ref ListNode listNode, string sb)
        {
            if (sb.Length > 0)
            {
                listNode.val = Convert.ToInt32(sb[0].ToString());
                listNode.next = new ListNode();
                sb = sb.Remove(0, 1);
                if (sb.Length > 0)
                {
                    ListNode next = new ListNode();
                    MakeListNode(ref next, sb);
                    listNode.next = next;
                }
            }
        }
        public static void GetListNodeVal(ListNode listNode, ref string sb)
        {
            sb = sb + listNode.val.ToString();
            if (listNode.next != null)
            {
                GetListNodeVal(listNode.next, ref sb);
            }
        }
        public static string ReverseByArray(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }
}
