using System;

class Assignment2B2

{
    static void Main(string[] args)
    {
        Console.Write("First number: ");
        int inputValue1 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Second number: ");
        int inputValue2 = Convert.ToInt16(Console.ReadLine());
        Console.Write("Number for Modulo Operation: ");
        int inputValue3 = Convert.ToInt16(Console.ReadLine());
        int addInput = inputValue1 + inputValue2;
        int subInput = inputValue1 - inputValue2;
        int multiplyInput = inputValue1 * inputValue2;
        int divideInput = inputValue1/ inputValue2;

        Console.WriteLine($"{inputValue1} + {inputValue2} = {addInput}." +
            $"The remainder if divided by {inputValue3} is {addInput % inputValue3}");
        Console.WriteLine($"{inputValue1} - {inputValue2} = {subInput}." +
            $"The remainder if divided by {inputValue3} is {subInput % inputValue3}");
        Console.WriteLine($"{inputValue1} * {inputValue2} = {multiplyInput}." +
            $"The remainder if divided by {inputValue3} is {multiplyInput % inputValue3}");
        Console.WriteLine($"{inputValue1} / {inputValue2} = {divideInput} (Approximately)." +
            $"The remainder if divided by {inputValue3} is {divideInput % inputValue3}");
    }
}