
using MorraCineseLibrary;

namespace MorraCineseConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simulazione della partita tra pc e giocatore");
            Console.WriteLine("inserisciil nome del giocatore");
            string nome = Console.ReadLine();
            GameManager game = new GameManager(new ComputerPlayer(), new HumanPlayer(nome, new ConsoleInput()), new ConsoleOutput());

            Result roundResult = game.PlayRound();

            Console.WriteLine(roundResult.ToString());
        }
    }
}
