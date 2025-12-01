double kapital, zinsen, zinssatz, kapitalneu;
int jahr, zuBerechnendeJahre;
string eingabe;

Console.WriteLine("Kapitalberechnung");
Console.WriteLine("Mit diesem Programm " +
    "werden Zinsen " +
    "sowie das verzinste Kapital berechnet.");

int w = Console.WindowWidth;

for (int i = 0; i < w; i++)
{
    Console.Write("-");
}
Console.WriteLine();

Console.Write("{0,20}", "Startkapital: ");
eingabe = Console.ReadLine();
kapital = Convert.ToDouble(eingabe);
Console.Write("{0,20}", "Zinssatz: ");
eingabe = Console.ReadLine();
zinssatz = Convert.ToDouble(eingabe);
Console.Write("{0,20}", "Jahre: ");
eingabe = Console.ReadLine();
zuBerechnendeJahre = Convert.ToInt32(eingabe);

Console.WriteLine("{0,4}\t{1,8}\t{2,8}",
    "Jahr", "Zinsen", "Kapital");

zinsen = kapital / 100 * zinssatz;
kapitalneu = kapital + zinsen;
jahr = 1;

Console.WriteLine("{0,4}\t{1,8:F2}\t{2,8:F2}",
    jahr, zinsen, kapitalneu);
for (jahr = 2; jahr <= zuBerechnendeJahre; jahr++)
{
    kapital = kapitalneu;
    zinsen = kapital / 100 * zinssatz;
    kapitalneu = kapital + zinsen;

    Console.WriteLine("{0,4}\t{1,8:F2}\t{2,8:F2}",
        jahr, zinsen, kapitalneu);
}
Console.ReadKey();