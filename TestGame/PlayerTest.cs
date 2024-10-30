using GameLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGame
{
    public class PlayerTest : IPlayer
    {
        public string Name
        {
            get { return "Player Test"; }
        }

        private Symbol _symbol;

        public PlayerTest(Symbol symbol)
        {
            _symbol = symbol;
        }

        public Symbol GetChoice()
        {
            return _symbol;
        }
    }
}
