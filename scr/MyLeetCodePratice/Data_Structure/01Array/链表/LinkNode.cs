using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LinearList.链表
{

    public class ListNode
    {
        public ListNode(int x) { val = x; }
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

        public int val;
        public ListNode next;

        /// <summary>
        /// 生成单向链表
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static ListNode GetListNode(params int[] arr)
        {
            //定义头结点
            ListNode head = new ListNode(arr[0]);

            //temp 赋值为 指向头结点head的指针（temp 和 head  指向同一对象）
            ListNode temp = head;
            for (int i = 1; i < arr.Length; i++)
            {
                //temp 和 head  指针指向同一对象 （temp.next 指向新创建的下一个节点）
                temp.next = new ListNode(arr[i]);
                //temp 指向 新创建的下一个节点
                temp = temp.next;
            }
            //temp 循环结束后指向尾节点，temp.next 指向 null，  head 为头结点
            return head;
        }




        /// <summary>
        /// 单向链表—完全反转
        /// </summary>
        /// <param name="head">头结点</param>
        /// <returns></returns>
        public static ListNode ReverseList(ListNode head)
        {
            //从头到尾进行反转
            //从头结点 A 开始，头结点指向null  A->NULL  
            //原头结点 A 指向的节点 B，指向头结点 A    B->A->NULL 

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
                //当前节点指向下一节点
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
        /// 实现一种算法，删除单向链表中间的某个节点（即不是第一个或最后一个节点），假定你只能访问该节点。
        /// 输入：单向链表a->b->c->d->e->f中的节点c
        /// 结果：不返回任何数据，但该链表变为a->b->d->e->f
        /// https://leetcode-cn.com/problems/delete-middle-node-lcci/
        /// </summary>
        /// <param name="middleNode"></param>
        public static void RemoveMiddleListNode(ListNode middleNode)
        {
            middleNode.val = middleNode.next.val;
            middleNode.next = middleNode.next.next;
        }


        /// <summary>
        /// 二进制转十进制的转换原理：从二进制的右边第一个数开始，每一个乘以2的n次方，n从0开始，每次递增1。
        /// https://leetcode-cn.com/problems/convert-binary-number-in-a-linked-list-to-integer/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int ConvertBinaryListNodeToIntNum(ListNode head)
        {
            var temp = head;
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
        /// 实现一种算法，找出单向链表中倒数第 k 个节点。返回该节点的值。给定的 k 保证是有效的。
        /// https://leetcode-cn.com/problems/kth-node-from-end-of-list-lcci
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
        /// 剑指 Offer 06. 从尾到头打印链表 输入一个链表的头节点，从尾到头反过来返回每个节点的值（用数组返回）。
        /// https://leetcode-cn.com/problems/cong-wei-dao-tou-da-yin-lian-biao-lcof/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int[] ReverseListReturnArr1(ListNode head)
        {
            int len = 0;
            ListNode temp = new ListNode(head.val) { next = head.next };
            while (temp != null)
            {
                temp = temp.next;
                len++;
            }

            int[] arr = new int[len];

            //作为临时变量存储当前节点
            ListNode pre = null;
            ListNode cur = head;
            while (cur != null)
            {
                arr[len - 1] = cur.val;
                //下一节点
                ListNode next = cur.next;
                //第一个节点反转为最后一个节点，指向null
                //当前节点赋值为 上一次循环中的临时存储(当前节点反转后的结果) 
                cur.next = pre;
                //临时存储 当前节点反转后的结果
                pre = cur;
                //当前节点为下一节点
                cur = next;
                len--;
            }

            return arr;
        }

        /// <summary>
        /// 剑指 Offer 06. 从尾到头打印链表 输入一个链表的头节点，从尾到头反过来返回每个节点的值（用数组返回）。
        /// https://leetcode-cn.com/problems/cong-wei-dao-tou-da-yin-lian-biao-lcof/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static int[] ReverseListReturnArr2(ListNode head)
        {
            Stack<ListNode> stack = new Stack<ListNode>();
            ListNode temp = head;
            while (temp != null)
            {
                stack.Push(temp);
                temp = temp.next;
            }
            int size = stack.Count;
            int[] print = new int[size];
            for (int i = 0; i < size; i++)
            {
                print[i] = stack.Pop().val;
            }
            return print;
        }


        /// <summary>
        /// 移除重复值的节点
        /// https://leetcode-cn.com/problems/remove-duplicate-node-lcci/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode RemoveRepeatNode(ListNode head)
        {
            //使用哈希表存储出现的节点值
            HashSet<int> hs = new HashSet<int>();

            ListNode cur = head;
            //将头节点值存入
            hs.Add(head.val);
            while (cur.next != null)
            {
                //如果添加下一节点值，则当前节点指向下一节点，否则 当前节点的下一节点 指向 当前节点下第二节点
                if (hs.Add(cur.next.val))
                {
                    cur = cur.next;
                }
                else
                {
                    cur.next = cur.next.next;
                }

            }
            return head;
        }


        /// <summary>
        /// 返回中间节点
        /// https://leetcode-cn.com/problems/middle-of-the-linked-list/
        /// </summary>
        /// <param name="head"></param>
        /// <returns></returns>
        public static ListNode FindMiddleNode(ListNode head)
        {
            if (head.next == null)
                return head;

            ListNode slow = head;
            ListNode fast = head;

            while (fast != null && fast.next != null)
            {
                //慢指针一次循环往前走一个节点
                //快指针一次循环往前走两个节点
                //快指针指向节点的下一节点为null，则有两个中间节点，慢指针指向第二个节点
                slow = slow.next;
                fast = fast.next.next;



                ////慢指针一次循环往前走一个节点
                ////快指针一次循环往前走两个节点
                ////快指针为null，则有一个中间节点，慢指针指向中间节点
                //fast = fast.next.next;
                //if (fast != null)
                //{
                //    slow = slow.next;
                //}
            }

            return slow;

        }





        /// <summary>
        /// 剑指 Offer 18. 删除链表的节点
        /// 给定单向链表的头指针和一个要删除的节点的值，定义一个函数删除该节点。
        /// 返回删除后的链表的头节点。
        /// https://leetcode-cn.com/problems/shan-chu-lian-biao-de-jie-dian-lcof/
        /// </summary>
        /// <param name="head"></param>
        /// <param name="val"></param>
        public static ListNode RemoveNode(ListNode head, int num)
        {
            ListNode cur = head;
            while (cur.next != null)
            {
                if (cur.next.val == num)
                {
                    cur.next = cur.next.next;
                }
                else
                {
                    cur = cur.next;
                }
            }

            return head;
        }


        /// <summary>
        /// 给定两个（单向）链表，判定它们是否相交并返回交点。请注意相交的定义基于节点的引用，而不是基于节点的值。
        /// 换句话说，如果一个链表的第k个节点与另一个链表的第j个节点是同一节点（引用完全相同），则这两个链表相交。
        /// https://leetcode-cn.com/problems/intersection-of-two-linked-lists-lcci
        /// </summary>
        /// <param name="headA"></param>
        /// <param name="headB"></param>
        public static void ListNodeCross(ListNode headA, ListNode headB)
        {

        }


        /// <summary>
        /// 合并两个单项链表，升序排序
        /// https://leetcode-cn.com/problems/merge-two-sorted-lists/
        /// </summary>
        /// <param name="l1"></param>
        /// <param name="l2"></param>
        /// <returns></returns>
        public static ListNode CombineListNode(ListNode l1, ListNode l2)
        {
            ListNode prehead = new ListNode(-1);

            ListNode prev = prehead;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    prev.next = l1;
                    l1 = l1.next;
                }
                else
                {
                    prev.next = l2;
                    l2 = l2.next;
                }
                prev = prev.next;
            }

            // 合并后 l1 和 l2 最多只有一个还未被合并完，我们直接将链表末尾指向未合并完的链表即可
            prev.next = l1 == null ? l2 : l1;

            return prehead.next;
        }


        public static bool IsListNodePalindrome(ListNode head)
        {

        }







        /// <summary>
        /// 输出链表
        /// </summary>
        /// <param name="head">头结点</param>
        public static string Write(ListNode head)
        {
            StringBuilder sb = new StringBuilder();
            while (head != null)
            {
                sb.Append($"{head.val}->");
                head = head.next;
            }
            return $"{sb.ToString().TrimEnd('-', '>')}";
        }


    }


}
