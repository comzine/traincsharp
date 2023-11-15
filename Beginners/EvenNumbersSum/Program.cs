string eingabe;
int zahl;
int summe = 0;

do
{
    System.Console.Write("Bitte pos. Ganzzahl eigeben: ");
    eingabe = Console.ReadLine();
    zahl = Convert.ToInt32(eingabe);
} while (zahl <= 0);


for (int i = 1; i <= zahl; i++)
{
    if (i % 2 == 0)
    {
        summe = summe + i; // summe += i;
    }
}
System.Console.WriteLine("Summe: {0}", summe);
Console.ReadKey();