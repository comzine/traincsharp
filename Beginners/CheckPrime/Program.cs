string input;
int number;

System.Console.WriteLine("Please enter a number:");
input = System.Console.ReadLine();
try {
    number = Convert.ToInt32(input);
    if (number < 2)
    {
        System.Console.WriteLine("The number is not prime.");
    }
    else
    {
        bool isPrime = true;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        if (isPrime)
        {
            System.Console.WriteLine("The number is prime.");
        }
        else
        {
            System.Console.WriteLine("The number is not prime.");
        }
    }
}
catch (FormatException)
{
    System.Console.WriteLine("The input is not a number.");
}