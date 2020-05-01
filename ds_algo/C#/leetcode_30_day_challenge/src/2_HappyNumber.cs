using System;

namespace leetcode_30_day_challenge{
    public partial class Program{
        public static bool IsHappy(int n)
        {
            int slow, fast;
            slow = fast = n;
            do
            {
                slow = digitSquareSum(slow);
                fast = digitSquareSum(fast);
                fast = digitSquareSum(fast);
            } while (slow != fast);
            if (slow == 1) return true;
            else return false;
        }

        public static int digitSquareSum(int n)
        {
            int sum = 0, tmp;
            while (n != 0)
            {
                tmp = n % 10;
                sum += tmp * tmp;
                n /= 10;
            }
            return sum;
        }

        public static void _IsHappy(){
            int n = 19;
            Console.WriteLine("[Happy Number] The number " + n + " is " + IsHappy(n));
        }
    }
}