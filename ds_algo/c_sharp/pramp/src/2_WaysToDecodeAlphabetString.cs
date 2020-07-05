using System;

namespace pramp
{
    public partial class Program
    {
        public static int WaysToDecodeAlphabetString(String str, int n)
        {
            if (n <= 1)
                return 1;

            int count = 0;
            count = WaysToDecodeAlphabetString(str, n - 1);

            if (
                str[n - 2] == '1' ||
                str[n - 2] == '2' && str[n - 1] < '7'
            )
            {
                count = count + WaysToDecodeAlphabetString(str, n - 2);
            }

            return count;
        }
        public static void _WaysToDecodeAlphabetString()
        {
            String str = "121";
            Console.WriteLine("No of ways to decode " + str + " is: " + WaysToDecodeAlphabetString(str, str.Length));
        }
    }
}