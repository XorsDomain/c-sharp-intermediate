# Intermediate Programming Project Template

Intermediate Programming Project Template is used to give trainees a base project for demonstrating logical thinking.

## Usage

Fill out LogicProblem with working solutions to the interface. Follow all requirements specified in the project instructions.

## Contributing

Feedback is welcome. If you see issues, or have ideas for improvement, please submit feedback!

## Description

This project contains methods and unit tests referring to the following:
1. Finding the Average of a given array of integers, returning a double. Cannot allow negative numbers.
2. Finding the length of the last word in a given string, returning an integer. Empty strings are not allowed. 
3. Finding the paths to a given number, returning an integer of how many times you can reach said number. Cannot allow negative numbers.
4. Grouping a list of strings into separate lists based on their first and last letter, strings cannot be empty. If there are only one or two words in a list, they will still be grouped into separate lists if they do not have matching first and last letters.

## How to run tests with code coverage

Go into the terminal, or GitBash, navigate to LogicProblems.Tests, and run the command:
 dotnet test -p:CollectCoverage=true -p:CoverletOutputFormat=lcov -p:CoverletOutput=./lcov.info
The output should show you how many tests have ran, and the number of how many passed, failed, or were skipped. The duration of all tests will also show.

## Linting

In order to lint code, press key combination:
Shift + Alt + F


