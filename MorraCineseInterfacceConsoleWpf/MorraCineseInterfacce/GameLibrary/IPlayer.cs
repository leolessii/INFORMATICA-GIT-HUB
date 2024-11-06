using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MorraCineseLibrary
{
    public interface IPlayer
    {
        string Name { get; }

        /// <summary>
        /// metodo per effettuare la scelta del simbolo da giocare
        /// </summary>
        /// <returns></returns>
        public Symbol GetChoice();
    }
}
