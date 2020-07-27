using LinearList.数组;
using LinearList.链表;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks.Dataflow;

namespace _01Array
{
    class Program
    {
        static void Main(string[] args)
        {
            ////int类型的数组
            //MyArray arr = new MyArray();
            //arr.Add(10);
            //arr.Add(20);
            //arr.Add(30);
            //arr.Add(1, 15);

            //Console.WriteLine($"数组为 {arr}");
            //Console.WriteLine($"是否存元素 {arr.Any()}");
            //Console.WriteLine($"数组元素个数为 {arr.Count()}");
            //Console.WriteLine($"值为20的元素索引为 {arr.IndexOf(20)}");
            //Console.WriteLine($"是否存在值为30的元素 {arr.Contains(30)}");
            //arr.Set(3, 35);
            //Console.WriteLine($"数组为 {arr}");
            //arr.Remove(1);
            //Console.WriteLine($"数组为 {arr}");

            //arr.Clear();
            //Console.WriteLine($"数组为 {arr}");

            //arr.Add(50);
            //arr.Add(60);
            //arr.Add(70);
            //arr.Add(1, 65);
            //arr.Add(80);
            //arr.Add(90);
            //arr.Add(100);
            //arr.Add(110);
            //arr.Add(120);
            //arr.Add(130);
            //arr.Add(140);
            //arr.Add(100);
            //arr.Add(110);
            //arr.Add(120);
            //arr.Add(130);
            //arr.Add(140);
            //Console.WriteLine($"数组为 {arr}");





            ////泛型数组
            //MyArray<Person> pArr = new MyArray<Person>();
            //var p = new Person { Name = "FlameIris4", Age = 40 };
            //pArr.Add(new Person { Name = "FlameIris1", Age = 10 });
            //pArr.Add(new Person { Name = "FlameIris2", Age = 20 });
            //pArr.Add(new Person { Name = "FlameIris3", Age = 30 });
            //pArr.Add(p);
            //pArr.Add(new Person { Name = "FlameIris5", Age = 50 });
            //pArr.Add(new Person { Name = "FlameIris6", Age = 60 });
            //pArr.Add(null);

            //Console.WriteLine($"数组为 {pArr}");
            //Console.WriteLine($"是否存元素 {pArr.Any()}");
            //Console.WriteLine($"数组元素个数为 {pArr.Count()}");
            //Console.WriteLine($"值为p 的元素索引为 {pArr.IndexOf(p)}");
            //Console.WriteLine($"是否存在值为 p的元素 {pArr.Contains(p)}");
            //Console.WriteLine($"是否存在值为 null 的元素 {pArr.Contains(null)}，索引为 {pArr.IndexOf(null)}");




            #region 链表
            //1->2->3->4->5
            var head = ListNode.GetListNode(1, 2, 3, 4, 5);
            Console.WriteLine(ListNode.Write(head));

            //单向链表—完全反转
            var head1 = ListNode.ReverseList(head);
            Console.WriteLine(ListNode.Write(head1));

            //单向链表—完全反转
            var head2 = ListNode.ReverseList(head1);
            Console.WriteLine(ListNode.Write(head2));

            //删除单向链表中间的某个节点（即不是第一个或最后一个节点）
            ListNode.RemoveMiddleListNode(head2.next.next);
            Console.WriteLine(ListNode.Write(head));

            //二进制单向链表转换十进制为
            var head3 = ListNode.GetListNode(1, 0, 0, 0, 0, 0, 0);
            int ans = ListNode.ConvertBinaryListNodeToIntNum(head3);
            Console.WriteLine($"二进制单向链表 {ListNode.Write(head3)} 转换十进制为：{ans}");


            var head4 = ListNode.GetListNode(1, 2, 3, 4, 5, 6, 7, 8, 9);
            int k = 5;
            var kthNode = ListNode.GetKthFromEnd(head4, k);
            Console.WriteLine($"倒数第 {k}个节点的值为  {kthNode.val} ");















            #endregion


            Console.ReadKey();
        }





    }


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            return $"  Person {{ Name={Name}, Age={Age} }}  ";
        }
    }

}
