using ReadingAndWritingFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MorraCineseLibrary
{
    /// <summary>
    /// il giocatore umano deve potr scegliere il simbolo per mezzo di una interfaccia di input (console, wpf, file,..)
    /// </summary>
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }
        public WritingFile sw;

        private IInputInterface _input;
        public HumanPlayer(string name, IInputInterface inputInterface, string file)
        {
            Name = name;
            _input = inputInterface;
            sw = new WritingFile(file);
        }

        public Symbol GetChoice()
        {
            return _input.InputChoice();
        }
    }
}
