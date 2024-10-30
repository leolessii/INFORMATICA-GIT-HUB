using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public interface IOutput
    {
        public void OutputChoice(Symbol symbol1, Symbol symbol2);
    }
}
