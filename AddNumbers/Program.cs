/*This program returns the sum of two integers from the user*/

using System;
using static System.Console;

class InteractiveAddition
{
    static void Main()
    {
        // Prompt for user name
        Write("Enter your name: ");
        string userName = ReadLine();

        // Prompt for inputs and convert strings to integers
        Write($"Hello {userName}! Enter the first integer: ");
        int firstIntegerInput = int.Parse(ReadLine());

        Write("Enter the second integer: ");
        int secondIntegerInput = int.Parse(ReadLine());

        // Calculate and output result
        int sumOfInputIntegers = firstIntegerInput + secondIntegerInput;
        WriteLine($"{userName}, the sum of {firstIntegerInput} and {secondIntegerInput} is {sumOfInputIntegers}");
    }
}
