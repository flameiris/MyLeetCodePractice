using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Tree
{
    class Program
    {
        static void Main(string[] args)
        {

            Queue<int> queue = new Queue<int>(new int[] { 3, 1, 2 });
            var binaryTree = BinaryTreeNode.CreateBinaryTree(queue);


            Console.WriteLine($"前序遍历(迭代)={{ {string.Join(",", BinaryTreeNode.PreOrderTraverseIteration(binaryTree).ToList())}  }}");
            Console.WriteLine($"前序遍历(递归)={{ {string.Join(",", BinaryTreeNode.PreOrderTraverseIteration(binaryTree).ToList())}  }}");

            //Console.WriteLine($"中序遍历(迭代)={{ {string.Join(",", BinaryTreeNode.InOrderTraverseIteration(binaryTree).ToList())}  }}");
            Console.WriteLine($"中序遍历(递归)={{ {string.Join(",", BinaryTreeNode.InOrderTraverseRecursion(binaryTree).ToList())}  }}");

            Console.WriteLine($"后序遍历(迭代)={{ {string.Join(",", BinaryTreeNode.PostOrderTraverseIteration(binaryTree).ToList())}  }}");
            Console.WriteLine($"后序遍历(递归)={{ {string.Join(",", BinaryTreeNode.PostOrderTraverseRecursion(binaryTree).ToList())}  }}");


            Console.Read();
        }
    }
}
