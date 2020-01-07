using System;
using System.Collections.Generic;
using System.Text;

namespace Label_Array
{
    public class Solution
    {
        /// <summary>
        /// 暴力法:
        /// 遍历每个元素 x，并查找是否存在一个值与 target - x 相等的目标元素。
        /// 
        /// 时间复杂度 O(n^2) 
        /// 对于每个元素，我们试图通过遍历数组的其余部分来寻找它所对应的目标元素，这将耗费 O(n) 的时间，因此时间复杂度为O(n^2)  
        /// 空间复杂度 O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum1(int[] nums, int target)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[i] == target - nums[j])
                        return new int[] { i, j };
                }
            }

            throw new Exception("No two sum solution");
        }

        /// <summary>
        /// 两遍哈希表
        /// 对运行时间复杂度进行优化,需要一种更有效的方法来检查数组中是否存在目标元素——哈希表(C#的字典集合)
        /// 通过以空间换取速度的方式，可以将查找时间从 O(n)降低到 O(1)
        /// 
        /// 时间复杂度 O(n) 
        /// 包含n个元素的数组遍历两遍，由于哈希表将查找时间优化到O(1),所以时间复杂度为O(n)
        /// 空间复杂度 O(n)
        /// 取决于元素的数量
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum2(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);
            }

            for (int j = 0; j < nums.Length; j++)
            {
                var temp = target - nums[j];
                if (dic.ContainsKey(temp) && dic[temp] != j)
                    return new int[] { j, dic[temp] };
            }

            throw new Exception("No two sum solution");
        }

        /// <summary>
        /// 一遍哈希表
        /// 时间复杂度 O(n) 
        /// 包含n个元素的数组遍历一遍，由于哈希表将查找时间优化到O(1),所以时间复杂度为O(n)
        /// 空间复杂度 O(n)
        /// 取决于元素的数量
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public int[] TwoSum3(int[] nums, int target)
        {
            var dic = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                dic.Add(nums[i], i);

                var temp = target - nums[i];
                if (dic.ContainsKey(temp) && dic[temp] != i)
                    return new int[] { i, dic[temp] };
            }

            throw new Exception("No two sum solution");
        }
    }
}
