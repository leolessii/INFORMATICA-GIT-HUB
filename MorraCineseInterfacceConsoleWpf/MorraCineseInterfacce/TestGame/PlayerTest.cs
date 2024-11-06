using MorraCineseLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMorraCinese
{
    /// <summary>
    /// creo un giocatore di Test in modo da potergli assegnare il comportamento di interesse
    /// in questo caso voglio che il giocatore di Test effettui una scelta specifica di simbolo per poter testare tutte le combinazioni
    /// </summary>
    public class PlayerTest : IPlayer
    {
        public string Name
        {
            get { return "Player TEST"; }
        }

        private Symbol _symbol;

        /// <summary>
        /// imposta il simbolo del giocatore (quello che giocherà ad ogni chiamata di GetChoice)
        /// </summary>
        /// <param name="symbol"></param>
        public PlayerTest(Symbol symbol)
        {
            _symbol = symbol;
        }

        /// <summary>
        /// il comportamento del giocatore di test è quello di restituire il simbolo impostato dal costruttore
        /// </summary>
        /// <returns></returns>
        public Symbol GetChoice()
        {
            return _symbol;

        }
    }
}
