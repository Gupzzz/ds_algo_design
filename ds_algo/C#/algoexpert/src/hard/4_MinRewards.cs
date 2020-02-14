namespace algoexpert
{
    // ​Min Rewards

    // Imagine that you're a teacher who's just graded the final exam in a class. You have a list of student scores on the final exam in a particular 
    // order (not necessarily sorted), and you want to reward your students. You decide to do so fairly by giving them arbitrary rewards following two 
    // rules: first, all students must receive at least one reward; second, any given student must receive strictly more rewards than an adjacent student 
    // (a student immediately to the left or to the right) with a lower score and must receive strictly fewer rewards than an adjacent student with a 
    // higher score. Assume that all students have different scores; in other words, the scores are all unique. Write a function that takes in a list 
    // of scores and returns the minimum number of rewards that you must give out to students, all the while satisfying the two rules.

    // Sample input: [8, 4, 2, 1, 3, 6, 7, 9, 5]
    // Sample output: 25 ([4, 3, 2, 1, 2, 3, 4, 5, 1])
    // Copyright © 2020 AlgoExpert, LLC. All rights reserved.

    using System;
    using System.Linq;

    // O(n) time | O(n) space - where in is the length of the input array
    public partial class Program
    {
        public static int MinRewards(int[] scores)
        {
            int[] rewards = new int[scores.Length];
            Array.Fill(rewards, 1);
            for (int i = 1; i < scores.Length; i++)
            {
                if (scores[i] > scores[i - 1]) rewards[i] = rewards[i - 1] + 1;
            }
            for (int i = scores.Length - 2; i >= 0; i--)
            {
                if (scores[i] > scores[i + 1])
                {
                    rewards[i] = Math.Max(rewards[i], rewards[i + 1] + 1);
                }
            }
            return rewards.Sum();
        }
    }
}