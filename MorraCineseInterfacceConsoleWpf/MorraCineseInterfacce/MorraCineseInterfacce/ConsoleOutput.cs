using MorraCineseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorraCineseConsole
{
    internal class ConsoleOutput : IOutputInterface
    {
        public void OutputChoices(Symbol symbol1, Symbol symbol2)
        {
            Console.WriteLine($"{symbol1} vs {symbol2}");
        }
    }
}
