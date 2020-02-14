using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace general
{
    public class SnakeAndLadder
    {
        // This function returns minimum number of dice throws required to
        // Reach last cell from 0'th cell in a snake and ladder game.
        // move[] is an array of size N where N is no. of cells on board
        // If there is no snake or ladder from cell i, then move[i] is -1
        // Otherwise move[i] contains cell to which snake or ladder at i
        // takes to.
        public int GetMinDiceThrows(int[] moves, int n)
        {
            // The graph has N vertices. Mark all the vertices as
            // not visited
            bool[] visited = new bool[n];
            for (int i = 0; i < n; i++)
                visited[i] = false;

            // Create a queue for BFS
            Queue<QueueEntry> queueForBFS = new Queue<QueueEntry>();

            // Mark the node 0 as visited and enqueue it.
            visited[0] = true;
            QueueEntry initialEntry = new QueueEntry()
            {
                VertexNumber = 0,
                HopsFromSource = 0
            };
            queueForBFS.Enqueue(initialEntry); // Enqueue 0'th vertex

            // Do a BFS starting from vertex at index 0
            QueueEntry queueEntry = new QueueEntry(); // A queue entry (qe)
            while (queueForBFS.Count != 0)
            {
                queueEntry = queueForBFS.ElementAt(0);
                int vertexNumber = queueEntry.VertexNumber; // vertex no. of queue entry

                // If front vertex is the destination vertex,
                // we are done
                if (vertexNumber == n - 1)
                    break;

                // Otherwise dequeue the front vertex and enqueue
                // its adjacent vertices (or cell numbers reachable
                // through a dice throw)
                queueForBFS.Dequeue();
                for (int j = vertexNumber + 1; j <= (vertexNumber + 6) && j < n; ++j)
                {
                    // If this cell is already visited, then ignore
                    if (!visited[j])
                    {
                        // Otherwise calculate its distance and mark it
                        // as visited
                        QueueEntry a = new QueueEntry()
                        {
                            HopsFromSource = (queueEntry.HopsFromSource + 1)
                        };
                        visited[j] = true;

                        // Check if there a snake or ladder at 'j'
                        // then tail of snake or top of ladder
                        // become the adjacent of 'i'
                        if (moves[j] != -1)
                            a.VertexNumber = moves[j];
                        else
                            a.VertexNumber = j;
                        queueForBFS.Enqueue(a);
                    }
                }
            }

            // We reach here when 'qe' has last vertex
            // return the distance of vertex in 'qe'
            return queueEntry.HopsFromSource;
        } 
    }

    public class QueueEntry
    {
        public int VertexNumber { get; set; }  // Vertex number
        public int HopsFromSource { get; set; }// Distance of this vertex from source
    };
}
