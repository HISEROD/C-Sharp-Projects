using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        //int[] testScores = { 98, 99, 85, 70, 82, 34, 91, 90, 94 };

        //for (int i = 0; i < testScores.Length; i++)
        //{
        //    if (testScores[i] > 85)
        //    {
        //        Console.WriteLine("Passing test score: " + testScores[i]);
        //    }
        //}

        //string[] names= { "Jesse", "Eric", "Daniel", "Adam" };

        //for (int blahblahblah = 0; blahblahblah < names.Length; blahblahblah++)
        //{
        //    Console.WriteLine(names[blahblahblah]);
        //}

        //List<int> testScores = new List<int>();
        //testScores.Add(98);
        //testScores.Add(99);
        //testScores.Add(73);
        //testScores.Add(72);
        //testScores.Add(98);
        //testScores.Add(94);

        //foreach (int score in testScores)
        //{
        //    Console.WriteLine(score);
        //}

        List<int> testScores = new List<int>() { 100, 2, 100, 88, 90, 50, 97, 99, 94, 99, 99, 99, 89, 61 };
        List<int> passingScores = new List<int>();

        foreach (int score in testScores)
        {
            if (score > 85)
            {
                passingScores.Add(score);
            }
        }
        Console.WriteLine(passingScores.Count);

        Console.ReadLine();
    }
}
