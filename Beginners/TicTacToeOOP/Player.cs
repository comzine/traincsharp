public class Player
{
    public char Zeichen { get; private set; }

    public Player(char zeichen)
    {
        this.Zeichen = zeichen;
    }

    public int[] Spielerzug()
    {
        int[] zug = new int[2];
        Console.WriteLine("Bitte Zug wählen im Format x,y (bsp. 1,0)");
        string eingabe = Console.ReadLine();
        zug[0] = eingabe[0] - '0';
        zug[1] = eingabe[2] - '0';
        return zug;
    }
}