using LinearList.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace LinearList.数组
{
    public class MyArray<T> : IMyArray<T>
    {
        /// <summary>
        /// 元素总个数
        /// </summary>
        private int _size;
        /// <summary>
        /// 数组
        /// </summary>
        private T[] _arr;
        /// <summary>
        /// 数组初始化长度
        /// </summary>
        private const int DEFAULT_CAPACITY = 10;
        private const int DEFAULT_NOT_FIND = -1;

        /// <summary>
        /// 构造初始化数组，使用默认数组初始化长度10
        /// </summary>
        public MyArray()
        {
            _arr = new T[DEFAULT_CAPACITY];
        }

        /// <summary>
        /// 构造初始化数组，使用入参设置数组初始化长度
        /// </summary>
        /// <param name="capacity"></param>
        public MyArray(int capacity)
        {
            //如果入参小于默认初始化长度，则使用默认初始化长度
            _arr = new T[capacity < DEFAULT_CAPACITY ? DEFAULT_CAPACITY : capacity];
        }

        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="n"></param>
        public void Add(T n)
        {
            //元素总个数自增
            _size++;
            //添加元素到数组
            _arr[_size - 1] = n;
        }

        /// <summary>
        /// 指定索引添加元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="n"></param>
        public void Add(int index, T n)
        {
            //从索引位置开始的元素 到 数组最后一个元素，均向后移动
            //数组最后一个元素最先移动
            for (int i = _size; i > index; i--)
            {
                _arr[i] = _arr[i - 1];
            }
            //添加元素到数组的指定索引位置
            _arr[index] = n;
            //元素总个数自增
            _size++;
        }

        /// <summary>
        /// 指定索引设置元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public void Set(int index, T n)
        {
            if (index < 0 || index > _size)
            {
                throw new IndexOutOfRangeException();
            }
            _arr[index] = n;
        }


        /// <summary>
        /// 是否有元素
        /// </summary>
        /// <returns></returns>
        public bool Any()
        {
            return _size != 0;
        }
        /// <summary>
        /// 根据索引获取元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public T Get(int index)
        {
            if (index < 0 || index > _size - 1)
            {
                throw new IndexOutOfRangeException();
            }
            return _arr[index];
        }
        /// <summary>
        /// 是否存在指定元素
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        public bool Contains(T n)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_arr[i].Equals(n))
                    return true;
            }
            return false;
        }
        /// <summary>
        /// 获取元素个数
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return _size;
        }


        /// <summary>
        /// 获取元素索引
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public int IndexOf(T n)
        {
            for (int i = 0; i < _size; i++)
            {
                if (_arr[i].Equals(n))
                    return i;
            }
            return DEFAULT_NOT_FIND;
        }
        /// <summary>
        /// 移除元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public void Remove(int index)
        {
            //从索引位置往后的元素 到 数组最后一个元素，均向前移动
            //索引位置+1的元素最先移动
            for (int i = index; i < _size; i++)
            {
                _arr[i] = _arr[i + 1];
            }
            //元素总个数自减
            _size--;
        }
        /// <summary>
        /// 移除所有元素
        /// </summary>
        public void Clear()
        {
            //
            _size = 0;
        }


        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("PersonArray ");
            sb.Append("[");
            for (int i = 0; i < _size; i++)
            {
                if (i != _size - 1)
                { sb.Append(_arr[i]?.ToString() ?? "null" + ", "); }
                else
                {
                    sb.Append(_arr[i]?.ToString() ?? "null");
                }
            }
            sb.Append("]");
            return sb.ToString();
        }
    }
}
