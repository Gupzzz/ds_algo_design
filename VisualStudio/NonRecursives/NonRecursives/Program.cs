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

            Console.ReadKey();
        }

        public void CalculateMaxProfit()
        {
            StockPrize stockPrize = new StockPrize();

            int[] shareValue = {100, 20, 50, 40, 60};
            int maxProfit = stockPrize.CalculateMaxProfit(shareValue);

            Console.WriteLine("The Max profit that can be obtained in the given period for the stock is {0} ", maxProfit);
        }

        public void CalculateMaxDifference()
        {
            MaxDifference maxDiffrenece = new MaxDifference();
            int[] values = { 100, 20, 50, 40, 60 };
            int result = maxDiffrenece.CalculateMaxDifference(values);
            Console.WriteLine("The max difference within the given set of values is {0}", result);
        }
    }
}
