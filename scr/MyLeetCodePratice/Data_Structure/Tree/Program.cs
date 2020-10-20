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


            ///  手动构建二叉树
            ///       1
            ///    2     3
            ///  4   5     6
            var binaryTree = BinaryTreeNode.CreateBinaryTree();
            Console.WriteLine($"层序遍历(迭代)={{ {string.Join(",", BinaryTreeNode.LevelTraversal(binaryTree).ToList())}  }}");


            ///  前序遍历  1 | 2 | 4 , 5 | 3 | 6
            Console.WriteLine($"前序遍历(迭代)={{ {string.Join(",", BinaryTreeNode.PreOrderTraverseIteration(binaryTree).ToList())}  }}");
            Console.WriteLine($"前序遍历(递归)={{ {string.Join(",", BinaryTreeNode.PreOrderTraverseRecursion(binaryTree).ToList())}  }}");

            ///  中序遍历 
            Console.WriteLine($"中序遍历(迭代)={{ {string.Join(",", BinaryTreeNode.InOrderTraverseIteration(binaryTree).ToList())}  }}");
            Console.WriteLine($"中序遍历(递归)={{ {string.Join(",", BinaryTreeNode.InOrderTraverseRecursion(binaryTree).ToList())}  }}");

            ///  后序遍历
            Console.WriteLine($"后序遍历(迭代)={{ {string.Join(",", BinaryTreeNode.PostOrderTraverseIteration(binaryTree).ToList())}  }}");
            Console.WriteLine($"后序遍历(递归)={{ {string.Join(",", BinaryTreeNode.PostOrderTraverseRecursion(binaryTree).ToList())}  }}");


            Console.Read();
        }
    }
}
