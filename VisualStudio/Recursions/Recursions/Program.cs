using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            //prog.FibonacciM();

            //prog.BinarySearchM();

            //prog.PerfectSquareM();

            //prog.TreeTraversalsM();

            //prog.ConstructTreeFromTraversalsM();

            //prog.TowerOfHanoiM();

            Console.ReadKey();
        }

        public void FibonacciM()
        {
            Fibonacci fibo = new Fibonacci();
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("{0} th value in fibonacci series is --> {1}", i, fibo.NthFibonacciValue(i));

            }
        }

        public void BinarySearchM()
        {
            BinarySearch bs = new BinarySearch();
            int[] content = { 2, 3, 4, 10, 40 };
            int value = 4;
            int result = bs.BinarySearchTheValue(content, value, 0, content.Length - 1);
            if (result == -1)
                Console.WriteLine("Element is not present in array");
            else
                Console.WriteLine("Element is present at index {0}", result);
        }

        public void PerfectSquareM()
        {
            PerfectSquare ps = new PerfectSquare();
            int n = 144;
            int result = ps.CheckPerfectSquare(n, 1, n);
            if (result == -1)
                Console.WriteLine("The given number is not a perfect square");
            else
                Console.WriteLine("The given number is a perfrct square and the squareroot is {0}", result);
        }

        public void TreeTraversalsM()
        {
            TreeTraversals treeTraversals = new TreeTraversals();            

            Node root = new Node('A')
            {
                left = new Node('B'),
                right = new Node('C')
            };

            root.left.left = new Node('D')
            {
                //left = new Node('F'),
                //right = new Node('G')
            };

            root.left.right = new Node('E')
            {
                //left = new Node('H'),
                //right = new Node('I')
            };

            treeTraversals.PreOrderTreeTraversal(root);
            Console.WriteLine();

            treeTraversals.InOrderTreeTraversal(root);
            Console.WriteLine();

            treeTraversals.PostOrderTreeTraversal(root);
            Console.WriteLine();
        }

        public void ConstructTreeFromTraversalsM()
        {
            char[] preOrderTraversal = { 'A', 'B', 'D', 'E', 'C' };
            char[] inOrderTraversal = { 'D', 'B', 'E', 'A', 'C' };
            //char[] postOrderTraversal = { 'D', 'E', 'B', 'C', 'A' };

            ConstructTreeFromTraversal constructTreeFromTraversal = new ConstructTreeFromTraversal();
            Node root = constructTreeFromTraversal.BuildTree(inOrderTraversal, preOrderTraversal, 0, inOrderTraversal.Length - 1);
            TreeTraversals treeTraversals = new TreeTraversals();
            treeTraversals.PostOrderTreeTraversal(root);
        }

        public void TowerOfHanoiM()
        {
            TowerOfHanoi towerOfHanoi = new TowerOfHanoi();
            towerOfHanoi.SolveTowerOfHanoi(3, "A", "B", "C");
        }


    }
}
