using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace letcodestudy
{
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

    public class AddTwoNumbers_Study
    {
        /// <summary>
        /// 输入：l1 = [2,4,3], l2 = [5,6,4] 输出：[7,0,8]
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode listNode = new ListNode();
            var curr = listNode;
            int carry = 0;
            while (l1 != null || l2 != null)
            {
                var l1value = l1 != null ? l1.val : 0;
                var l2value = l2 != null ? l2.val : 0;
                var sum = l1value + l2value + carry;
                carry = sum / 10;//进位数
                //new 节点
                curr.next = new ListNode(sum % 10);
                //链表后移
                curr = curr.next;
                if (l1 != null)
                {
                    l1 = l1.next;
                }
                if (l2 != null)
                {
                    l2 = l2.next;
                }
            }
            //最后一位能需进位，则新增节点
            if (carry == 1)
            {
                curr.next = new ListNode(carry);
            }
            return listNode.next;
        }

    }
}
