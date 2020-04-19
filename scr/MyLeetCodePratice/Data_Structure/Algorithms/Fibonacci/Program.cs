using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 11, 22, 33 };
            Console.WriteLine(Fibonacci1(38));

            Console.WriteLine(Fibonacci2(38));
            Console.ReadKey();
        }

        /// <summary>
        /// F(1)=1，F(2)=1, F(n)=F(n - 1)+F(n - 2)（n ≥ 3，n ∈ N*）
        /// 时间复杂度 O(2^n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci1(int n)
        {
            if (n <= 2) return 1;
            return Fibonacci1(n - 1) + Fibonacci1(n - 2);
        }

        /// <summary>
        /// 循环次数为 相加次数
        /// 第n项:1,2,3,4,5,6,7, 8, 9
        /// 结果 :1,1,2,3,5,8,13,21,34 
        /// 次数 :0,0,1,2,3,4,5, 6, 7
        /// 时间复杂度 O(n)
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public static int Fibonacci2(int n)
        {
            //前两项返回1
            if (n <= 2) return 1;

            int first = 1;
            int second = 1;

            //例： 第3项，相加次数为1，两数相加为2
            //例： 第4项，相加次数为2，两数相加为3
            for (int i = 1; i <= n - 2; i++)
            {
                int num = first + second;
                first = second;
                second = num;
            }

            return second;

        }
    }
}
