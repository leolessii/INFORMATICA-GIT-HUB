using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class HumanPlayer : IPlayer
    {
        public string Name { get; set; }
        private IInput _input;

        public HumanPlayer(string name, IInput input)
        {
            Name = name;
            _input = input;
        }

        public Symbol GetChoice()
        {
            return _input.InputChoice();
        }
    }
}
