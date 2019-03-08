using System;

class AllPossibleCOmbinationsOfElementsC{
    public void GetAllPossibleCombinationsOfElements(int[] arr, int[] data, int start, int end, int index, int k){
        // Current combination is ready to be printed, print it 
        if (index == k) 
        { 
            for (int j = 0; j < k; j++) 
                Console.Write(data[j] + " "); 
            Console.WriteLine(""); 
            return; 
        } 
  
        // replace index with all possible elements. The condition "end-i+1 >=  r-index" makes sure that including one element 
        // at index will make a  combination with remaining elements at remaining positions 
        for (int i = start; i <= end && end - i + 1 >= k - index; i++) 
        { 
            data[index] = arr[i]; 
            GetAllPossibleCombinationsOfElements(arr, data, i + 1, end, index + 1, k); 
        } 
    }
}