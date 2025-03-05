using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core_Es_3_Verifica_19_02_2025
{
    public class Magazzino
    {
        private Dictionary<Prodotto, HashSet<Campione>> _campioni;
        private Queue<Campione> _listaAttesaCampioni;

        public Dictionary<Prodotto, HashSet<Campione>> Campioni
        {
            get { return _campioni; }
            set
            {
                if (value == null) throw new ArgumentNullException("campioni");
                _campioni = value;
            }
        }

        public Queue<Campione> ListaAttesaCampioni
        {
            get { return _listaAttesaCampioni; }
            set
            {
                if (value == null) throw new ArgumentNullException("lista attesa campioni");
                _listaAttesaCampioni = value;
            }
        }

        public Magazzino()
        {
            _campioni = new Dictionary<Prodotto, HashSet<Campione>>();
            _listaAttesaCampioni = new Queue<Campione>();
        }

        public int NCampioniDiUnProdotto(Prodotto p)
        {
            int contatore = 0;
            if (p == null)
            {
                throw new ArgumentNullExeption(“prodotto nullo”);
            }
            else
            {
                if (Campioni.ContainsKey(p))
                {
                    foreach (Campione c in Campioni[p].TryGetValue())
                    {
                        if (c.Disponibile)
                        {
                            contatore++;
                        }
                    }
                }
            }
            return contatore;
        }

    }
}
