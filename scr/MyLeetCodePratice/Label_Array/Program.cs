using System;

namespace Label_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //给定一个整数数组 nums和一个目标值 target，请你在该数组中找出和为目标值的那 两个整数，并返回他们的数组下标。

            //你可以假设每种输入只会对应一个答案。但是，你不能重复利用这个数组中同样的元素。

            //示例:

            //给定 nums = [2, 7, 11, 15], target = 9

            //因为 nums[0] +nums[1] = 2 + 7 = 9
            //所以返回[0, 1]

            var s = new Solution();

            var arr = new int[] { 2, 7, 11, 15 };

            var res1 = s.TwoSum1(arr, 26);

            var res2 = s.TwoSum2(arr, 26);

            var res3 = s.TwoSum3(arr, 26);


            Console.ReadKey();
        }
    }
}
