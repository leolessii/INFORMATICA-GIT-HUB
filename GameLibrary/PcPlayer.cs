using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary
{
    public class PcPlayer : IPlayer
    {
        public string Name
        {
            get { return "Pc"; }
        }

        public Symbol GetChoice()
        {
            Random rnd = new Random();
            Array values = Enum.GetValues(typeof(Symbol));

            return (Symbol)values.GetValue(rnd.Next(values.Length));
        }
    }
}
