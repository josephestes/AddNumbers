/*This program returns the sum of two integers from the user*/

using System;
using static System.Console;
class InteractiveAddition
{
    static void Main()
    {
        string userName, firstIntegerInputString, secondIntegerInputString;
        int firstIntegerInput, secondIntegerInput, sumOfInputIntegers;

        //Prompt for user name
        Write("Enter your name: ");
        userName = ReadLine();

        //Prompt for inputs and convert strings to integers
        Write("Hello {0}! Enter the first integer: ", userName);
        firstIntegerInputString = ReadLine();
        firstIntegerInput = Convert.ToInt32(firstIntegerInputString);

        Write("Enter the second integer: ");
        secondIntegerInputString = ReadLine();
        secondIntegerInput = Convert.ToInt32(secondIntegerInputString);

        //Calculate and output result
        sumOfInputIntegers = firstIntegerInput + secondIntegerInput;
        WriteLine("{0}, the sum of {1} and {2} is {3}", userName, firstIntegerInput, secondIntegerInput, sumOfInputIntegers);
    }
}
