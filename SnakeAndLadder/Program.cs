namespace SnakeAndLadder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------Welcome to the Snake and Ladder program");

            Game snakegame = new Game();
            snakegame.player1();
        }
    }
}