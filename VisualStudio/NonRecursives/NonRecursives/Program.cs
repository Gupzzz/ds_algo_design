using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursives
{
    public class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();

            //prog.CalculateMaxProfit();

            prog.CalculateMaxDifference();

            //prog.CalculateMinDiceThrowsSnakeAndLadders();

            Console.ReadKey();
        }

        public void CalculateMaxProfit()
        {
            StockPrize stockPrize = new StockPrize();

            int[] shareValue = {100, 20, 50, 40, 60};
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
    }
}
