using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;
using LogicProblems;

namespace LogicProblems.Tests
{
    public class LogicProblems
    {
        //TODO: Implement all requirements as specified in the requirements document
        LogicProblem logicProblem;

        public LogicProblems()
        {
            logicProblem = new LogicProblem();
        }

        [Fact]
        public void GetAverage_ReturnDouble_NonEmpty()
        {
            int[] numbers = { 4, 8, 13 };
            double expected = 8.33;
            var actual = logicProblem.Average(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetAverage_ReturnsZero_Empty()
        {
            int[] numbers = { };
            double expected = 0.00;
            var actual = logicProblem.Average(numbers);
            Assert.Equal(expected, actual);
        }
        [Fact]
        public void GetAverage_SingleInt_ReturnsDouble()
        {
            int[] numbers = { 5 };
            double expected = 5.00;
            var actual = logicProblem.Average(numbers);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetAverage_AtLeastOneNegative_ReturnsError()
        {
            int[] numbers = { 4, 8, -27 };
            string expected = "scores must be positive";
            var errorMsg =  Assert.Throws<NotImplementedException>(() => logicProblem.Average(numbers));
            Assert.Equal(expected, errorMsg.Message);
        }

        [Fact]
        public void DistinctLadder_ReturnsPaths_SmallNumber()
        {
            int number = 5;
            int expected = 8;
            var actual = logicProblem.DistinctLadderPaths(number);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DistinctLadder_ReturnPaths_AnotherNumber()
        {
            int number = 10;
            int expected = 89;
            var actual = logicProblem.DistinctLadderPaths(number);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DistinctLadder_ReturnPaths_Zero()
        {
            int number = 0;
            int expected = 0;
            var actual = logicProblem.DistinctLadderPaths(number);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DistinctLadder_ReturnPaths_LargerNumber()
        {
            int number = 50;
            long expected = 20365011074;
            var actual = logicProblem.DistinctLadderPaths(number);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void DistinctLadder_ReturnPaths_EvenLargerNumber()
        {
            int number = 100;
            decimal expected = 573147844013817084101m;
            var actual = logicProblem.DistinctLadderPaths(number);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckLastWord_InString_ReturnsLength()
        {
            string str = "Hello World";
            int expected = 5;
            var actual = logicProblem.LastWordLength(str);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckLastWord_WhitespaceString_ReturnsZero()
        {
            string str = " ";
            int expected = 0;
            var actual = logicProblem.LastWordLength(str);
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void CheckLastWord_EmptyString_ReturnsError()
        {
            string str = "";
            string expected = "input must not be an empty string";
            var errorMsg = Assert.Throws<NotImplementedException>(() => logicProblem.LastWordLength(str));
            Assert.Equal(expected, errorMsg.Message);
        }
    }
}
