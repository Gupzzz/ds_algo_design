namespace VScode
{
    public class SumOfKNumbersEqualsSumC
    {
        public bool SumOfNumbersEqualsSum(int[] arr, int i, int sum)
        {
            bool result = false;
            if(sum == 0)
                return true;
            else if (sum > 0 && i < arr.Length)
            {
                int currentSum = sum - arr[i++];
                result = result || SumOfNumbersEqualsSum(arr, i, currentSum);
                result = result || SumOfNumbersEqualsSum(arr, i, sum);  
                return result;
            }  
            return result;
        }
    }
}