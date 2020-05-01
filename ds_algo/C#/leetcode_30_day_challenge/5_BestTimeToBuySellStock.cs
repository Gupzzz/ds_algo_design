using System;

namespace leetcode_30_day_challenge
{
    public partial class Program
    {
        public static int BestTimeToBuySellStock(int[] prices)
        {
            int maxProfit = 0;
            int i = 0, n = prices.Length;
            while (i < n)
            {
                while (i < n - 1 && prices[i + 1] < prices[i])
                    i++;
                int buy = prices[i];
                i++;
                while (i < n && prices[i] > prices[i - 1])
                    i++;
                int sell = prices[i - 1];
                maxProfit += sell - buy;
            }
            return maxProfit;
        }
        public static void _BestTimeToBuySellStock(){
            int[] prices = new int[] { 7, 1, 5, 3, 6, 4};
            foreach (var item in prices)
                Console.Write(item + "\t");
            Console.WriteLine("\nMaximum profit is " + BestTimeToBuySellStock(prices));
        }

    }
}