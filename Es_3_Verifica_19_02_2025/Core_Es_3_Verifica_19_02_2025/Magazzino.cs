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
        private Queue<Richiesta> _listaAttesaCampioni;

        public Dictionary<Prodotto, HashSet<Campione>> Campioni
        {
            get { return _campioni; }
            set
            {
                if (value == null) throw new ArgumentNullException("campioni");
                _campioni = value;
            }
        }

        public Queue<Richiesta> ListaAttesaCampioni
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
            _listaAttesaCampioni = new Queue<Richiesta>();
        }

        public int NCampioniDiUnProdotto(Prodotto p)
        {
            int contatore = 0;
            if (p == null)
            {
                throw new ArgumentNullException("prodotto nullo");
            }
            else
            {
                if (Campioni.ContainsKey(p))
                {
                    foreach (Campione c in Campioni[p])
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

        public bool RichiediCampioniProdotti(Richiesta richiesta)
        {
            bool risultatoRichiesta = true;
            foreach (Campione campione in richiesta.Campioni)
            {
                foreach (Campione c in _campioni[campione.Prodotto])
                {
                    if (!c.Disponibile)
                    {
                        risultatoRichiesta = false;
                        if (!_listaAttesaCampioni.Contains(richiesta))
                        {
                            _listaAttesaCampioni.Enqueue(richiesta);
                            return false;;
                        }
                    }
                }
            }

            if (risultatoRichiesta)
            {
                foreach (Prodotto prodotto in _campioni.Keys)
                {
                    foreach (Campione campioneProdotto in _campioni[prodotto])
                    {
                        foreach (Campione c in richiesta.Campioni)
                        {
                            if (c.Equals(campioneProdotto))
                            {
                                campioneProdotto.Disponibile = false;
                                richiesta.Campioni.Remove(c);
                            }
                        }
                    }
                }
                List<Richiesta> richiesteLista = _listaAttesaCampioni.ToList();
                richiesteLista.Remove(richiesta);
                _listaAttesaCampioni.Clear();
                foreach (Richiesta richiestaLista in richiesteLista)
                {
                    _listaAttesaCampioni.Enqueue(richiestaLista);
                }
            }
            return true;
        }

        public bool RestituisciCampione(Campione campione)
        {
            if (_campioni.ContainsKey(campione.Prodotto))
            {
                foreach (Campione c in _campioni[campione.Prodotto])
                {
                    if (c.Equals(campione))
                    {
                        c.Disponibile = true;
                        break;
                    }
                }
            }
            else
            {
                return false;
                throw new Exception("il campione non esiste nel magazzino");
            }    
            VerificaEAggiornaRichiesteCampioneListaAttesa();
            return true;
        }

        private void VerificaEAggiornaRichiesteCampioneListaAttesa()
        {
            foreach (Richiesta richiesta in _listaAttesaCampioni)
            {
                RichiediCampioniProdotti(richiesta);
            }
        }

    }
}
