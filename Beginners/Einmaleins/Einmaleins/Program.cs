System.Console.WriteLine("Einmaleins");
int maxZahl;
System.Console.Write("Bitte geben Sie die maximale Zahl ein: ");
maxZahl = Convert.ToInt32(System.Console.ReadLine());
for (int j = 1; j <= maxZahl; j++)
{
    for (int i = j; i <= j * maxZahl; i += j)
    {
        Console.Write("{0,4}", i);
    }
    Console.WriteLine();
}
Console.ReadKey();