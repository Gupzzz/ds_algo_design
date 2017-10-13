using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonRecursives
{
    public class StockPrize
    {
        public void  CalculateMaxProfit(int[] shareValue, int n)
        {
            if (n == 1)
            {
                return;
            }
            int count = 0;
            List<Interval> solution = new List<Interval>();

            int i = 0;
            while (i < n)
            {
                // Find Local Minima. Note that the limit is (n-2) as we are
                // comparing present element to the next element. 
                while ((i < n) && (shareValue[i + 1] <= shareValue[i]))
                {
                    i++;
                }

                // If we reached the end, break as no further solution possible
                if (i == n)
                {
                    break;
                }

                // Store the index of minima
                Interval e = new Interval()
                {
                    buy = i++
                };
                
                
                // Find Local Maxima.  Note that the limit is (n-1) as we are
                // comparing to previous element
                while ((i <= n) && (shareValue[i] >= shareValue[i - 1]))
                {
                    i++;
                }

                // Store the index of maxima
                e.sell = i - 1;
                solution.Add(e);

                // Increment number of buy/sell
                count++;
            }

            if (count == 0)
                Console.WriteLine("There is no day when buying the stock will make profit");
            else
                for (int j = 0; j < count; j++)
                    Console.WriteLine("Buy on day: " + (solution[j].buy + 1) + " Sell on day : " + (solution[j].sell + 1));
            return;
        }

    }
    public class Interval
    {
        public int buy, sell;

    }
}
