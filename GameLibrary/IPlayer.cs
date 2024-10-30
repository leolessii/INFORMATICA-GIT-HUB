using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public interface IPlayer
    {
        string Name { get; }
        public Symbol GetChoice();
    }
}
