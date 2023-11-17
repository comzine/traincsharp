string input;
string output = "";

Console.WriteLine("Enter a string to reverse: ");
input = Console.ReadLine();

for(int i = 0; i < input.Length; i++)
{
    output = input[i] + output;
}

Console.WriteLine("Reversed string: " + output);
Console.ReadKey();
