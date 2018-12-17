using System;

namespace VScode
{
    class Program
    {
        public static void Main(string[] args)
        {
            Program programObject = new Program();

            // programObject.CalculateMaxProfit();

            // programObject.CalculateMaxDifference();

            // programObject.CalculateMinDiceThrowsSnakeAndLadders();           

            // programObject.SubstringOccurranceInStringM();

            // programObject.FibonacciM();

            // programObject.BinarySearchM();

            // programObject.PerfectSquareM();

            // programObject.TreeTraversalsM();

            // programObject.ConstructTreeFromTraversalsM();

            // programObject.TowerOfHanoiM();

            // programObject.MaxSumPathFromRootM();

            // programObject.RootToLeafSumM();

            // programObject.SubArrayWithSumGreaterThanNumberM();

            programObject.DuplicatesInArrayM();

            // Sum of k numbers equals n in a given array

            Console.Read();

        }

        public void DuplicatesInArrayM()
        {
            int[] arr = {1, 2, 3, 1, 3, 6, 6};
            DuplicatesInArrayC duplicatesInArrayC = new DuplicatesInArrayC();
            int[] duplicates = duplicatesInArrayC.DuplicatesInArray(arr);
            Console.WriteLine("The duplicates are as below:");
            for (int i = 0; i < duplicates.Length; i++)
            {
                Console.WriteLine("{0}", duplicates[i]);
            }
        }
        public void SubArrayWithSumGreaterThanNumberM()
        {
            SubArrayWithSumGreaterThanNumberC subArrayWithSumGreaterThanNumberC = new SubArrayWithSumGreaterThanNumberC();
            int[] arr = {1, 4, 45, 6, 0, 19};
            int result = subArrayWithSumGreaterThanNumberC.SubArrayWithSumGreaterThanNumber(arr, 51);
            Console.WriteLine("Length is {0}", result);
        }
        public void SubstringOccurranceInStringM()
        {
            SubStringOccurranceInStringC subStringOccurranceInStringC = new SubStringOccurranceInStringC();
            string completeString = "GeeksforGeeks";
            string subString = "Gks";
            int count = subStringOccurranceInStringC.SubStringOccurranceInString1(completeString,
                        subString, completeString.Length, subString.Length);
            Console.WriteLine("Count is : {0}", count);
        }
        public void MaxSumPathFromRootM()
        {
            NodeInt root = new NodeInt(10)
            {
                left = new NodeInt(20),
                right = new NodeInt(30)
            };

            root.left.left = new NodeInt(10)
            {
                left = new NodeInt(50),
                right = new NodeInt(100)
            };

            root.left.right = new NodeInt(200)
            {
                left = new NodeInt(40),
                right = new NodeInt(20)
            };
            MaxPathFromRoot maxPathFromRoot = new MaxPathFromRoot();
            maxPathFromRoot.FindMaxPathFromRoot(root);
        }
        public void RootToLeafSumM()
        {
            NodeInt root = new NodeInt(10)
            {
                left = new NodeInt(20),
                right = new NodeInt(30)
            };

            root.left.left = new NodeInt(10)
            {
                left = new NodeInt(50),
                right = new NodeInt(100)
            };

            root.left.right = new NodeInt(200)
            {
                left = new NodeInt(40),
                right = new NodeInt(20)
            };
            RootToLeafSum rootToLeafSum = new RootToLeafSum();
            rootToLeafSum.FindRootToLeafSum(root, 500);
        }
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
            Console.WriteLine("The max difference within the given set of values is {0} , such that larger value comes after the smallest", result);
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

            NodeChar root = new NodeChar('A')
            {
                left = new NodeChar('B'),
                right = new NodeChar('C')
            };

            root.left.left = new NodeChar('D')
            {
                //left = new Node('F'),
                //right = new Node('G')
            };

            root.left.right = new NodeChar('E')
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
            NodeChar root = constructTreeFromTraversal.BuildTree(inOrderTraversal, preOrderTraversal, 0, inOrderTraversal.Length - 1);
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
