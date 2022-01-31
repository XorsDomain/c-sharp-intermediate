using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicProblems
{
    public class LogicProblem : ILogicProblem
    {
        //TODO: Implement all requirements as defined in the project description.
        public double Average(int[] scores)
        {
            int i = 0;
            int sum = 0;
            double average = 0.0;
            if (scores.Length == 0)
            {
                return 0.00;
            }
            for (i = 0; i < scores.Length; i++)
            {
                sum += scores[i];
                if (scores[i] < 0)
                {
                    throw new NotImplementedException("scores must be positive");
                }
            }
            average = (double)sum / scores.Length;
            double total = Math.Round(average, 2, MidpointRounding.AwayFromZero);
            return total;
        }

        public decimal DistinctLadderPaths(int rungs)
        {
            decimal firstNumber = 1;
            decimal secondNumber = 2;
            if (rungs < 0)
            {
                throw new NotImplementedException("ladders can't have negative rungs");
            }
            if (rungs < 3)
            {
                return rungs;
            }
            for (int i = 3; i <= rungs; i++)
            {
                decimal numberOfPaths = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = numberOfPaths;
            }
            return secondNumber;
        }


        public List<List<string>> GroupStrings(string[] strs)
        {
            throw new NotImplementedException();
        }

        public int LastWordLength(string text)
        {
            List<string> newText = text.Trim().Split(' ').ToList();
            string last = newText.Last();
            int lastLength = last.Length;
            if (String.IsNullOrEmpty(text))
            {
                throw new NotImplementedException("input must not be an empty string");
            }
            return lastLength;
        }
    }
}
