namespace algoexpert
{
// ​Product Sum

// Write a function that takes in a "special" array and returns its product sum.A "special" array 
// is a non-empty array that contains either integers or other "special" arrays.The product sum of 
// a "special" array is the sum of its elements, where "special" arrays inside it should be summed 
// themselves and then multiplied by their level of depth.For example, the product sum of [x, y] is 
// x + y; the product sum of[x, [y, z]] is x + 2y + 2z.

// Sample input: [5, 2, [7, -1], 3, [6, [-13, 8], 4]]
// Sample output: 12 (calculated as: (5 + 2 + 2 * (7 - 1) + 3 + 2 * (6 + 3 * (-13 + 8) + 4)))
using System.Collections.Generic;

public partial class Program
    {
        // O(n) time | O(d) space - where n is the total number of elements in the array,
        // including sub-elements, and d is the greatest depth of "special" arrays in the array
        public static int ProductSum(List<object> array)
        {
            return productSumHelper(array, 1);
        }

        public static int productSumHelper(List<object> array, int multiplier)
        {
            int sum = 0;
            foreach (object el in array)
            {
                if (el is IList<object>)
                {
                    sum += productSumHelper((List<object>)el, multiplier + 1);
                }
                else
                {
                    sum += (int)el;
                }
            }
            return sum * multiplier;
        }
    }
}