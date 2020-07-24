using System;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            //整数
            var i = 100;
            Console.WriteLine($"整数 100 的 hashcode = {i.GetHashCode()}");

            //单精度浮点
            var f = 100.05f;
            Console.WriteLine($"单精度浮点数 100.05 的 hashcode = {f.GetHashCode()}");

            //双精度浮点
            var d = 100.05d;
            Console.WriteLine($"双精度浮点数 100.05 的 hashcode = {d.GetHashCode()}");

            //decimal
            var m = 100.05m;
            Console.WriteLine($"decimal 100.05 的 hashcode = {m.GetHashCode()}");

            //long
            var l = 100L;
            Console.WriteLine($"长整型 100 的 hashcode = {l.GetHashCode()}");

            //str
            var str1 = "100";
            var str2 = "abc";
            var str3 = "哈哈哈";
            Console.WriteLine($"字符串 100 的 hashcode = {str1.GetHashCode()}");
            Console.WriteLine($"字符串 100 的 hashcode = {str2.GetHashCode()}");
            Console.WriteLine($"字符串 100 的 hashcode = {str3.GetHashCode()}");

            //自定义类型对象
            var p1 = new Person() { Name = "flameiris", Age = 18 };
            var p2 = new Person() { Name = "flameiris", Age = 18 };
            var p3 = new Person() { Name = "flameiris", Age = 19 };
            var p4 = new Person() { Name = "flameiris", Age = 19 };
            var p5 = new Person() { Name = "flameiris", Age = 20 };
            Console.WriteLine($"自定义类型Person 对象 p1 的 hashcode = {p1.GetHashCode()}");
            Console.WriteLine($"自定义类型Person 对象 p2 的 hashcode = {p2.GetHashCode()}");
            Console.WriteLine($"自定义类型Person 对象 p3 的 hashcode = {p3.GetHashCode()}");
            Console.WriteLine($"自定义类型Person 对象 p4 的 hashcode = {p4.GetHashCode()}");
            Console.WriteLine($"自定义类型Person 对象 p5 的 hashcode = {p5.GetHashCode()}");



            Console.ReadKey();
        }
    }

    public class Person2
    {

    }

    public class Person : Person2
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
