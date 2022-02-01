using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicProblems
{
    /// <summary>
    /// This public class is the class of the file ILogicProblem, which shares the same methods.
    /// </summary>
    public class LogicProblem : ILogicProblem
    {
        //TODO: Implement all requirements as defined in the project description.
        /// <summary>
        /// This method takes an array of integers, named "scores", and returns a double using the "Average" operation.
        /// </summary>
        /// <param name="scores">scores is the array of integers.</param>
        /// <returns>Method will return the total Average of the array into a double.</returns>
        /// <exception cref="NotImplementedException">This exception will throw if one or more integers in the array are negative integers.</exception>
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

        /// <summary>
        /// This method takes an integer, named "rungs", and returns another integer displaying the number of times you can reach the given integer.
        /// </summary>
        /// <param name="rungs">rungs is the integer given to determine its paths.</param>
        /// <returns>econdNumber is returned</returns>
        /// <exception cref="NotImplementedException">This exception will display if the given integer is a negative number.</exception>
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


        /// <summary>
        /// This method takes a group of strings, and returns a list of lists of the strings grouped by their first and last letter.
        /// </summary>
        /// <param name="strs">strs is the given array of strings.</param>
        /// <returns>This method will return the list of lists of strings that are grouped correctly.</returns>
        /// <exception cref="NotImplementedException">This exception will throw if any of the strings in the given array are empty.</exception>
        public List<List<string>> GroupStrings(string[] strs)
        {
            //make a dictionary
            var myDictionary = new Dictionary<string, List<string>>();

            List<List<string>> myList = new List<List<string>>();

            foreach (string word in strs)
            {
                if (String.IsNullOrEmpty(word))
                {
                    throw new NotImplementedException("strings must not be empty");
                }
                //get first and last letter into key
                var key = word.ToLower().Substring(0, 1) + word.Substring(word.Length - 1, 1);


                //loop through to see if key exists
                if (myDictionary.TryGetValue(key, out List<string> tempList))
                {
                    //does exist, add a row
                    tempList.Add(word);
                    myList.Add(tempList);
                }
                else
                {
                    myDictionary.Add(key, new List<string>() { word });
                }
            }
            myList = myDictionary.Values.ToList();
            return myList;
        }

        /// <summary>
        /// This method takes a given string, named "text", and returns the last word's length as an integer.
        /// </summary>
        /// <param name="text">text is the given string, such as "Hello World".</param>
        /// <returns>This method will return lastLength, which is the integer of the last word's length. Ex: "Hello World" -> "World" -> 5.</returns>
        /// <exception cref="NotImplementedException">This exception will display if the given string is empty. Whitespace is allowed.</exception>
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
