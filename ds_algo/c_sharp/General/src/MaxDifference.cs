﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general
{
    public class MaxDifference
    {
        // Calculate the max diff such that the larger element appears after the smaller element
        public int CalculateMaxDifference(int[] values)
        {
            int maxDiff = values[1] - values[0];
            int minElement = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] - minElement > maxDiff)
                    maxDiff = values[i] - minElement;
                if (values[i] < minElement)
                    minElement = values[i];
            }
            return maxDiff;
        }
    }
}
