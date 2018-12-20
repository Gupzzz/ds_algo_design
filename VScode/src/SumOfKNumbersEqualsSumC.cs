namespace VScode
{
    public class SumOfKNumbersEqualsSumC
    {
        public bool SumOfKNumbersEqualsSum(int[] arr, int i, int k, int sum)
        {
            bool result = false;
            if(sum == 0 && k == 0)
                return true;
            else if (sum > 0 && k > 0 && i < arr.Length)
            {
                int currentSum = sum - arr[i++];
                result = result || SumOfKNumbersEqualsSum(arr, i, (k - 1), currentSum);
                result = result || SumOfKNumbersEqualsSum(arr, i, k, sum);  
                return result;
            }  
            return result;
        }
    }
}