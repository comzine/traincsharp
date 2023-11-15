double fahrenheit, celsius;
int choose;

do {
    System.Console.WriteLine("Temperature Conversion Program");
    System.Console.WriteLine("1. Fahrenheit to Celsius");
    System.Console.WriteLine("2. Celsius to Fahrenheit");
    System.Console.WriteLine("3. Quit");
    System.Console.Write("Enter your choice: ");
    choose = int.Parse(Console.ReadLine());

    switch (choose) {
        case 1:
            System.Console.Write("Enter Fahrenheit temperature: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celsius = (fahrenheit - 32) * 5 / 9;
            System.Console.WriteLine("Celsius temperature is " + celsius);
            break;
        case 2:
            System.Console.Write("Enter Celsius temperature: ");
            celsius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = celsius * 9 / 5 + 32;
            System.Console.WriteLine("Fahrenheit temperature is " + fahrenheit);
            break;
        case 3:
            System.Console.WriteLine("Bye");
            break;
        default:
            System.Console.WriteLine("Invalid choice");
            break;
    }

} while (choose != 3);