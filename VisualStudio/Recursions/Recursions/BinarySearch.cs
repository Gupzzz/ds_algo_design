using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursions
{
    class BinarySearch
    {
        public int BinarySearchTheValue( int[] content, int value, int left, int right )
        {            
            if ( right >= left )
            {
                int mid = left + ((right - left) / 2);

                // If the element is present at the middle itself
                if (content[mid] == value)
                    return mid;

                // If element is smaller than mid, then it can only be present
                // in left subarray
                if (content[mid] > value)
                    return BinarySearchTheValue( content, value, left, mid - 1 );

                // Else the element can only be present in right subarray
                return BinarySearchTheValue( content, value, mid + 1, right ) ;
            }

            // We reach here when element is not present in array
            return -1 ;

        }
    }
}
