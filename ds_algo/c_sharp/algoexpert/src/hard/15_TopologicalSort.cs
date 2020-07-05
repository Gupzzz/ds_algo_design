namespace algoexpert
{

    // Topological Sort

    // You are given a list of arbitrary jobs that need to be completed; these jobs are represented by integers. You are also given a list of
    //  dependencies. A dependency is represented as a pair of jobs where the first job is prerequisite of the second one. In other words, the
    //   second job depends on the first one; it can only be completed once the first job is completed. Write a function that takes in a list of jobs
    //    and a list of dependencies and returns a list containing a valid order in which the given jobs can be completed. If no such order exists,
    //     the function should return an empty list.

    // Sample input: [1, 2, 3, 4], [[1, 2], [1, 3], [3, 2], [4, 2], [4, 3]]
    // Sample output: [1, 4, 3, 2] or [4, 1, 3, 2]
    // Copyright © 2020 AlgoExpert, LLC. All rights reserved.

    using System.Collections.Generic;

    public partial class Program
    {
        // O(j + d) time | O(j + d) space
        public static List<int> TopologicalSort(List<int> jobs, List<int[]> deps)
        {
            JobGraph jobGraph = createJobGraph(jobs, deps);
            return getOrderedJobs(jobGraph);
        }

        public static JobGraph createJobGraph(List<int> jobs, List<int[]> deps)
        {
            JobGraph graph = new JobGraph(jobs);
            foreach (int[] dep in deps)
            {
                graph.addDep(dep[0], dep[1]);
            }
            return graph;
        }

        public static List<int> getOrderedJobs(JobGraph graph)
        {
            List<int> orderedJobs = new List<int>();
            List<JobNode> nodesWithNoPrereqs = new List<JobNode>();
            foreach (JobNode node in graph.nodes)
            {
                if (node.numOfPrereqs == 0)
                {
                    nodesWithNoPrereqs.Add(node);
                }
            }
            while (nodesWithNoPrereqs.Count > 0)
            {
                JobNode node = nodesWithNoPrereqs[nodesWithNoPrereqs.Count - 1];
                nodesWithNoPrereqs.RemoveAt(nodesWithNoPrereqs.Count - 1);
                orderedJobs.Add(node.job);
                removeDeps(node, nodesWithNoPrereqs);
            }
            bool graphHasEdges = false;
            foreach (JobNode node in graph.nodes)
            {
                if (node.numOfPrereqs > 0)
                {
                    graphHasEdges = true;
                }
            }
            return graphHasEdges ? new List<int>() : orderedJobs;
        }

        public static void removeDeps(JobNode node, List<JobNode> nodesWithNoPrereqs)
        {
            while (node.deps.Count > 0)
            {
                JobNode dep = node.deps[node.deps.Count - 1];
                node.deps.RemoveAt(node.deps.Count - 1);
                dep.numOfPrereqs--;
                if (dep.numOfPrereqs == 0) nodesWithNoPrereqs.Add(dep);
            }
        }

        public class JobGraph
        {
            public List<JobNode> nodes;
            public Dictionary<int, JobNode> graph;

            public JobGraph(List<int> jobs)
            {
                nodes = new List<JobNode>();
                graph = new Dictionary<int, JobNode>();
                foreach (int job in jobs)
                {
                    addNode(job);
                }
            }

            public void addDep(int job, int dep)
            {
                JobNode jobNode = getNode(job);
                JobNode depNode = getNode(dep);
                jobNode.deps.Add(depNode);
                depNode.numOfPrereqs++;
            }

            public void addNode(int job)
            {
                graph.Add(job, new JobNode(job));
                nodes.Add(graph[job]);
            }

            public JobNode getNode(int job)
            {
                if (!graph.ContainsKey(job)) addNode(job);
                return graph[job];
            }
        }

        public class JobNode
        {
            public int job;
            public List<JobNode> deps;
            public int numOfPrereqs;

            public JobNode(int job)
            {
                this.job = job;
                deps = new List<JobNode>();
                numOfPrereqs = 0;
            }
        }
    }
}