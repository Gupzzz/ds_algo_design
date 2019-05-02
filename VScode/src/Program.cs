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

            // programObject.LengthOfLongestPalindromicSubStringM();

            // programObject.LongestPalindromicSubStringM(); 

            // programObject.AllPossibleCombinationsOfElementsM();

            // programObject.DuplicateInArrayM();

            // programObject.SubSetSumEqualsNumArrayM();

            // programObject.SpiralPrintingOfBinaryTreeM();

            // programObject.LowestCommonAncestorBinaryTreeM();

            // programObject.DiameterOfBinaryTreeM();

            // programObject.PairOfNumbersEqualsSumM();

            // programObject.ProductArrayM();

            // programObject.BSTFromPreorderTraversalM();

            // programObject.SerializeDeSerializeBinaryTreeM();

            // programObject.SmallestPositiveNumberM();

            // programObject.PossibleDecodingDP();

            programObject.MaxSumNonAdjacentM();


            // To Do problems:
            // Diameter of a tree
            // Addition in a linked list
            // Solve the registration (user name) problem using Trie
            // Detect islands in a graph
            // Platforms required for trains based on arrival and departure timings
            // A chapter dependent on another chapter
            // Highway banner
            // Reverse words in a sentence
            // Expression evaluation using bodmas, stacks
            // Max subarray of adjacent numbers in an array
        }
        public void MaxSumNonAdjacentM()
        {
            int[] arr = new int[]{5, 5, 10, 100, 10, 5};
            MaxSumNonAdjacentC maxSumNonAdjacentC = new MaxSumNonAdjacentC();
            Console.Write(maxSumNonAdjacentC.FindMaxSumNonAdjacent(arr, arr.Length));
        }
        public void PossibleDecodingDP()
        {
            char[] digits = { '1', '2', '3', '4' };
            int n = digits.Length;
            PossibleDecodingDPC possibleDecodingDPC = new PossibleDecodingDPC();
            Console.WriteLine("Count is " + possibleDecodingDPC.GetPossibleDecodingDP(digits, n));
        }
        public void SmallestPositiveNumberM()
        {
            int[] arr = { 0, 10, 2, 1, -10, -20 };
            int arr_size = arr.Length;
            SmallestPositiveNumberC smallestPositiveNumberC = new SmallestPositiveNumberC();
            int missing = smallestPositiveNumberC.findMissing(arr, arr_size);
            Console.WriteLine("The smallest positive missing number is " + missing);
        }
        public void SerializeDeSerializeBinaryTreeM()
        {
            // var node = new NodeString("root", new NodeString("left", 
            // new NodeString("left.left")), new NodeString("right"));
            NodeString root = new NodeString("root")
            {
                left = new NodeString("left"),
                right = new NodeString("right")
            };

            root.left.left = new NodeString("left.left") { };

            SerializeDeSerializeBinaryTreeC serializeDeSerializeBinaryTree = new SerializeDeSerializeBinaryTreeC();

            var serialized = serializeDeSerializeBinaryTree.Serialize(root);

            Console.WriteLine(serialized);
            root = serializeDeSerializeBinaryTree.Deserialize(serialized);

            Console.WriteLine(root.left.left.Value);
        }

        public void BSTFromPreorderTraversalM()
        {
            int[] preOrderTraversal = { 10, 5, 1, 7, 40, 50 };
            BSTFromPreorderTraversalC bstFromPreorderTraversal = new BSTFromPreorderTraversalC();
            NodeInt root = bstFromPreorderTraversal.ConstructBSTFromPreorderTraversal(preOrderTraversal, preOrderTraversal.Length);

            TreeTraversals treeTraversals = new TreeTraversals();
            treeTraversals.PreOrderTreeTraversal(root);

        }
        public void ProductArrayM()
        {
            ProductArray productArray = new ProductArray();
            int[] values = { 10, 3, 5, 6, 2 };    // Product array: 180 600 360 300 900 
            productArray.GenerateProductArray(values, values.Length);
        }
        public void PairOfNumbersEqualsSumM()
        {
            PairOfNumbersEqualsSumC pairOfNumbersEqualsSumC = new PairOfNumbersEqualsSumC();
            int[] values = { 10, 5, 60, 80, 45 };
            pairOfNumbersEqualsSumC.FindPairOfNumbersEqualsSum(values, 70);
        }
        public void DiameterOfBinaryTreeM()
        {
            NodeChar root = new NodeChar('A')
            {
                left = new NodeChar('B'),
                right = new NodeChar('C')
            };

            root.left.left = new NodeChar('D')
            {
                left = new NodeChar('F'),
                right = new NodeChar('G')
            };

            root.left.right = new NodeChar('E')
            {
                //left = new NodeChar('H'),
                //right = new NodeChar('I')
            };
            DiameterOfBinaryTreeC diameterOfBinaryTreeC = new DiameterOfBinaryTreeC();
            Console.WriteLine(diameterOfBinaryTreeC.FindDiameterOfBinaryTree(root));
        }
        public void LowestCommonAncestorBinaryTreeM()
        {
            NodeChar root = new NodeChar('A')
            {
                left = new NodeChar('B'),
                right = new NodeChar('C')
            };

            root.left.left = new NodeChar('D')
            {
                left = new NodeChar('F'),
                right = new NodeChar('G')
            };

            root.left.right = new NodeChar('E')
            {
                //left = new NodeChar('H'),
                //right = new NodeChar('I')
            };
            LowestCommonAncestorBinaryTreeC lowestCommonAncestorBinaryTreeC = new LowestCommonAncestorBinaryTreeC();
            Console.WriteLine(lowestCommonAncestorBinaryTreeC.FindLowestCommonAncestorBinaryTree(root, 'F', 'E'));
        }
        public void SpiralPrintingOfBinaryTreeM()
        {
            NodeChar root = new NodeChar('A')
            {
                left = new NodeChar('B'),
                right = new NodeChar('C')
            };

            root.left.left = new NodeChar('D')
            {
                left = new NodeChar('F'),
                right = new NodeChar('G')
            };

            root.left.right = new NodeChar('E')
            {
                //left = new NodeChar('H'),
                //right = new NodeChar('I')
            };
            SpiralPrintingOfBinaryTreeC spiralPrintingOfBinaryTreeC = new SpiralPrintingOfBinaryTreeC();
            spiralPrintingOfBinaryTreeC.SpiralPrintingOfABinaryTree(root);
        }
        public void SubSetSumEqualsNumArrayM()
        {
            int[] values = { 5, 100, 55, 72, 36, 40, 25 };
            int num = 187;
            SubSetSumArrayC subSetArrayC = new SubSetSumArrayC();
            bool result = subSetArrayC.SubSetSumEqualsSumArrayM(values, values.Length - 1, num);
            Console.WriteLine(result);
            bool dpResult = subSetArrayC.isSubsetSum(values, values.Length - 1, num);
            Console.WriteLine(dpResult);
        }
        public void DuplicateInArrayM()
        {
            DuplicateInArrayC duplicateInArrayC = new DuplicateInArrayC();
            int[] values = { 1, 2, 1, 3 };
            duplicateInArrayC.FindDuplicateInArray(values);
        }
        public void AllPossibleCombinationsOfElementsM()
        {
            AllPossibleCombinationsOfElementsC allPossibleCombinationsOfElementsC = new AllPossibleCombinationsOfElementsC();
            int[] arr = { 1, 2, 3, 4, 5 };
            int k = 5;
            int n = arr.Length;
            int[] data = new int[k];
            allPossibleCombinationsOfElementsC.GetAllPossibleCombinationsOfElements(arr, data, 0, n - 1, 0, k);
        }

        public void LongestPalindromicSubStringM()
        {
            String str = "gdabad";
            LongestPalindromicSubStringC longestPalindromicSubStringC = new LongestPalindromicSubStringC();
            int length = longestPalindromicSubStringC.GetLongestPalindromicSubString(str);
        }
        public void LengthOfLongestPalindromicSubStringM()
        {
            LengthOfLongestPalindromicSubSequenceC longestPalindromicSubStringC = new LengthOfLongestPalindromicSubSequenceC();
            string inputString = "amadamkr";
            int subStringLength = longestPalindromicSubStringC.GetLengthOfLongestPalindromicSubSequenceM(inputString, 0, inputString.Length - 1);
            Console.WriteLine(String.Format("The longest palamdromic substring in {0} is {1}", inputString, subStringLength));

            int otherSubStringLength = longestPalindromicSubStringC.lps(inputString);
            Console.WriteLine(String.Format("The longest palamdromic substring in {0} is {1}", inputString, otherSubStringLength));
        }
        public void SubArrayWithSumGreaterThanNumberM()
        {
            SubArrayWithSumGreaterThanNumberC subArrayWithSumGreaterThanNumberC = new SubArrayWithSumGreaterThanNumberC();
            int[] arr = { 1, 4, 45, 6, 0, 19 };
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

            root.left.left = new NodeInt(100)
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
            Console.WriteLine(rootToLeafSum.FindRootToLeafSum(root, 270));
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
            moves[1] = 28;
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
            char[] preOrderTraversal = { 'A', 'B', 'D', 'C' };
            char[] inOrderTraversal = { 'D', 'B', 'A', 'C' };
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
