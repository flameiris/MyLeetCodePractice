using System;
using System.Collections.Generic;
using System.Text;

namespace Sort
{
    public class Sorting
    {
        /// <summary>
        /// 冒泡排序
        /// 时间复杂度为O(n^2)  空间复杂度为O(n)
        /// </summary>
        /// <param name="arr"></param>
        public static void BubbleSort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = arr.Length - 1; j > i; j--)
                {
                    if (arr[j] < arr[j - 1])
                    {
                        Swap(arr, j - 1, j);
                    }
                }
            }

            static void Swap(int[] arr, int i, int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }


        /// <summary>
        /// 选择排序 时间复杂度为O(n^2)  空间复杂度为O(n)
        /// </summary>
        /// <param name="arr"></param>
        public static void SelectSort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return;
            for (int i = 0; i < arr.Length - 1; i++)
            { //只需要比较n-1次
                int minIndex = i;
                for (int j = i + 1; j < arr.Length; j++)
                { //从i+1开始比较，因为minIndex默认为i了，i就没必要比了。
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }

                if (minIndex != i)
                { //如果minIndex不为i，说明找到了更小的值，交换之。
                    Swap(arr, i, minIndex);
                }
            }


            static void Swap(int[] arr, int i, int j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
            }
        }


        /// <summary>
        /// 插入排序 时间复杂度为O(n^2)  空间复杂度为O(n)
        /// </summary>
        /// <param name="arr"></param>
        public static void InsertSort(int[] arr)
        {
            if (arr == null || arr.Length == 0)
                return;

            for (int i = 1; i < arr.Length; i++)
            { //假设第一个数位置时正确的；要往后移，必须要假设第一个。

                int j = i;
                int target = arr[i]; //待插入的

                //后移
                while (j > 0 && target < arr[j - 1])
                {
                    arr[j] = arr[j - 1];
                    j--;
                }

                //插入 
                arr[j] = target;
            }

        }


        /// <summary>
        /// 快速排序
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public static void QuickSort(int[] arr, int left, int right)
        {
            if (left >= right)
                return;
            int pivotPos = Partition(arr, left, right);
            QuickSort(arr, left, pivotPos - 1);
            QuickSort(arr, pivotPos + 1, right);


            static int Partition(int[] arr, int left, int right)
            {
                int pivotKey = arr[left];
                int pivotPointer = left;

                while (left < right)
                {
                    while (left < right && arr[right] >= pivotKey)
                        right--;
                    while (left < right && arr[left] <= pivotKey)
                        left++;
                    Swap(arr, left, right); //把大的交换到右边，把小的交换到左边。
                }
                Swap(arr, pivotPointer, left); //最后把pivot交换到中间
                return left;
            }

            static void Swap(int[] arr, int left, int right)
            {
                int temp = arr[left];
                arr[left] = arr[right];
                arr[right] = temp;
            }
        }


    }
}
