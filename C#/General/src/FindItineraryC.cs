using System;
using System.Collections;

namespace VScode
{
    // https://www.geeksforgeeks.org/find-itinerary-from-a-given-list-of-tickets/
    public class FindItineraryC
    {
        // This function populates 'result' for given input 'dataset' 
        public void FindItinerary(Hashtable dataSet)
        {
            // To store reverse of given map 
            Hashtable reverseMap = new Hashtable();

            // To fill reverse map, iterate through the given map 
            foreach (String key in dataSet.Keys)
                reverseMap.Add(key, dataSet[key]);

            // Find the starting point of itinerary 
            String start = null;
            foreach (String key in dataSet.Keys)
            {
                if (reverseMap.Contains(key))
                {
                    start = key;
                    break;
                }
            }

            // If we could not find a starting point, then something wrong 
            // with input 
            if (start == null)
            {
                Console.WriteLine("Invalid Input");
                return;
            }

            // Once we have starting point, we simple need to go next, next 
            // of next using given hash map 
            String to = dataSet[start].ToString();
            while (to != null)
            {
                Console.WriteLine(start + "->" + to + ", ");
                start = to;
                to = dataSet[to]?.ToString();
            }
        }
    }
}