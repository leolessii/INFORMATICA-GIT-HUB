using ReadingAndWritingFile;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorraCineseLibrary
{
    public class ComputerPlayer : IPlayer
    {
        public WritingFile sw;
        public string Name
        {
            get { return "Computer"; }
        }

        public ComputerPlayer(string file)
        {
            sw = new WritingFile(file);
        }

        public Symbol GetChoice()
        {
            Random r = new Random();
            Array values = Enum.GetValues(typeof(Symbol));

            return (Symbol)values.GetValue(r.Next(values.Length));
        }
    }
}
