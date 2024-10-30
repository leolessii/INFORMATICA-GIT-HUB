using GameLibrary;

namespace MorraCinese
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulation of a game between pc and palyer");
            Console.WriteLine("Write your name");
            string name = Console.ReadLine();

            GameManager game = new GameManager(new PcPlayer(), new HumanPlayer(name, new ConsoleInput()));

            Results roundResults = game.Round();

            Console.WriteLine(roundResults.ToString());
        }
    }
}
