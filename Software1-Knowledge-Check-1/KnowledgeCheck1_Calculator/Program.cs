using System;

namespace KnowledgeCheck1_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello. Press 1 for addition, 2 for subtraction, 3 for multiplication, and 4 for division");

            var input = Console.ReadLine();
            var calculator = new Calculator();

            switch (input)
            {
                case "1":
                    var numbersForAddition = GetTwoNumbers("Let's do some Addition! Please input 2 numbers:");
                    if (double.TryParse(numbersForAddition[0], out double addNumOne) && double.TryParse(numbersForAddition[1], out double addNumTwo))
                    {
                        Console.WriteLine($"{numbersForAddition[0]} + {numbersForAddition[1]} = {calculator.Add(addNumOne, addNumTwo)}");
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not a double");
                    }
                    break;

                case "2":
                    var numbersForSubtraction = GetTwoNumbers("Let's do some Subtraction! Please input 2 numbers:");
                    if (double.TryParse(numbersForSubtraction[0], out double subNumOne) && double.TryParse(numbersForSubtraction[1], out double subNumTwo))
                    {
                        Console.WriteLine($"{numbersForSubtraction[0]} - {numbersForSubtraction[1]} = {calculator.Subtract(subNumOne, subNumTwo)}");
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not a double");
                    }
                    break;

                case "3":
                    var numbersForMultiplication = GetTwoNumbers("Let's do some Multiplication! Please input 2 numbers:");
                    if (double.TryParse(numbersForMultiplication[0], out double multNumOne) && double.TryParse(numbersForMultiplication[1], out double multNumTwo))
                    {
                        Console.WriteLine($"{numbersForMultiplication[0]} * {numbersForMultiplication[1]} = {calculator.Multiply(multNumOne, multNumTwo)}");
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not a double");
                    }
                    break;

                case "4":
                    var numbersForDivision = GetTwoNumbers("Let's do some Division! Please input 2 numbers:");
                    if (double.TryParse(numbersForDivision[0], out double divNumOne) && double.TryParse(numbersForDivision[1], out double divNumTwo))
                    {
                        if (divNumTwo == 0)
                        {
                            Console.WriteLine("Division by zero is not allowed.");
                        }
                        else
                        {
                            Console.WriteLine($"{numbersForDivision[0]} / {numbersForDivision[1]} = {calculator.Divide(divNumOne, divNumTwo)}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("One or more of the numbers is not a double");
                    }
                    break; **
            }
        }

        static string[] GetTwoNumbers(string prompt)
        {
            Console.WriteLine(prompt);
            Console.Write("Enter the first number: ");
            var number1 = Console.ReadLine();
            Console.Write("Enter the second number: ");
            var number2 = Console.ReadLine();
            return new string[] { number1, number2 };
        }
    }
}