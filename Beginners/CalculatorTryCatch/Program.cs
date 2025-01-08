using System;

class Program
{
  static void Main(string[] args)
  {
    bool continueProgram = true;

    Console.WriteLine("Welcome to the Calculator!");

    while (continueProgram)
    {
      try
      {
        // Read first number
        Console.Write("\nPlease enter the first number: ");
        decimal number1 = Convert.ToDecimal(Console.ReadLine());

        // Read second number
        Console.Write("Please enter the second number: ");
        decimal number2 = Convert.ToDecimal(Console.ReadLine());

        // Read operator
        Console.Write("Please choose an operator (+, -, *, /): ");
        char operation = Console.ReadLine()[0];

        // Perform calculation
        decimal result = Calculate(number1, number2, operation);

        // Display result
        Console.WriteLine($"\nResult: {number1} {operation} {number2} = {result}");
      }
      catch (FormatException)
      {
        Console.WriteLine("\nError: Please enter a valid number!");
      }
      catch (DivideByZeroException)
      {
        Console.WriteLine("\nError: Division by zero is not allowed!");
      }
      catch (OverflowException)
      {
        Console.WriteLine("\nError: The number is too large or too small!");
      }
      catch (Exception ex)
      {
        Console.WriteLine($"\nError: {ex.Message}");
      }

      // Ask if user wants to continue
      Console.Write("\nDo you want to perform another calculation? (y/n): ");
      string answer = Console.ReadLine();
      continueProgram = answer.ToLower() == "y";
    }

    Console.WriteLine("\nProgram terminated.");
  }

  static decimal Calculate(decimal num1, decimal num2, char operation)
  {
    decimal result = 0;

    switch (operation)
    {
      case '+':
        result = num1 + num2;
        break;
      case '-':
        result = num1 - num2;
        break;
      case '*':
        result = num1 * num2;
        break;
      case '/':
        if (num2 == 0)
        {
          throw new DivideByZeroException();
        }
        result = num1 / num2;
        break;
      default:
        throw new Exception("Invalid operator! Only +, -, *, / are allowed");
    }

    return result;
  }
}
