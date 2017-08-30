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

            prog.CalculateMaxProfit();

            //prog.CalculateMaxDifference();

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
            int[] values = { 100, 20, 50, 40, 60 };
            int result = maxDiffrenece.CalculateMaxDifference(values);
            Console.WriteLine("The max difference within the given set of values is {0}", result);
        }
    }
}
