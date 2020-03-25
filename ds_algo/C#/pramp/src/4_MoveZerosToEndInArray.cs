using System;

namespace pramp
{
    public partial class Program
    {
        public static void MoveZerosToEndInArray(int[] input)
        {
            int left = 0;
            int right = input.Length - 1;

            while (left < right)
            {
                if (input[left] != 0)
                {
                    left++;
                    continue;
                }

                while (input[right] == 0)
                    right--;

                // Swap the two numbers
                input[left] = input[right];
                input[right] = 0;

                left++;
            }
        }
        public static void _MoveZerosToEndInArray()
        {
            int[] input = new int[] { 20, 40, 0, 0, 60, 0, 80, 0, 0, 0 };
            MoveZerosToEndInArray(input);
            Console.Write("Array after moving all zeros to the end [\t");
            foreach (int item in input)
            {
                Console.Write(item + "\t");
            }
            Console.Write("]");
        }
    }
}