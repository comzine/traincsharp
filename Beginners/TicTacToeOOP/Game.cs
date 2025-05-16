public class Game
{
    public Board MyBoard { get; private set; }
    public Player[] MyPlayers { get; private set; }

    public Game()
    {
        MyBoard = new Board();
        MyPlayers = new Player[2];
        MyPlayers[0] = new Player('X');
        MyPlayers[1] = new Player('O');

        int playerIndex = 0;

        while (!MyBoard.Unentschieden() && MyBoard.Won() != MyPlayers[0].Zeichen && MyBoard.Won() != MyPlayers[1].Zeichen)
        {
            Console.WriteLine(MyBoard);
            int[] zug = MyPlayers[playerIndex].Spielerzug();
            if (MyBoard.IsValid(zug))
            {
                MyBoard.Set(zug, MyPlayers[playerIndex].Zeichen);
                playerIndex = 1 - playerIndex;
            }
        }
        Console.WriteLine(MyBoard);
        if (MyBoard.Unentschieden())
        {
            Console.WriteLine("Unentschieden");
        }
        else if (MyBoard.Won() == MyPlayers[0].Zeichen)
        {
            Console.WriteLine("Spieler 1 hat gewonnen");
        }
        else
        {
            Console.WriteLine("Spieler 2 hat gewonnen");
        }
    }
}