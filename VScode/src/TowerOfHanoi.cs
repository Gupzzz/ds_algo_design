using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VScode
{
    public class TowerOfHanoi
    {
        public void SolveTowerOfHanoi(int noOfDiscs, string source, string auxiliary, string destination)
        {
            if (noOfDiscs == 1)
            {
                Console.WriteLine("Move disc 1 from rod {0} to rod {1}", source, destination);
                return;
            }

            SolveTowerOfHanoi(noOfDiscs - 1, source, destination, auxiliary);
            Console.WriteLine("Move disk " + noOfDiscs + " from rod " + source + " to rod " + destination);
            SolveTowerOfHanoi(noOfDiscs - 1, auxiliary, source, destination);
        } 
    }
}
