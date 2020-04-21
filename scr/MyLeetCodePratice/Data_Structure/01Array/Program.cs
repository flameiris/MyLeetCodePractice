using System;
using System.Text;

namespace _01Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //int类型的数组
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
            arr.Add(80);
            arr.Add(90);
            arr.Add(100);
            arr.Add(110);
            arr.Add(120);
            arr.Add(130);
            arr.Add(140);
            arr.Add(100);
            arr.Add(110);
            arr.Add(120);
            arr.Add(130);
            arr.Add(140);
            Console.WriteLine($"数组为 {arr}");





            //泛型数组
            MyArray<Person> personArr = new MyArray<Person>();
            personArr.Add(new Person { Name = "FlameIris1", Age = 10 });
            personArr.Add(new Person { Name = "FlameIris2", Age = 20 });
            personArr.Add(new Person { Name = "FlameIris3", Age = 30 });
            personArr.Add(new Person { Name = "FlameIris4", Age = 40 });
            personArr.Add(new Person { Name = "FlameIris5", Age = 50 });
            personArr.Add(new Person { Name = "FlameIris6", Age = 60 });


            Console.WriteLine($"数组为 {personArr}");
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
