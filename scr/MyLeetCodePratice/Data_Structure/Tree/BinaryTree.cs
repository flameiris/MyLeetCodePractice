using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tree
{

    public class BinaryTreeNode
    {
        public int Data;
        public BinaryTreeNode LeftNode;
        public BinaryTreeNode RightNode;

        internal static void CreateBinaryTree()
        {
            throw new NotImplementedException();
        }

        public BinaryTreeNode(int data)
        {
            this.Data = data;
        }





        /// <summary>
        ///  构建二叉树
        /// </summary>
        /// <param name="queue"></param>
        /// <returns></returns>
        public static BinaryTreeNode CreateBinaryTree(Queue<int> queue)
        {
            if (queue == null || !queue.Any())
                return null;

            int data = queue.Dequeue();

            BinaryTreeNode node = new BinaryTreeNode(data)
            {
                LeftNode = CreateBinaryTree(queue),
                RightNode = CreateBinaryTree(queue)
            };

            return node;
        }



        /// <summary>
        /// 前序遍历【迭代】
        /// 时间复杂度：O(n)  空间复杂度：O(n)
        /// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/solution/144er-cha-shu-de-qian-xu-bian-li-by-chenqian/
        /// </summary>
        /// <param name="node">根节点</param>
        /// <returns></returns>
        public static IList<int> PreOrderTraverseIteration(BinaryTreeNode node)
        {
            IList<int> res = new List<int>();
            //利用栈临时存储迭代内容
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();
            stack.Push(node);

            while (stack.Any())
            {
                //从栈中取出 当前迭代内容
                node = stack.Pop();
                if (node != null)
                {
                    res.Add(node.Data);

                    //入栈 子节点
                    stack.Push(node.LeftNode);
                    stack.Push(node.RightNode);
                }
            }
            return res;
        }

        /// <summary>
        /// 前序遍历【递归】
        /// 时间复杂度：O(n)  空间复杂度：O(n)
        /// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/solution/144er-cha-shu-de-qian-xu-bian-li-by-chenqian/
        /// </summary>
        /// <param name="node">根节点</param>
        /// <returns></returns>
        public static IList<int> PreOrderTraverseRecursion(BinaryTreeNode node)
        {
            return Trave(node, new List<int>());

            static IList<int> Trave(BinaryTreeNode node, IList<int> res)
            {
                if (node != null)
                {
                    res.Add(node.Data);
                    Trave(node.LeftNode, res);
                    Trave(node.RightNode, res);
                }
                return res;
            }
        }



        /// <summary>
        /// 中序遍历【迭代】
        /// 时间复杂度：O(n)  空间复杂度：O(n)
        /// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/solution/144er-cha-shu-de-qian-xu-bian-li-by-chenqian/
        /// </summary>
        /// <param name="node">根节点</param>
        /// <returns></returns>
        //public static IList<int> InOrderTraverseIteration(BinaryTreeNode node)
        //{



        //    //IList<int> res = new List<int>();
        //    ////利用栈临时存储迭代内容
        //    //Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();
        //    //stack.Push(node);

        //    //while (stack.Any())
        //    //{
        //    //    //从栈中取出 当前迭代内容
        //    //    node = stack.Pop();



        //    //}
        //    //return res;
        //}

        /// <summary>
        /// 中序遍历【递归】
        /// 时间复杂度：O(n)  空间复杂度：O(n)
        /// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/solution/144er-cha-shu-de-qian-xu-bian-li-by-chenqian/
        /// </summary>
        /// <param name="node">根节点</param>
        /// <returns></returns>
        public static IList<int> InOrderTraverseRecursion(BinaryTreeNode node)
        {
            return Trave(node, new List<int>());

            static IList<int> Trave(BinaryTreeNode node, IList<int> res)
            {
                if (node != null)
                {
                    Trave(node.LeftNode, res);
                    res.Add(node.Data);
                    Trave(node.RightNode, res);
                }
                return res;
            }
        }



        /// <summary>
        /// 后序遍历【迭代】
        /// 时间复杂度：O(n)  空间复杂度：O(n)
        /// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/solution/144er-cha-shu-de-qian-xu-bian-li-by-chenqian/
        /// </summary>
        /// <param name="node">根节点</param>
        /// <returns></returns>
        public static IList<int> PostOrderTraverseIteration(BinaryTreeNode node)
        {
            IList<int> res = new List<int>();
            //利用栈临时存储迭代内容
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();
            stack.Push(node);

            while (stack.Any())
            {
                //从栈中取出 当前迭代内容
                node = stack.Pop();
                if (node != null)
                {
                    //入栈 子节点
                    stack.Push(node.LeftNode);
                    stack.Push(node.RightNode);
                    res.Add(node.Data);
                }
            }
            return res;
        }

        /// <summary>
        /// 后序遍历【递归】
        /// 时间复杂度：O(n)  空间复杂度：O(n)
        /// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/solution/144er-cha-shu-de-qian-xu-bian-li-by-chenqian/
        /// </summary>
        /// <param name="node">根节点</param>
        /// <returns></returns>
        public static IList<int> PostOrderTraverseRecursion(BinaryTreeNode node)
        {
            return Trave(node, new List<int>());

            static IList<int> Trave(BinaryTreeNode node, IList<int> res)
            {
                if (node != null)
                {
                    Trave(node.LeftNode, res);
                    Trave(node.RightNode, res);
                    res.Add(node.Data);
                }
                return res;
            }
        }



    }
}
