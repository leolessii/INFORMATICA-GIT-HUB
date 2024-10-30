using GameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorraCinese
{
    public class ConsoleInput : IInput
    {
        public Symbol InputChoice()
        {
            Console.WriteLine("Write your symbol: Rock(r), Paper(p), Scissors(s)");
            string choice = Console.ReadLine().ToUpper();

            Symbol symbolchose;
            switch(choice)
            {
                case "R": symbolchose = Symbol.rock;
                    break;
                case "P": symbolchose = Symbol.paper;
                    break;
                case "S": symbolchose = Symbol.scissors;
                    break;
                default: throw new Exception("symbol not accepted");
            }

            return symbolchose;
        }
    }
}
