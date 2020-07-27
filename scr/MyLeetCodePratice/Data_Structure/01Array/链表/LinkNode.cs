using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinearList.链表
{

    public class ListNode
    {
        public ListNode(int x) { val = x.ToString(); }
        public ListNode(string x) { val = x; }
        //public ListNode(params int[] arr)
        //{
        //    ListNode temp = new ListNode(arr[0]);
        //    ListNode head = new ListNode(arr[0]);
        //    head = temp;
        //    for (int i = 1; i < arr.Length; i++)
        //    {
        //        temp.next = new ListNode(arr[i]);
        //        temp = temp.next;
        //    }

        //}
        //public ListNode(params string[] arr)
        //{

        //}

        public string val;
        public ListNode next;

        /// <summary>
        /// 生成单向链表
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ListNode GetListNode(params int[] arr)
        {
            ListNode temp = new ListNode(arr[0]);
            //head 赋值为 temp 的指针（head 和 temp 指向同一对象）
            ListNode head = temp;
            for (int i = 1; i < arr.Length; i++)
            {
                //head 和 temp 指向同一对象 （temp 指向的对象的 .next 创建新的对象）
                head.next = new ListNode(arr[i]);
                //head 赋值为新的对象的指针（temp不变）
                head = head.next;
            }
            //head 循环后指向 null，temp为头结点
            return temp;
        }
        /// <summary>
        /// 生成单向链表
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ListNode GetListNode(params string[] arr)
        {
            ListNode temp = new ListNode(arr[0]);
            //head 赋值为 temp 的指针（head 和 temp 指向同一对象）
            ListNode head = temp;
            for (int i = 1; i < arr.Length; i++)
            {
                //head 和 temp 指向同一对象 （temp 指向的对象的 .next 创建新的对象）
                head.next = new ListNode(arr[i]);
                //head 赋值为新的对象的指针（temp不变）
                head = head.next;
            }
            //head 循环后指向 null，temp为头结点
            return temp;
        }




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
        /// https://leetcode-cn.com/problems/delete-middle-node-lcci/
        /// 实现一种算法，删除单向链表中间的某个节点（即不是第一个或最后一个节点），假定你只能访问该节点。
        /// 输入：单向链表a->b->c->d->e->f中的节点c
        /// 结果：不返回任何数据，但该链表变为a->b->d->e->f
        /// </summary>
        /// <param name="middleNode"></param>
        public static void RemoveMiddleListNode(ListNode middleNode)
        {
            middleNode.val = middleNode.next.val;
            middleNode.next = middleNode.next.next;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/convert-binary-number-in-a-linked-list-to-integer/
        /// 二进制转十进制的转换原理：从二进制的右边第一个数开始，每一个乘以2的n次方，n从0开始，每次递增1。
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int ConvertBinaryListNodeToIntNum(ListNode head)
        {
            var temp = new ListNode(head.val)
            {
                next = head.next
            };
            int ans = 0;
            //二进制转十进制的转换原理：从二进制的右边第一个数开始，每一个乘以2的n次方，n从0开始，每次递增1。
            //然后得出来的每个数相加即是十进制数。
            while (temp != null)
            {
                ans = ans * 2 + Convert.ToInt32(temp.val);
                temp = temp.next;
            }
            return ans;
        }


        /// <summary>
        /// https://leetcode-cn.com/problems/kth-node-from-end-of-list-lcci
        /// 实现一种算法，找出单向链表中倒数第 k 个节点。返回该节点的值。给定的 k 保证是有效的。
        /// 输入： 1->2->3->4->5 和 k = 2
        /// 输出： 4
        /// </summary>
        /// <param name="head"></param>
        /// <param name="k"></param>
        /// <returns></returns>
        public static ListNode GetKthFromEnd(ListNode head, int k)
        {
            //双指针解法

            //初始化两个指针 fir 和 sec，初始时均指向头结点。
            ListNode fir = head;
            ListNode sec = head;

            //先让 fir 沿着 next 移动 k 次。此时，fir 指向第 k+1个结点，sec 指向头节点，两个指针的距离为 k
            while (k-- > 0)
            {
                fir = fir.next;
            }

            //同时移动 fir 和 sec，直到 fir 指向空（fir == null），此时 sec 即指向倒数第 k 个结点。
            while (fir != null)
            {
                fir = fir.next;
                sec = sec.next;
            }

            return sec;

        }

        /// <summary>
        /// 输出链表
        /// </summary>
        /// <param name="head">头结点</param>
        public static string Write(ListNode head)
        {
            var temp = new ListNode(head.val)
            {
                next = head.next
            };
            StringBuilder sb = new StringBuilder();
            while (temp != null)
            {
                sb.Append($"{temp.val}->");
                var t = temp.next;
                temp = t;
            }
            return $"{sb.ToString().TrimEnd('-', '>')}";
        }


    }


}
