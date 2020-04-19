using System;

namespace _01Array
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray arr = new MyArray();
            arr.Add(10);
            arr.Add(20);
            arr.Add(30);
            arr.Add(1, 15);

            Console.WriteLine($"数组为 {arr}");
            Console.WriteLine($"是否存元素 {arr.Any()}");
            Console.WriteLine($"数组元素个数为 {arr.Count()}");
            Console.WriteLine($"值为20的元素索引为 {arr.IndexOf(20)}");
            Console.WriteLine($"是否存在值为30的元素 {arr.Contains(30)}");
            arr.Set(3, 35);
            Console.WriteLine($"数组为 {arr}");
            arr.Remove(1);
            Console.WriteLine($"数组为 {arr}");

            arr.Clear();
            Console.WriteLine($"数组为 {arr}");

            arr.Add(50);
            arr.Add(60);
            arr.Add(70);
            arr.Add(1, 65);
            Console.WriteLine($"数组为 {arr}");
            Console.ReadKey();
        }
    }
}
