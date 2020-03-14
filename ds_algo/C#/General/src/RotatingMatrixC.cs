using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general
{
    public class RotatingMatrix
    {
        public int[,] execute(int[,] a)
        {
            for(int i = 0; i < a.GetLength(0); i++)
            {
                for(int j = i; j < a.GetLength(0); j++)
                {
                    int temp = a[i,j];
                    a[i,j] = a[j,i];
                    a[j,i] = temp;
                }
            }
            for(int i = 0; i < a.GetLength(0); i++)
            {
                int left = 0, right = a.GetLength(0) - 1;
                while(left <= right)
                {
                    int temp = a[i,left];
                    a[i,left] = a[i,right];
                    a[i,right] = temp;  
                    left++;
                    right--; 
                }
            }
            return a;
        }
    }
}