using System;
using System.Collections.Generic;
using System.Text;

namespace LinearList.链表
{

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        /// <summary>
        /// 单向链表—完全反转
        /// </summary>
        /// <param name="head">头结点</param>
        /// <returns></returns>
        public static ListNode ReverseList(ListNode head)
        {
            //作为临时变量存储当前节点
            ListNode pre = null;
            ListNode cur = head;
            while (cur != null)
            {
                //下一节点
                ListNode next = cur.next;
                //第一个节点反转为最后一个节点，指向null
                //当前节点赋值为 上一次循环中的临时存储(当前节点反转后的结果) 
                cur.next = pre;
                //临时存储 当前节点反转后的结果
                pre = cur;
                //当前节点为下一节点
                cur = next;
            }
            return pre;
        }


        /// <summary>
        /// 单向链表——按k个元素分组，每组反转，k为可以被n整除的正整数
        /// </summary>
        /// <param name="head">头结点</param>
        /// <param name="k">k为可以被n整除的正整数</param>
        /// <returns></returns>
        public static ListNode ReverseList(ListNode head, int k)
        {
            ListNode hh = new ListNode(0);
            hh.next = head; //头节点的前一个结点

            //遍历出长度l，l/k=匹配组数 n
            int l = 0;
            while (head != null)
            {
                l++;
                head = head.next;
            }

            head = hh.next;


            int n = l / k;


            ListNode pre = null;
            ListNode cur = head;
            //遍历组数n
            for (int i = 1; i <= n; i++)
            {
                //遍历每组节点，每组有k个节点
                for (int j = 1; j <= k; j++)
                {
                    ListNode next = cur.next;
                    cur.next = pre;
                    pre = cur;
                    cur = next;
                    ListNode.Write(pre);
                }

            }
            ListNode.Write(pre);
            ListNode.Write(cur);
            return null;
        }


        /// <summary>
        /// 输出链表
        /// </summary>
        /// <param name="head">头结点</param>
        public static void Write(ListNode head)
        {
            StringBuilder sb = new StringBuilder();
            while (head != null)
            {
                sb.Append($"{head.val}->");
                var temp = head.next;
                head = temp;
            }
            Console.WriteLine(sb.ToString().TrimEnd('-', '>'));
        }
    }


}
