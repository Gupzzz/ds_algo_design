using System;

namespace VScode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program programObject = new Program();

            #region Non recursive calls
            // programObject.CalculateMaxProfit();

            // programObject.CalculateMaxDifference();

            // programObject.CalculateMinDiceThrowsSnakeAndLadders();
            #endregion

            #region Recursive calls
            // programObject.FibonacciM();

            programObject.BinarySearchM();

            // programObject.PerfectSquareM();

            // programObject.TreeTraversalsM();

            // programObject.ConstructTreeFromTraversalsM();

            // programObject.TowerOfHanoiM();
            #endregion

            Console.Read();

        }

        #region NonRecursiveFunctions
        public void CalculateMaxProfit()
        {
            StockPrize stockPrize = new StockPrize();

            int[] shareValue = { 100, 20, 50, 40, 60 };
            stockPrize.CalculateMaxProfit(shareValue, shareValue.Length - 1);
        }

        public void CalculateMaxDifference()
        {
            MaxDifference maxDiffrenece = new MaxDifference();
            int[] values = { 100, 20, 50, 40, 90, 5 };
            int result = maxDiffrenece.CalculateMaxDifference(values);
            Console.WriteLine("The max difference within the given set of values is {0}", result);
        }

        public void CalculateMinDiceThrowsSnakeAndLadders()
        {

            // Let us construct the board given in above diagram
            int n = 30;
            int[] moves = new int[n];
            for (int i = 0; i < n; i++)
                moves[i] = -1;

            // Ladders
            moves[2] = 21;
            moves[4] = 7;
            moves[10] = 25;
            moves[19] = 28;

            // Snakes
            moves[26] = 0;
            moves[20] = 8;
            moves[16] = 3;
            moves[18] = 6;

            SnakeAndLadder snakeAndLadder = new SnakeAndLadder();

            Console.WriteLine(snakeAndLadder.GetMinDiceThrows(moves, n));
        }
        #endregion


        #region RecursiveFunctions
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
            int[] content = { 2, 4, 80, 90, 150 };
            int value = 90;
            int result = bs.BinarySearchTheValue(content, value, 0, content.Length - 1);
            if (result == -1)
                Console.WriteLine("Element is not present in the list of given values");
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
        #endregion

    }
}
