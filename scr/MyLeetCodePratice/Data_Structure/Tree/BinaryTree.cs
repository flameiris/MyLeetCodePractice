using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Xml;

namespace Tree
{

    public class BinaryTreeNode
    {
        public int Data;
        public BinaryTreeNode LeftNode;
        public BinaryTreeNode RightNode;


        public BinaryTreeNode(int data)
        {
            this.Data = data;
        }

        /// <summary>
        ///  手动构建二叉树
        ///       1
        ///    2     3
        ///  4   5     6
        /// </summary>
        /// <param name="queue"></param>
        /// <returns></returns>
        public static BinaryTreeNode CreateBinaryTree()
        {
            var node1 = new BinaryTreeNode(1);
            var node2 = new BinaryTreeNode(2);
            var node3 = new BinaryTreeNode(3);
            var node4 = new BinaryTreeNode(4);
            var node5 = new BinaryTreeNode(5);
            var node6 = new BinaryTreeNode(6);


            node1.LeftNode = node2;
            node1.RightNode = node3;
            node2.LeftNode = node4;
            node2.RightNode = node5;
            node3.RightNode = node6;
            return node1;
        }





        /// <summary>
        /// 层序遍历【迭代】   从上到下，从左到右依次遍历每个节点，使用【队列】辅助存储节点。
        /// </summary>
        /// <param name="node"></param>
        /// <returns></returns>
        public static IList<int> LevelTraversal(BinaryTreeNode node)
        {
            //1.将根节点插入队列
            //2.从队列中取出节点，判断节点如果有子节点，就将子节点插入队列
            //3.遍历过的节点出队列


            IList<int> res = new List<int>();
            Queue<BinaryTreeNode> queue = new Queue<BinaryTreeNode>();
            if (node == null) return res;
            queue.Enqueue(node);
            while (queue.Any())
            {
                BinaryTreeNode item = queue.Dequeue();
                res.Add(item.Data);
                if (item.LeftNode != null)
                {
                    queue.Enqueue(item.LeftNode);
                }
                if (item.RightNode != null)
                {
                    queue.Enqueue(item.RightNode);
                }
            }
            return res;
        }



        /// <summary>
        /// 前序遍历【迭代】 使用【栈】辅助存储节点。
        /// 1.先遍历根节点。
        /// 2.再遍历左子节点一直遍历到左侧最深层的叶子节点。
        /// 3.如果左侧最深层叶子节点存在兄弟节点，则将其视为根节点继续步骤1，2。
        /// 4.遍历根节点的右子节点，将其视为根节点继续步骤1，2。
        /// 时间复杂度：O(n)  空间复杂度：O(n)。
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
                    stack.Push(node.RightNode);
                    stack.Push(node.LeftNode);
                }
            }
            return res;
        }

        /// <summary>
        /// 前序遍历【递归】 
        /// 1.先遍历根节点。
        /// 2.再遍历左子节点一直遍历到左侧最深层的叶子节点。
        /// 3.如果左侧最深层叶子节点存在兄弟节点，则将其视为根节点继续步骤1，2。
        /// 4.遍历根节点的右子节点，将其视为根节点继续步骤1，2。
        /// 时间复杂度：O(n)  空间复杂度：O(n)。
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
        /// 中序遍历【迭代】 使用【栈】辅助存储节点
        /// 1.从根节点开始，遍历到树的最左节点
        /// 2.访问过最左节点后，如该最左节点存在右子节点，则需要访问该右子节点（将最左节点看作子树的根节点，右子节点就是它的右子树，因此按照遍历规则需要对右子树进行中序遍历）
        /// 3.继续访问最左节点的根节点
        /// 时间复杂度：O(n)  空间复杂度：O(n)
        /// https://leetcode-cn.com/problems/binary-tree-preorder-traversal/solution/144er-cha-shu-de-qian-xu-bian-li-by-chenqian/
        /// </summary>
        /// <param name="node">根节点</param>
        /// <returns></returns>
        public static IList<int> InOrderTraverseIteration(BinaryTreeNode node)
        {
            IList<int> res = new List<int>();
            //利用栈临时存储迭代内容
            Stack<BinaryTreeNode> stack = new Stack<BinaryTreeNode>();

            if (node == null)
            {
                return res;
            }
            var cur = node;
            while (stack.Any() || cur != null)
            {
                while (cur != null)
                {
                    stack.Push(cur);
                    cur = cur.LeftNode;
                }
                node = stack.Pop();
                res.Add(node.Data);
                if (node.RightNode != null)
                {
                    cur = node.RightNode;
                }
            }

            return res;
        }

        /// <summary>
        /// 中序遍历【递归】
        /// 1.从根节点开始，遍历到树的最左节点
        /// 2.访问过最左节点后，如该最左节点存在右子节点，则需要访问该右子节点（将最左节点看作子树的根节点，右子节点就是它的右子树，因此按照遍历规则需要对右子树进行中序遍历）
        /// 3.继续访问最左节点的根节点
        /// 时间复杂度：O(n)    空间复杂度：O(n)  
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
            Stack<BinaryTreeNode> stack1 = new Stack<BinaryTreeNode>();
            Stack<BinaryTreeNode> stack2 = new Stack<BinaryTreeNode>();
            if (node == null)
                return res;
            stack1.Push(node);
            while (stack1.Any())
            {
                var cur = stack1.Pop();
                stack2.Push(cur);
                if (cur.LeftNode != null)
                {
                    stack1.Push(cur.LeftNode);
                }
                if (cur.RightNode != null)
                {
                    stack1.Push(cur.RightNode);
                }
            }
            while (stack2.Any())
            {
                res.Add(stack2.Pop().Data);
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
