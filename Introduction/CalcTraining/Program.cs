int auswahl = 1;
Random rand = new Random();
int gesamt = 0, richtig = 0;
while (auswahl != 0)
{
    System.Console.WriteLine("Dieses Programm trainiert die Grundrechenarten.");
    int op = rand.Next(0, 4);
    int zahl1 = rand.Next(1, 101);
    int zahl2 = rand.Next(1, 101);
    int ergebnis = 0;
    if(op == 0)
    {
        System.Console.WriteLine("Wie viel ist " + zahl1 + " + " + zahl2 + "?");
        ergebnis = zahl1 + zahl2;
    }
    if(op == 1)
    {
        System.Console.WriteLine("Wie viel ist " + zahl1 + " * " + zahl2 + "?");
        ergebnis = zahl1 * zahl2;
    }
    if(op == 2)
    {
        System.Console.WriteLine("Wie viel ist " + zahl1 + " - " + zahl2 + "?");
        ergebnis = zahl1 - zahl2;
    }
    if(op == 3)
    {
        System.Console.WriteLine("Wie viel ist " + zahl1 + " / " + zahl2 + "?");
        ergebnis = zahl1 / zahl2;
    }
    int eingabe = Convert.ToInt32(System.Console.ReadLine());
    gesamt++;
    if(eingabe == ergebnis)
    {
        System.Console.WriteLine("Richtig!");
        richtig++;
    }
    else
    {
        System.Console.WriteLine("Falsch!");
    }
    System.Console.WriteLine("Nochmal? (1 = Ja, 0 = Nein)");
    auswahl = Convert.ToInt32(System.Console.ReadLine());
}
System.Console.WriteLine("Sie haben " + richtig + " von " + gesamt + " Aufgaben richtig gelöst.");