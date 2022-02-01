using System;
using System.Collections.Generic;

namespace LogicProblems
{
    /*
    ***********************************************************
    ***********************************************************
    ***********************************************************
    **************DO NOT CHANGE THIS INTERFACE!!!**************
    ***********************************************************
    ******** EXCEPTION: TO ADD XML STRUCTURED COMMENTS ********
    ******************TO THE PUBLIC METHODS********************
    ***********************************************************
    ***********************************************************
    */

    public interface ILogicProblem
    {
        /// <summary>
        /// This method takes an array of integers, named "scores", and returns a double using the "Average" operation.
        /// </summary>
        /// <param name="scores">scores is the array of integers.</param>
        /// <returns>Method will return the total Average of the array into a double.</returns>
        double Average(int[] scores);

        /// <summary>
        /// This method takes a given string, named "text", and returns the last word's length as an integer.
        /// </summary>
        /// <param name="text">text is the given string, such as "Hello World".</param>
        /// <returns>This method will return lastLength, which is the integer of the last word's length. Ex: "Hello World" -> "World" -> 5.</returns>
        int LastWordLength(string text);

        /// <summary>
        /// This method takes an integer, named "rungs", and returns another integer displaying the number of times you can reach the given integer.
        /// </summary>
        /// <param name="rungs">rungs is the integer given to determine its paths.</param>
        /// <returns>econdNumber is returned</returns>
        decimal DistinctLadderPaths(int rungs);

        /// <summary>
        /// This method takes a group of strings, and returns a list of lists of the strings grouped by their first and last letter.
        /// </summary>
        /// <param name="strs">strs is the given array of strings.</param>
        ///  <returns>This method will return the list of lists of strings that are grouped correctly.</returns>
        List<List<string>> GroupStrings(string[] strs);
    }
}