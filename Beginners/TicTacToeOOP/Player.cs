namespace TicTacToeOOP
{
    public class Player
    {
        public string Name { get; }
        public char Mark { get; }

        public Player(string name, char mark)
        {
            Name = name;
            Mark = mark;
        }
    }
}
