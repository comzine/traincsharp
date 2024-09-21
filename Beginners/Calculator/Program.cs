double firstNumber = 0,
    secondNumber = 0,
    result = 0;
int choice = 0;
string op = "";

const string ADD = "+";
const string SUBTRACT = "-";
const string MULTIPLY = "*";
const string DIVIDE = "/";
const string MODULUS = "%";

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
            do
            {
                System.Console.WriteLine("Input first number: ");
            } while (double.TryParse(Console.ReadLine(), out firstNumber) == false);
            break;
        case 2:
            System.Console.WriteLine("Input operator: ");
            op = Console.ReadLine();
            if (op != ADD && op != SUBTRACT && op != MULTIPLY && op != DIVIDE && op != MODULUS)
            {
                System.Console.WriteLine("Invalid operator");
            }
            break;
        case 3:
            System.Console.WriteLine("Input second number: ");
            try
            {
                secondNumber = Convert.ToDouble(Console.ReadLine());
            }
            catch (System.Exception e)
            {
                System.Console.WriteLine("Invalid number");
            }
            break;
        case 4:
            switch (op)
            {
                case ADD:
                    result = firstNumber + secondNumber;
                    break;
                case SUBTRACT:
                    result = firstNumber - secondNumber;
                    break;
                case MULTIPLY:
                    result = firstNumber * secondNumber;
                    break;
                case DIVIDE:
                    if (secondNumber == 0.0)
                    {
                        System.Console.WriteLine("Divide by zero");
                        break;
                    }
                    result = firstNumber / secondNumber;
                    break;
                case MODULUS:
                    result = firstNumber % secondNumber;
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
