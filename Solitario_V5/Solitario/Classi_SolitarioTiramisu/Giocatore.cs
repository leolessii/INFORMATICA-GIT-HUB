using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classi_SolitarioTiramisu
{
    public class Giocatore
    {
        private string _nome;

        public Giocatore(string nome)
        {
            Nome = nome;
        }

        public string Nome
        {
            get { return _nome; }

            set
            {
                if (string.IsNullOrEmpty(value)) throw new ArgumentNullException("nome errato");
                else _nome = value;
            }
        }

    }
}
