using System;

namespace StudentAverage
{
    public class Student
    {
        public string Name { get; set; }

        public int[] Scores { get; set; }

        public int? GetAverage()
        {
            int scoreSum = 0;

            for (int i = 0; i < Scores.Length; i++)
            {
                scoreSum += Scores[i];
            }

            return (scoreSum / Scores.Length);
        }
    }
}