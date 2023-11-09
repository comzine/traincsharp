
double firstNumber = 0, secondNumber = 0, result = 0;
int choice = 0;
string op = "";


do
{

    Console.WriteLine("Calculator");
    System.Console.WriteLine("1. Input first number");
    System.Console.WriteLine("2. Input operator");
    System.Console.WriteLine("3. Input second number");
    System.Console.WriteLine("4. Calculate");
    System.Console.WriteLine("5. Exit");
    System.Console.WriteLine("Input your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            System.Console.WriteLine("Input first number: ");
            try
            {
                firstNumber = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Invalid number");
            }
            break;
        case 2:
            System.Console.WriteLine("Input operator: ");
            op = Console.ReadLine();
            if (op != "+" && op != "-" && op != "*" && op != "/")
            {
                System.Console.WriteLine("Invalid operator");
            }
            break;
        case 3:
            System.Console.WriteLine("Input second number: ");
            secondNumber = Convert.ToDouble(Console.ReadLine());
            break;
        case 4:
            switch (op)
            {
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    System.Console.WriteLine("Invalid operator");
                    break;
            }
            System.Console.WriteLine($"{firstNumber} {op} {secondNumber} = {result}");
            break;
        case 5:
            System.Console.WriteLine("Exit");
            break;
        default:
            System.Console.WriteLine("Invalid choice");
            break;
    }
} while (choice != 5);