using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestione_Ordini
{
    public class Azienda
    {
        private Dictionary<int, Prodotto> _prodotti;
        private HashSet<Cliente> _clienti;
        private Dictionary<Cliente, List<Ordine>> _ordini;
        private int _id = 0;
        
        public Dictionary<int, Prodotto> Prodotti
        {
            get { return _prodotti; }
            set { _prodotti = value; }
        }

        public HashSet<Cliente> Clienti
        {
            get { return _clienti; }
            set { _clienti = value; }
        }

        public Dictionary<Cliente, List<Ordine>> Ordini
        {
            get { return _ordini; }
            set { _ordini = value; }
        }

        public Azienda()
        {
            _prodotti = new Dictionary<int, Prodotto>();
            _clienti = new HashSet<Cliente>();
            _ordini = new Dictionary<Cliente, List<Ordine>>();
        }

        public void CreaOrdine(Cliente cliente, Dictionary<Prodotto, int> prodotti)
        {
            Ordine nuovoOrdine = new Ordine(_id, cliente, DateOnly.FromDateTime(DateTime.Now), prodotti);
            if(_ordini.ContainsKey(cliente))
            {
                _ordini[cliente].Add(nuovoOrdine);
            }
            else
            {
                _ordini.Add(cliente, new List<Ordine> { nuovoOrdine });
            }
        }

        public void RimuoviOrdine(Cliente cliente, Ordine ordine)
        {
            if(_ordini.ContainsKey(cliente))
            {
                _ordini[cliente].Remove(ordine);
            }
            else
            {
                throw new Exception("il cliente non esiste");
            }
        }

        /*
        public Ordine CercaOrdine(int idOrdine)
        {

        }
        */
    }
}
