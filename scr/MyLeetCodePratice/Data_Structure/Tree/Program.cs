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
            #region 构建、前序遍历、中序遍历、后序遍历

            ///  手动构建二叉树
            ///       1
            ///    2     3
            ///  4   5     6
            //var binaryTree = BinaryTreeNode.CreateBinaryTree();

            ///  自动构建二叉树
            ///       1
            ///    2     3
            ///  4     6
            ///8  
            List<int?> list = new List<int?> { 1, 2, 3, 4, null, 6, null, 8 };
            var binaryTree = BinaryTreeNode.CreateBinaryTree(list);
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
            Console.WriteLine($"后序遍历-反转前序遍历(迭代)={{ {string.Join(",", BinaryTreeNode.PostOrderTraverseByReversePre(binaryTree).ToList())}  }}");

            ///  前序遍历、中序遍历、后序遍历 统一写法
            Console.WriteLine($"前序遍历-统一写法(迭代)={{ {string.Join(",", BinaryTreeNode.UnitedTraverse(binaryTree, "前序遍历").ToList())}  }}");
            Console.WriteLine($"中序遍历-统一写法(迭代)={{ {string.Join(",", BinaryTreeNode.UnitedTraverse(binaryTree, "中序遍历").ToList())}  }}");
            Console.WriteLine($"后序遍历-统一写法(迭代)={{ {string.Join(",", BinaryTreeNode.UnitedTraverse(binaryTree, "后序遍历").ToList())}  }}");




            #endregion



            #region 力扣

            //二叉树的最小深度
            var tree = BinaryTreeNode.CreateBinaryTree(new List<int?> { 3, 9, 20, null, null, 15, 7 });
            Console.WriteLine($"二叉树的最小深度：{BinaryTreeNode.GetMinDepth(tree)}");

            #endregion














            Console.Read();
        }
    }
}
