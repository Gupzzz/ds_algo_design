using System;
using System.Collections;

namespace pramp
{
    public partial class Program
    {
        public static int NewBudgetGrantAllocation(int[] grants, int newBudget)
        {
            int newCap = 0;

            Array.Reverse(grants);

            int oldBudget = 0;
            foreach (int item in grants)
                oldBudget += item;
            int surplus = oldBudget - newBudget;
            if (surplus <= 0)
                newCap = grants[0];

            for (int i = 0; i < grants.Length; i++)
            {
                surplus -= (i + 1) * (grants[i] - grants[i + 1]);
                if (surplus <= 0)
                    return grants[i + 1] - surplus / (i + 1);
            }
            return newCap;
        }
        public static int NewBudgetAllocationMethod2(int[] grants, int newBudget)
        {
            Array.Sort(grants);
            int n = grants.Length;
            int cap = newBudget / n;
            for (int i = 0; i < n; i++)
            {
                if(grants[i] < cap)
                {
                    newBudget = newBudget - grants[i];
                    cap = newBudget / (n - (i + 1));
                }
            }
            return cap;

        }
        public static void _NewBudgetGrantAllocation()
        {
            int[] grants = new int[] { 2, 100, 50, 120, 1000 };
            int newBudget = 190;
            int newCap = NewBudgetGrantAllocation(grants, newBudget);
            Console.WriteLine("The new cap after applying the new budget is: " + newCap);

            // Method 2
            Console.WriteLine("The new cap after applying the new budget is: " + NewBudgetAllocationMethod2(grants, newBudget) + " [Method 2]");
        }
    }
}