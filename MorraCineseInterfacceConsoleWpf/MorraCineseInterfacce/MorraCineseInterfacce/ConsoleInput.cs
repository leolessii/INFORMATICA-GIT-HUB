using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MorraCineseLibrary;

namespace MorraCineseConsole
{
    internal class ConsoleInput : IInputInterface
    {
        public Symbol InputChoice()
        {
            Console.WriteLine("inserisci il tuo simbolo Sasso(S), Carta (C), Forbice (F)");
            Symbol simboloScelto;
            
            string scelta = Console.ReadLine().ToUpper();
                
            switch (scelta)
            {
                case "S":
                    simboloScelto = Symbol.Rock;
                    break;
                case "C":
                    simboloScelto = Symbol.Paper;
                    break;
                case "F":
                    simboloScelto = Symbol.Scissor;
                    break;
                default:
                    Console.WriteLine("simbolo inserito non previsto");
                    throw new Exception("simbolo inserito non previsto");
                        
            }
            
            return simboloScelto;
        }
    }
}
