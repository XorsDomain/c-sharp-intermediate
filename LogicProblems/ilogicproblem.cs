using System;
using System.Collections.Generic;

namespace LogicProblems
{
    //DO NOT CHANGE THE METHOD SIGNATURES BELOW!!
    public interface ILogicProblem
    {
        double average(int[] scores);

        int lastWordLength(string text);

        decimal distinctLadderPaths(int rungs);

        List<List<String>> groupStrings(String[] strs);
    }
}