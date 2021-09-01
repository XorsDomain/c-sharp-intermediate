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
        double average(int[] scores);

        int lastWordLength(string text);

        decimal distinctLadderPaths(int rungs);

        List<List<String>> groupStrings(String[] strs);
    }
}