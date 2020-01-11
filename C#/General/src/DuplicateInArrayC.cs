using System;

namespace VScode
{
    public class DuplicateInArrayC{
        // Assuming all the input values are positive
        public void FindDuplicateInArray(int[] values){
            for (int i = 0; i < values.Length; i++)
            {
                if (values[Math.Abs(values[i])] > 0)
                    values[Math.Abs(values[i])] = - values[Math.Abs(values[i])];
                else
                    Console.WriteLine( String.Format("There is a duplicate present in the array." + 
                    " The value is {0}", Math.Abs(values[i]) ));
            }
        }
    }
}