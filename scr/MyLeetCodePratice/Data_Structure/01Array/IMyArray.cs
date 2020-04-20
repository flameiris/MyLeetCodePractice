using System;
using System.Collections.Generic;
using System.Text;

namespace _01Array
{
    public interface IMyArray
    {
        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="n"></param>
        void Add(int n);
        /// <summary>
        /// 指定索引添加元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="n"></param>
        void Add(int index, int n);
        /// <summary>
        /// 指定索引设置元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        void Set(int index, int n);


        /// <summary>
        /// 是否有元素
        /// </summary>
        /// <returns></returns>
        bool Any();
        /// <summary>
        /// 根据索引获取元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        int Get(int index);
        /// <summary>
        /// 是否存在指定元素
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        bool Contains(int n);
        /// <summary>
        /// 获取元素个数
        /// </summary>
        /// <returns></returns>
        int Count();

        /// <summary>
        /// 获取元素索引
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        int IndexOf(int index);
        /// <summary>
        /// 移除元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        void Remove(int index);
        /// <summary>
        /// 移除所有元素
        /// </summary>
        void Clear();






    }


    public interface IMyArray<T>
    {
        /// <summary>
        /// 添加元素
        /// </summary>
        /// <param name="n"></param>
        void Add(T n);
        /// <summary>
        /// 指定索引添加元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="n"></param>
        void Add(int index, T n);
        /// <summary>
        /// 指定索引设置元素
        /// </summary>
        /// <param name="index"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        void Set(int index, T n);


        /// <summary>
        /// 是否有元素
        /// </summary>
        /// <returns></returns>
        bool Any();
        /// <summary>
        /// 根据索引获取元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        T Get(int index);
        /// <summary>
        /// 是否存在指定元素
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        bool Contains(T n);
        /// <summary>
        /// 获取元素个数
        /// </summary>
        /// <returns></returns>
        int Count();

        /// <summary>
        /// 获取元素索引
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        int IndexOf(T n);
        /// <summary>
        /// 移除元素
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        void Remove(int index);
        /// <summary>
        /// 移除所有元素
        /// </summary>
        void Clear();






    }
}
