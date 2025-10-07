// Part 1
Console.WriteLine("Enter your name:");
string input = Console.ReadLine();
Console.WriteLine("Hello " + input);

// Part 2
Console.WriteLine("Enter your age in years:");
string name = input;
input = Console.ReadLine();
int ageInYears = Convert.ToInt32(input);

// Part 3
int yearsUntilRetirement = 67 - ageInYears;
Console.WriteLine(name + ", you have " + yearsUntilRetirement + " years until retirement.");